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
                lpasien.Text = row["id_pasien"].ToString();
                tKeluhan.Text = row["keluhan"].ToString();
            }

            // Menampilkan data obat ke ListBox1
            DataTable dtObat = rekam_medis.tampilkanDataObat();
            ListBox1.DataSource = dtObat;
            ListBox1.DisplayMember = "nama";
            ListBox1.ValueMember = "id_obat";
        }

        private void btnTambahObat_Click(object sender, EventArgs e)
        {

        }
    }
}
