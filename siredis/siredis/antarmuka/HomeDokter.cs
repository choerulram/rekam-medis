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
        public HomeDokter()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
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
