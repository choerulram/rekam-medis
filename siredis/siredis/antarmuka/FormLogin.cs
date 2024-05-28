using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using siredis.layanan;

namespace siredis.antarmuka
{

    public partial class FormLogin : Form
    {
        Pengguna_Cls user = new Pengguna_Cls();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.apakahAdaUser(username_txt.Text, password_txt.Text))
            {
                switch (user.UserType)
                {
                    case "Admin":
                        HomeAdmin dashboardAdmin = new HomeAdmin();
                        dashboardAdmin.Show();
                        break;
                    case "Dokter":
                        HomeDokter dashboardDokter = new HomeDokter();
                        dashboardDokter.Show();
                        break;
                    case "Pasien":
                        HomePasien dashboardPasien = new HomePasien();
                        dashboardPasien.Show();
                        break;
                    default:
                        MessageBox.Show("Tipe pengguna tidak dikenal.", "KESALAHAN",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf username atau password Anda salah.", "KESALAHAN",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                username_txt.SelectAll();
                username_txt.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan keluar dari aplikasi?", "KONFIRMASI",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
