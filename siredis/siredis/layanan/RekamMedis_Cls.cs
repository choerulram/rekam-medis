using System;
using System.Collections.Generic;
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

    internal class RekamMedis_Cls
    {
        private string _id_pasien;
        private string _id_dokter;
        private string _keluhan;
        private string _tanggal;
        private string _status;

        KoneksiDB_Cls server;
        DataTable data;
        string Query;

        public RekamMedis_Cls()
        {
            _id_pasien = "";
            _id_dokter = "";
            _keluhan = "";
            _tanggal = "";
            _status = "";

            server = new KoneksiDB_Cls();
            data = new DataTable();
            Query = "";
        }

        // property untuk mengatur id pasien
        public string Id_Pasien
        {
            set { _id_pasien = value; } //mutator method
            //get { return _id; } //asesor method
        }

        // property untuk mengatur id dokter
        public string Id_Dokter
        {
            set { _id_dokter = value; }
        }

        // property untuk mengatur keluhan rekam_medis
        public string Keluhan_RekamMedis
        {
            set { _keluhan = value; }
        }

        // property untuk mengatur tanggal rekam_medis
        public string Tanggal_RekamMedis
        {
            set { _tanggal = value; }
        }

        // property untuk mengatur status rekam_medis
        public string Status_RekamMedis
        {
            set { _status = value; }
        }

        // metode untuk memeriksa apakah id jurusan sudah ada dalam database
        public bool apakahAda(string id)
        {
            bool cek = false;
            Query = $"select * from tb_rekam_medis where id_prodi = '{id}'";
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
                $"values ('{_id_pasien}', '{_id_dokter}', {_keluhan}, '{_tanggal}', '{_status}')";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal disimpan.");
                }
            }
            catch (Exception ex) { }

            return result;
        }

        // metode untuk menampilkan data dari database
        public DataTable tampikanData()
        {
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
                ORDER BY 
                    tb_rekam_medis.id_rekam ASC;
            ";

            return server.eksekusiQuery(Query);
        }

        public DataTable tampilkanDgNama(string nama)
        {
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

            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@namaPasien", "%" + nama + "%");

            return server.eksekusiQuery(cmd);
        }

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

            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@namaPasien", "%" + nama + "%");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow data in dt.Rows)
                {
                    kode = data["No. Kartu"].ToString();
                    break; // Ambil hanya satu kode pertama yang sesuai
                }
            }

            return kode;
        }

        // Mengambil data pasien dari database
        public DataTable getComboPasien()
        {
            Query = "select id_pasien as id_pasien, nama as nama from tb_pasien";
            return server.eksekusiQuery(Query);
        }

        // Mengambil data jurusan dari database
        public DataTable getComboDokter()
        {
            Query = "select id_dokter as id_dokter, nama as nama from tb_dokter";
            return server.eksekusiQuery(Query);
        }
    }
}
