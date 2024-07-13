using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siredis.layanan
{
    using konfigurasi; // import konfigurasi namespace
    using MySql.Data.MySqlClient;
    using MySqlX.XDevAPI.Common;
    using siredis.antarmuka;
    using System.Data;

    internal class Pendaftaran_Cls
    {
        // deklarasi variabel
        private string _id_rekam;
        private string _id_pasien;
        private string _id_dokter;
        private string _keluhan;
        private string _tanggal;
        private string _status;

        // deklarasi objek koneksiDB_cls
        KoneksiDB_Cls server;
        DataTable data;
        string Query;

        // konstruktor untuk inisialisasi variabel
        public Pendaftaran_Cls()
        {
            _id_rekam = "";
            _id_pasien = "";
            _id_dokter = "";
            _keluhan = "";
            _tanggal = "";
            _status = "";

            server = new KoneksiDB_Cls();
            data = new DataTable();
            Query = "";
        }

        // properti untuk mengatur id rekam
        public string Id_Rekam
        {
            get { return _id_rekam; }
            set { _id_rekam = value; }
        }

        public string Id_Pasien
        {
            set { _id_pasien = value; } 
        }

        public string Id_Dokter
        {
            set { _id_dokter = value; }
        }

        public string Keluhan_RekamMedis
        {
            set { _keluhan = value; }
        }

        public string Tanggal_RekamMedis
        {
            set { _tanggal = value; }
        }

        public string Status_RekamMedis
        {
            set { _status = value; }
        }

        // metode untuk memeriksa apakah id rekam sudah ada dalam database
        public bool apakahAda()
        {
            bool cek = false;
            Query = $"SELECT * FROM tb_rekam_medis WHERE id_pasien = '{_id_pasien}' AND id_dokter = '{_id_dokter}' AND tanggal = '{_tanggal}'";
            data = server.eksekusiQuery(Query);
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
            Query = $"insert into tb_rekam_medis (id_pasien, id_dokter, keluhan, tanggal, status) " +
                    $"values ('{_id_pasien}', '{_id_dokter}', '{_keluhan}', '{_tanggal}', '{_status}')";
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
                // logging untuk kesalahan
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Query: {Query}");
            }

            return result;
        }

        // metode untuk mengubah data di database
        public int ubahData()
        {
            int result = -1;
            Query = $"UPDATE tb_rekam_medis SET keluhan = '{_keluhan}', status = '{_status}' " +
                $"WHERE id_pasien = '{_id_pasien}' AND id_dokter = '{_id_dokter}' " +
                $"AND tanggal = '{_tanggal}'";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal diubah.");
                }
            }
            catch (Exception ex) { }

            return result;
        }

        // metode untuk menghapus data di database
        public int hapusData(int idRekam)
        {
            int result = -1;
            Query = $"DELETE FROM tb_rekam_medis WHERE id_rekam = {idRekam}";
            try
            {
                Console.WriteLine($"Executing delete query: {Query}"); // logging query penghapusan
                result = server.eksekusiBukanQuery(Query);
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
                Console.WriteLine($"Error: {ex.Message}"); // logging pesan kesalahan
                Console.WriteLine($"Query: {Query}"); 
            }

            return result;
        }

        // metode untuk menampilkan data dari database
        public DataTable tampikanData()
        {
            Query = @"
                SELECT 
                    tb_rekam_medis.id_rekam AS 'ID Rekam',
                    tb_pasien.no_kartu AS 'No. Kartu',
                    tb_pasien.nama AS 'Pasien',
                    tb_rekam_medis.keluhan AS 'Keluhan',
                    tb_rekam_medis.tanggal AS 'Tanggal',
                    tb_rekam_medis.status AS 'Status',
                    tb_dokter.spesialis AS 'Spesialis',
                    tb_dokter.nama AS 'Dokter'
                FROM 
                    tb_rekam_medis
                INNER JOIN 
                    tb_pasien ON tb_pasien.id_pasien = tb_rekam_medis.id_pasien
                INNER JOIN 
                    tb_dokter ON tb_dokter.id_dokter = tb_rekam_medis.id_dokter
                WHERE 
                    tb_rekam_medis.status = 'pendaftaran'
                ORDER BY 
                    tb_rekam_medis.id_rekam ASC;
            ";

            return server.eksekusiQuery(Query);
        }

        // metode untuk menampilkan data dengan nama
        public DataTable tampilkanDgNama(string nama)
        {
            Query = @"
                SELECT 
                    tb_rekam_medis.id_rekam AS 'ID Rekam',
                    tb_pasien.no_kartu AS 'No. Kartu',
                    tb_pasien.nama AS 'Pasien',
                    tb_rekam_medis.keluhan AS 'Keluhan',
                    tb_rekam_medis.tanggal AS 'Tanggal',
                    tb_rekam_medis.status AS 'Status',
                    tb_dokter.spesialis AS 'Spesialis',
                    tb_dokter.nama AS 'Dokter'
                FROM 
                    tb_rekam_medis
                INNER JOIN 
                    tb_pasien ON tb_pasien.id_pasien = tb_rekam_medis.id_pasien
                INNER JOIN 
                    tb_dokter ON tb_dokter.id_dokter = tb_rekam_medis.id_dokter
                WHERE 
                    tb_rekam_medis.status = 'pendaftaran'
                AND
                    tb_pasien.nama LIKE @namaPasien
                ORDER BY 
                    tb_rekam_medis.id_rekam ASC;
            ";

            // membuat objek mysqlcommand untuk eksekusi query
            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@namaPasien", "%" + nama + "%");

            return server.eksekusiQuery(cmd);
        }

        // metode untuk mengambil kode berdasarkan nama
        public string ambilKodeDgNama(string nama)
        {
            string kode = "";
            DataTable dt = new DataTable();

            Query = @"
                SELECT 
                    tb_pasien.no_kartu AS 'No. Kartu',
                    tb_pasien.nama AS 'Pasien',
                    tb_rekam_medis.keluhan AS 'Keluhan',
                    tb_rekam_medis.tanggal AS 'Tanggal',
                    tb_rekam_medis.status AS 'Status',
                    tb_dokter.spesialis AS 'Spesialis',
                    tb_dokter.nama AS 'Dokter'
                FROM 
                    tb_rekam_medis
                INNER JOIN 
                    tb_pasien ON tb_pasien.id_pasien = tb_rekam_medis.id_pasien
                INNER JOIN 
                    tb_dokter ON tb_dokter.id_dokter = tb_rekam_medis.id_dokter
                WHERE 
                    tb_rekam_medis.status = 'pendaftaran'
                AND
                    tb_pasien.nama LIKE @namaPasien
                ORDER BY 
                    tb_rekam_medis.id_rekam ASC;
            ";

            // membuat objek mysqlcommand untuk eksekusi query
            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@namaPasien", "%" + nama + "%");

            // memeriksa apakah ada data
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow data in dt.Rows)
                {
                    kode = data["No. Kartu"].ToString();
                    break;
                }
            }

            return kode;
        }

        // mengambil data pasien dari database untuk combo box
        public DataTable getComboPasien()
        {
            Query = "select id_pasien as id_pasien, nama as nama from tb_pasien";
            return server.eksekusiQuery(Query);
        }

        // mengambil data dokter dari database untuk combo box
        public DataTable getComboDokter()
        {
            Query = "select id_dokter as id_dokter, nama as nama from tb_dokter";
            return server.eksekusiQuery(Query);
        }
    }
}
