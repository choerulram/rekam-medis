using siredis.layanan;
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
    public partial class HomeDokter : Form
    {
        private string userId;
        private string idDokter;

        public HomeDokter(string user, string idDokter)
        {
            InitializeComponent();
            user_lbl.Text = user;
            this.idDokter = idDokter;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void PemeriksaanMenu_Click(object sender, EventArgs e)
        {
            FormPemeriksaan formPemeriksaan = new FormPemeriksaan(idDokter);
            formPemeriksaan.ShowDialog();
        }

        private void SelesaiMenu_Click(object sender, EventArgs e)
        {
            FormSelesai transaksi = new FormSelesai(idDokter);
            transaksi.Show();
        }

        private void PendaftaranMenu_Click(object sender, EventArgs e)
        {
            FormPendaftaran formPendaftaran = new FormPendaftaran(userId);
            formPendaftaran.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
