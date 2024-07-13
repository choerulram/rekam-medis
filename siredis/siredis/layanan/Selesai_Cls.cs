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
    using System.Windows.Forms;

    internal class Selesai_Cls
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

        public Selesai_Cls()
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
        public DataTable tampikanData(string idDokter)
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
                    tb_rekam_medis.status = 'selesai'
                    AND tb_rekam_medis.id_dokter = @idDokter
                ORDER BY 
                    tb_rekam_medis.id_rekam ASC;
            ";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(Query))
                {
                    cmd.Parameters.AddWithValue("@idDokter", idDokter);
                    return server.eksekusiQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing query: {ex.Message}");
                return new DataTable();
            }
        }

        public DataTable tampilkanDgNama(string nama, string idDokter)
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
                    tb_rekam_medis.status = 'selesai'
                    AND tb_pasien.nama LIKE @namaPasien
                    AND tb_rekam_medis.id_dokter = @idDokter
                ORDER BY 
                    tb_rekam_medis.id_rekam ASC;
            ";

            MySqlCommand cmd = new MySqlCommand(Query);
            cmd.Parameters.AddWithValue("@namaPasien", "%" + nama + "%");
            cmd.Parameters.AddWithValue("@idDokter", idDokter);

            return server.eksekusiQuery(cmd);
        }
    }
}
