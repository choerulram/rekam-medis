using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using siredis.konfigurasi;



namespace siredis.layanan
{
    // Kelas yang mengelola data pasien, termasuk operasi CRUD
    internal class DataPasien_Cls
    {
        // Deklarasi variabel untuk menyimpan data pasien
        private string _id_pasien;
        private string _no_kartu;
        private string _nama;
        private string _jenis_kelamin;
        private string _umur;

        // Objek untuk mengelola koneksi database
        KoneksiDB_Cls server;
        DataTable data;
        string Query;
        public DataPasien_Cls()
        {
            _id_pasien = "";
            _no_kartu = "";
            _nama = "";
            _jenis_kelamin = "";
            _umur = "";


            server = new KoneksiDB_Cls();
            data = new DataTable();
            Query = "";
        }


        // Properti untuk mengatur dan mendapatkan id pasien
        public string Id_Pasien
        {
            get { return _id_pasien; }
            set { _id_pasien = value; }
        }

        // Properti untuk mengatur dan mendapatkan nomor kartu pasien
        public string No_Kartu
        {
            get { return _no_kartu; }
            set { _no_kartu = value; }
        }

        // Properti untuk mengatur dan mendapatkan nama pasien
        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string Jenis_Kelamin
        {
            get { return _jenis_kelamin; }
            set { _jenis_kelamin = value; }
        }

        public string Umur
        {
            get { return _umur; }
            set { _umur = value; }
        }

        // Metode untuk memeriksa apakah data pasien sudah ada
        public bool apakahAda()
        {
            bool cek = false;
            Query = "SELECT COUNT(*) FROM tb_pasien WHERE no_kartu = @no_kartu";
            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@no_kartu", _no_kartu);
            Console.WriteLine("Checking for no_kartu: " + _no_kartu); // Debugging
            data = server.eksekusiQuery(cmd);

            if (data.Rows.Count > 0 && Convert.ToInt32(data.Rows[0][0]) > 00)
            {
                cek = true;
            }

            return cek;
        }




        // Metode untuk menyimpan data pasien baru ke database
        public int simpanData()
        {
            int result = -1;
            string query = $"INSERT INTO tb_pasien ( id_pasien, nama, no_kartu, umur, jk) VALUES ('{_id_pasien}', '{_nama}', '{_no_kartu}', '{_umur}', '{_jenis_kelamin}')";

            try
            {
                result = server.eksekusiBukanQuery(query);
                if (result < 0)
                {
                    throw new Exception("Gagal menyimpan data.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Query: {query}");
            }

            return result;
        }


        // Metode untuk memperbarui data pasien yang ada
        public int updateData()
        {
            int result = -1;
            if (string.IsNullOrEmpty(_id_pasien))
            {
                Console.WriteLine("ID Pasien tidak diatur.");
                return result;
            }

            Query = $"UPDATE tb_pasien SET nama = '{_nama}', no_kartu = '{_no_kartu}', umur = '{_umur}', jk = '{_jenis_kelamin}' WHERE id_pasien = '{_id_pasien}'";

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


        // Metode untuk menghapus data pasien
        public int hapusData(int idPasien)
        {
            int result = -1;
            Query = $"DELETE FROM tb_pasien WHERE id_pasien = {idPasien}";
            try
            {

                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal dihapus.");
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
        public DataTable tampilkanDataPasien()
        {
            string query = "SELECT * FROM tb_pasien";
            return server.eksekusiQuery(query);
        }



        // Metode untuk menampilkan data pasien berdasarkan nama
        public DataTable tampilkanDataPasienDgNama(string nama)
        {
            string query = "SELECT * FROM tb_pasien WHERE nama LIKE @nama";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

            return server.eksekusiQuery(cmd);
        }





    }
}
