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
    public partial class HomePasien : Form
    {
        public HomePasien()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void PengambilanObatMenu_Click(object sender, EventArgs e)
        {
            FormResep transaksi = new FormResep();
            transaksi.Show();
        }

        private void PendaftaranMenu_Click(object sender, EventArgs e)
        {
            FormPendaftaran transaksi = new FormPendaftaran();
            transaksi.Show();
        }
    }
}
