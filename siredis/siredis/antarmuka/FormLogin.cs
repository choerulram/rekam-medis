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
                string userId = user.GetUserId(username_txt.Text);
                string idAdmin = user.GetIdAdmin(username_txt.Text);
                string idDokter = user.GetIdDokter(username_txt.Text);

                string welcomeMessage = $"Selamat datang, {user.GetNamaAdmin(idAdmin)}!";
                string welcomeMessage2 = $"Selamat datang, {user.GetNamaDokter(idDokter)}!";
                string welcomeTitle = "LOGIN BERHASIL";

                switch (user.UserType)
                {
                    case "Admin":
                        MessageBox.Show($"{welcomeMessage}\nAnda berhasil masuk sebagai Admin.", welcomeTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomeAdmin dashboardAdmin = new HomeAdmin(username_txt.Text, idAdmin);
                        dashboardAdmin.Show();
                        break;
                    case "Dokter":
                        MessageBox.Show($"{welcomeMessage2}\nAnda berhasil masuk sebagai Dokter.", welcomeTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomeDokter dashboardDokter = new HomeDokter(username_txt.Text, idDokter);
                        dashboardDokter.Show();
                        break;
                    default:
                        MessageBox.Show("Tipe pengguna tidak dikenal.", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf username atau password Anda salah.", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username_txt.SelectAll();
                username_txt.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan menutup aplikasi?", "KONFIRMASI",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
