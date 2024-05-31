using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using siredis.konfigurasi;

namespace siredis.konfigurasi
{
    internal class KoneksiDB_Cls : Konfigurasi_Cls
    {
        public MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        public string link = "server=localhost; port=3306; database=rekam_medis; uid=root; pwd=";

        // inisiasi objek koneksi, perintah sql, dan adapter
        public KoneksiDB_Cls()
        {
            conn = new MySqlConnection(link);
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        // method untuk membuka koneksi ke database
        public void bukaKoneksi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening connection: " + ex.Message);
            }
        }

        // method untuk menutup koneksi ke database
        public void tutupKoneksi()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing connection: " + ex.Message);
            }
        }

        // method untuk menjalankan perintah SQL yang bukan query (INSERT, UPDATE, DELETE)
        public override int eksekusiBukanQuery(string query, params MySqlParameter[] parameters)
        {
            int result = -1;
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(parameters);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exception (for example, log it)
                Console.WriteLine("Error executing non-query: " + ex.Message);
            }
            finally
            {
                tutupKoneksi();
            }

            return result;
        }

        // method untuk menjalankan perintah SQL query (SELECT)
        public override DataTable eksekusiQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable result = new DataTable();
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(parameters);
                adapter.SelectCommand = cmd;
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            finally
            {
                tutupKoneksi();
            }

            return result;
        }

        // method untuk menjalankan perintah SQL query (SELECT) dengan MySqlCommand
        public DataTable eksekusiQuery(MySqlCommand cmd)
        {
            DataTable result = new DataTable();
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                adapter.SelectCommand = cmd;
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            finally
            {
                tutupKoneksi();
            }

            return result;
        }
    }
}
