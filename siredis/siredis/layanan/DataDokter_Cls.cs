﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siredis.layanan
{
    using konfigurasi;
    using MySql.Data.MySqlClient;
    using MySqlX.XDevAPI.Common;
    using siredis.antarmuka;
    using System.Data;
    internal class DataDokter_Cls
    {
        private string _id_dokter;
        private string _nama;
        private string _jenis_kelamin;
        private string _spesialis;

        KoneksiDB_Cls server;
        DataTable data;
        string Query;

        public DataDokter_Cls()
        {
            _id_dokter = "";
            _nama = "";
            _jenis_kelamin = "";
            _spesialis = "";

            server = new KoneksiDB_Cls();
            data = new DataTable();
            Query = "";
        }

        // property untuk mengatur id dokter
        public string Id_Dokter
        {
            get { return _id_dokter; }
            set { _id_dokter = value; }
        }

        public string Nama
        {
            set { _nama = value; }
        }

        // property untuk mengatur id pasien
        public string Jenis_Kelamin
        {
            set { _jenis_kelamin = value; }
        }

        // property untuk mengatur id dokter
        public string Spesialis
        {
            set { _spesialis = value; }
        }

        // metode untuk memeriksa apakah id dokter sudah ada dalam database
        public bool apakahAda()
        {
            bool cek = false;
            Query = "SELECT * FROM tb_dokter WHERE nama = @nama";
            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@nama", _nama);
            data = server.eksekusiQuery(cmd);
            if (data.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        // metode untuk menyimpan data baru ke database
        public int simpanData()
        {
            int result = -1;
            Query = $"insert into tb_dokter (nama, jk, spesialis) " +
                    $"values ('{_nama}', '{_jenis_kelamin}', '{_spesialis}')";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal disimpan.");
                }
            }
            catch (Exception ex)
            {
                // Tambahkan logging untuk kesalahan
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Query: {Query}");
            }

            return result;
        }

        public int ubahData()
        {
            int result = -1;
            // Tambahkan logging untuk memeriksa nilai id_dokter sebelum update
            Console.WriteLine($"ID Dokter: {_id_dokter}");

            Query = $"UPDATE tb_dokter " +
                    $"SET nama = '{_nama}', jk = '{_jenis_kelamin}', spesialis = '{_spesialis}'" +
                    $"WHERE id_dokter = '{_id_dokter}'";

            // Tambahkan logging untuk memeriksa query yang dijalankan
            Console.WriteLine($"Query: {Query}");

            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal diubah.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Query: {Query}");
            }

            return result;
        }

        // Metode untuk menghapus data di database
        public int hapusData(int idDokter)
        {
            int result = -1;
            Query = $"DELETE FROM tb_dokter WHERE id_dokter = {idDokter}";
            try
            {
                Console.WriteLine($"Executing delete query: {Query}"); // Logging query penghapusan
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal dihapus.");
                }
                else
                {
                    Console.WriteLine("Data berhasil dihapus."); // Pesan berhasil dihapus
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); // Logging pesan kesalahan
                Console.WriteLine($"Query: {Query}"); // Logging query saat terjadi kesalahan
            }

            return result;
        }

        // metode untuk menampilkan data dari database
        public DataTable tampikanData()
        {
            Query = @"
                SELECT 
                    tb_dokter.id_dokter AS 'ID Dokter',
                    tb_dokter.nama AS 'Nama',
                    tb_dokter.jk AS 'Jenis Kelamin',
                    tb_dokter.spesialis AS 'Spesialis'
                FROM 
                    tb_dokter
            ";

            Console.WriteLine("Executing query: " + Query); // Logging query
            return server.eksekusiQuery(Query);
        }

        public DataTable tampilkanDgNama(string nama)
        {
            Query = @"
                SELECT 
                    tb_dokter.id_dokter AS 'ID Dokter',
                    tb_dokter.nama AS 'Nama',
                    tb_dokter.jk AS 'Jenis Kelamin',
                    tb_dokter.spesialis AS 'Spesialis'
                FROM 
                    tb_dokter
                WHERE 
                    tb_dokter.nama LIKE @nama
            ";

            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

            return server.eksekusiQuery(cmd);
        }
    }
}
