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

    internal class PemeriksaanDokter_Cls
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

        public PemeriksaanDokter_Cls()
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
        public DataTable tampilkanDataRekam() 
        {
            Query = $"SELECT rm.*, p.nama AS nama_pasien FROM tb_rekam_medis rm " +
            $"JOIN tb_pasien p ON rm.id_pasien = p.id_pasien " +
            $"WHERE rm.id_rekam = '{_id_rekam}'";

            return server.eksekusiQuery(Query);
        }

        public DataTable tampilkanDataObat()
        {
            Query = "SELECT * FROM tb_obat ORDER BY nama ASC";

            return server.eksekusiQuery(Query);
        }

        public bool UpdateDiagnosis(string id_rekam, string diagnosis)
        {
            try
            {
                string query = "UPDATE tb_rekam_medis SET diagnosa = @diagnosis WHERE id_rekam = @id_rekam";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@diagnosis", diagnosis),
                    new MySqlParameter("@id_rekam", id_rekam)
                };
                int result = server.eksekusiBukanQuery(query, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"UpdateDiagnosis Error: {ex.Message}");
                return false;
            }
        }

        public bool SavePrescription(string id_rekam, List<string> obatList, string keterangan)
        {
            bool isSuccess = true;
            foreach (var id_obat in obatList)
            {
                string query = "INSERT INTO tb_resep (id_rekam, id_obat, keterangan, nama) VALUES (@id_rekam, @id_obat, @keterangan, 'DefaultNama')";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@id_rekam", id_rekam),
                    new MySqlParameter("@id_obat", id_obat),
                    new MySqlParameter("@keterangan", keterangan)
                };

                try
                {
                    int result = server.eksekusiBukanQuery(query, parameters);
                    if (result <= 0)
                    {
                        isSuccess = false;
                        MessageBox.Show($"Failed to insert prescription for id_obat: {id_obat}");
                        break;
                    }
                }
                catch (Exception ex)
                {
                    isSuccess = false;
                    MessageBox.Show($"Exception occurred while inserting prescription for id_obat: {id_obat}. Exception: {ex.Message}");
                    break;
                }
            }
            return isSuccess;
        }
    }
}
