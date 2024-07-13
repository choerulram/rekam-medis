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
    public partial class HomeAdmin : Form
    {
        private string userId;
        private string idAdmin;
        private Pengguna_Cls user;
        public HomeAdmin(string user, string idAdmin)
        {
            InitializeComponent();
            this.userId = user;
            this.idAdmin = idAdmin;
            this.user = new Pengguna_Cls();

            string namaDokter = this.user.GetNamaAdmin(idAdmin);
            user_lbl.Text = $"{namaDokter}!";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
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
            FormPendaftaran formPendaftaran = new FormPendaftaran(userId);
            formPendaftaran.Show();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void user_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
