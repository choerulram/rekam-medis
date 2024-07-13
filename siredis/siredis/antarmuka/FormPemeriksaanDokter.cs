using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siredis.antarmuka
{
    using layanan;
    using System.Globalization;
    using siredis.antarmuka;
    using System.Windows.Forms.VisualStyles;
    public partial class FormPemeriksaanDokter : Form
    {
        PemeriksaanDokter_Cls rekam_medis = new PemeriksaanDokter_Cls();

        public string ID { get; set; } // Property untuk menyimpan ID rekam medis yang akan ditampilkan
        public FormPemeriksaanDokter()
        {
            InitializeComponent();
        }

        private void FormPemeriksaanDokter_Load(object sender, EventArgs e)
        {
            // Menampilkan data rekam medis
            rekam_medis.Id_Rekam = ID;
            DataTable dtRekam = rekam_medis.tampilkanDataRekam();
            if (dtRekam.Rows.Count > 0)
            {
                DataRow row = dtRekam.Rows[0];
                lpasien.Text = row["nama_pasien"].ToString();
                tKeluhan.Text = row["keluhan"].ToString();
            }
            else
            {
                MessageBox.Show("Data rekam medis tidak ditemukan.");
            }

            // Menampilkan data obat ke ListBox1
            DataTable dtObat = rekam_medis.tampilkanDataObat();
            ListBox1.DataSource = dtObat;
            ListBox1.DisplayMember = "nama";
            ListBox1.ValueMember = "id_obat";
        }

        public class Obat
        {
            public string Nama { get; set; }
            public string ID { get; set; }

            public override string ToString()
            {
                return Nama; // Ini yang akan ditampilkan di ListBox2
            }
        }

        private void btnTambahObat_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedItem != null)
            {
                DataRowView selectedItem = (DataRowView)ListBox1.SelectedItem;
                string namaObat = selectedItem["nama"].ToString();
                string idObat = selectedItem["id_obat"].ToString();

                Obat obat = new Obat { Nama = namaObat, ID = idObat };
                ListBox2.Items.Add(obat);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrEmpty(tDiagnosa.Text))
            {
                MessageBox.Show("Diagnosa harus diisi.");
                return;
            }

            if (string.IsNullOrEmpty(tKeterangan.Text))
            {
                MessageBox.Show("Keterangan harus diisi.");
                return;
            }

            if (ListBox2.Items.Count == 0)
            {
                MessageBox.Show("Harus ada minimal satu obat yang ditambahkan.");
                return;
            }

            // Perbarui diagnosis
            string diagnosis = tDiagnosa.Text;
            bool isDiagnosisUpdated = rekam_medis.UpdateDiagnosis(ID, diagnosis);

            // Simpan resep obat
            List<string> obatList = new List<string>();
            foreach (Obat item in ListBox2.Items)
            {
                obatList.Add(item.ID);
            }

            string keterangan = tKeterangan.Text;
            bool isPrescriptionSaved = rekam_medis.SavePrescription(ID, obatList, keterangan);

            // Perbarui status rekam medis menjadi 'selesai'
            bool isStatusUpdated = rekam_medis.UpdateStatus(ID, "selesai");

            if (isDiagnosisUpdated && isPrescriptionSaved && isStatusUpdated)
            {
                MessageBox.Show("Data berhasil disimpan");
                this.Close();
            }
            else
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data. Silakan coba lagi.");
            }
        }
    }
}