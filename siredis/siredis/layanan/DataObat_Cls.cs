using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace siredis.layanan
{
    using konfigurasi;

    internal class DataObat_Cls
    {
        private string _id_obat;
        private string _nama;

        KoneksiDB_Cls server;
        DataTable data;
        string Query;

        public DataObat_Cls()
        {
            _id_obat = "";
            _nama = "";

            server = new KoneksiDB_Cls();
            data = new DataTable();
            Query = "";
        }

        public string Id_Obat
        {
            get { return _id_obat; }
            set { _id_obat = value; }
        }

        public string Nama
        {
            set { _nama = value; }
        }

        public bool apakahAda()
        {
            bool cek = false;
            Query = "SELECT * FROM tb_obat WHERE id_obat = @id ";
            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@id", _id_obat);
            data = server.eksekusiQuery(cmd);
            if (data.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public int simpanData()
        {
            int result = -1;
            Query = "INSERT INTO tb_obat (id_obat, nama) VALUES (@id_obat, @nama)";
            try
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@id_obat", _id_obat),
                    new MySqlParameter("@nama", _nama)
                };
                result = server.eksekusiBukanQuery(Query, parameters);

                if (result < 0)
                {
                    throw new Exception("Gagal disimpan.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Query: {Query}");
            }

            return result;
        }

        public int ubahData()
        {
            int result = -1;
            Console.WriteLine($"ID Obat: {_id_obat}");

            Query = "UPDATE tb_obat SET nama = @nama WHERE id_obat = @id_obat";
            Console.WriteLine($"Query: {Query}");

            try
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@id_obat", _id_obat),
                    new MySqlParameter("@nama", _nama)
                };
                result = server.eksekusiBukanQuery(Query, parameters);

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

        public int hapusData(int idObat)
        {
            int result = -1;
            Query = "DELETE FROM tb_obat WHERE id_obat = @id_obat";
            try
            {
                Console.WriteLine($"Executing delete query: {Query}");
                MySqlParameter[] parameters = {
                    new MySqlParameter("@id_obat", idObat)
                };
                result = server.eksekusiBukanQuery(Query, parameters);

                if (result < 0)
                {
                    throw new Exception("Gagal dihapus.");
                }
                else
                {
                    Console.WriteLine("Data berhasil dihapus.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Query: {Query}");
            }

            return result;
        }

        public DataTable tampikanData()
        {
            Query = @"
                SELECT 
                    tb_obat.id_obat AS 'ID Obat',
                    tb_obat.nama AS 'Nama'
                FROM 
                    tb_obat
            ";

            MySqlCommand cmd = new MySqlCommand(Query);

            return server.eksekusiQuery(cmd);
        }

        public DataTable tampilkanDgNama(string nama)
        {
            Query = @"
                SELECT 
                    tb_obat.id_obat AS 'ID Obat',
                    tb_obat.nama AS 'Nama'
                FROM 
                    tb_obat
                WHERE 
                    tb_obat.nama LIKE @nama
            ";

            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

            return server.eksekusiQuery(cmd);
        }


    }
}
