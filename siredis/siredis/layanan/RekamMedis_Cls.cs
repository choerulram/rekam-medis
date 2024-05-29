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
        KoneksiDB_Cls server;
        DataTable data;
        string Query;

        public RekamMedis_Cls()
        {
            server = new KoneksiDB_Cls();
            data = new DataTable();
            Query = "";
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
    }
}
