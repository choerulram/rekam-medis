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
        private string _id_rekam;
        private string _id_pasien;
        private string _id_dokter;
        private string _keluhan;
        private string _tanggal;
        private string _status;

        KoneksiDB_Cls server;
        DataTable data;
        string Query;

        public DataDokter_Cls()
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
            ";

            return server.eksekusiQuery(Query);
        }
    }
}
