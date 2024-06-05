using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace siredis.layanan
{
    using konfigurasi;
    using System.Windows.Forms;
    internal class Resep_Cls
    {
        private string _id_rekam;
        private string _id_pasien;
        private string _id_dokter;
        private string _keluhan;
        private string _tanggal;
        private string _status;

        KoneksiDB_Cls server;
        DataTable data;
        string Query;

        public Resep_Cls()
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

        // property untuk mengatur id dokter
        public string Id_Rekam
        {
            get { return _id_rekam; }
            set { _id_rekam = value; }
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

        // metode untuk menampilkan data dari database
        public DataTable tampilkanResep()
        {
            Query = $"SELECT rm.*, p.nama AS nama_pasien, d.nama AS nama_dokter, o.nama AS resep_obat " +
            $"FROM tb_rekam_medis rm " +
            $"JOIN tb_pasien p ON rm.id_pasien = p.id_pasien " +
            $"JOIN tb_dokter d ON rm.id_dokter = d.id_dokter " +
            $"JOIN tb_resep r ON rm.id_rekam = r.id_rekam " +
            $"JOIN tb_obat o ON r.id_obat = o.id_obat " +
            $"WHERE rm.id_rekam = '{_id_rekam}'";

            return server.eksekusiQuery(Query);
        }
    }
}
