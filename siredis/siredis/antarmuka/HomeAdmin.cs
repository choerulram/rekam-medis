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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void AdminMenu_Click(object sender, EventArgs e)
        {
            DataAdmin data = new DataAdmin();
            data.Show();
        }

        private void DokterMenu_Click(object sender, EventArgs e)
        {
            DataDokter data = new DataDokter();
            data.Show();
        }

        private void PasienMenu_Click(object sender, EventArgs e)
        {
            DataPasien data = new DataPasien();
            data.Show();
        }

        private void ObatMenu_Click(object sender, EventArgs e)
        {
            DataObat data = new DataObat();
            data.Show();
        }

        private void PendaftaranMenu_Click(object sender, EventArgs e)
        {
            FormPendaftaran transaksi = new FormPendaftaran();
            transaksi.Show();
        }

        private void PemeriksaanMenu_Click(object sender, EventArgs e)
        {
            FormPemeriksaan transaksi = new FormPemeriksaan();
            transaksi.Show();
        }

        private void PengambilanObatMenu_Click(object sender, EventArgs e)
        {
            FormResep transaksi = new FormResep();
            transaksi.Show();
        }

        private void SelesaiMenu_Click(object sender, EventArgs e)
        {
            FormSelesai transaksi = new FormSelesai();
            transaksi.Show();
        }
    }
}
