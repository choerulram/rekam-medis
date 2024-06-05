using MySql.Data.MySqlClient;
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
        private string _username;
        private string _password;

        KoneksiDB_Cls server;
        DataTable data;
        string Query;

        public DataDokter_Cls()
        {
            _id_dokter = "";
            _nama = "";
            _jenis_kelamin = "";
            _spesialis = "";
            _username = "";
            _password = "";

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

        // property untuk mengatur keluhan rekam_medis
        public string Username
        {
            set { _username = value; }
        }

        // property untuk mengatur tanggal rekam_medis
        public string Password
        {
            set { _password = value; }
        }

        // metode untuk memeriksa apakah id dokter sudah ada dalam database
        public bool apakahAda()
        {
            bool cek = false;
            Query = "SELECT * FROM tb_dokter WHERE nama = @nama AND username = @username";
            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@nama", _nama);
            cmd.Parameters.AddWithValue("@username", _username);
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
            Query = $"insert into tb_dokter (nama, jk, spesialis, username, password) " +
                    $"values ('{_nama}', '{_jenis_kelamin}', '{_spesialis}', '{_username}', '{_password}')";
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
                    $"SET nama = '{_nama}', jk = '{_jenis_kelamin}', spesialis = '{_spesialis}'," +
                    $" username = '{_username}', password = '{_password}' " +
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

        // metode untuk menampilkan data dari database
        public DataTable tampikanData()
        {
            Query = @"
                SELECT 
                    tb_dokter.id_dokter AS 'ID Dokter',
                    tb_dokter.nama AS 'Nama',
                    tb_dokter.jk AS 'Jenis Kelamin',
                    tb_dokter.spesialis AS 'Spesialis',
                    tb_dokter.username AS 'Username',
                    tb_dokter.password AS 'Password'
                FROM 
                    tb_dokter
            ";

            return server.eksekusiQuery(Query);
        }

        public DataTable tampilkanDgNama(string nama)
        {
            Query = @"
                SELECT 
                    tb_dokter.id_dokter AS 'ID Dokter',
                    tb_dokter.nama AS 'Nama',
                    tb_dokter.jk AS 'Jenis Kelamin',
                    tb_dokter.spesialis AS 'Spesialis',
                    tb_dokter.username AS 'Username',
                    tb_dokter.password AS 'Password'
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
