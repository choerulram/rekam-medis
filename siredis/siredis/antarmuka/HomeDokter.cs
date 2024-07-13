using siredis.layanan;
using System;
using System.Windows.Forms;

namespace siredis.antarmuka
{
    public partial class HomeDokter : Form
    {
        private string userId;
        private string idDokter;
        private Pengguna_Cls user;

        public HomeDokter(string user, string idDokter)
        {
            InitializeComponent();
            this.userId = user;
            this.idDokter = idDokter;
            this.user = new Pengguna_Cls(); 

            // Tampilkan nama dokter di user_lbl
            string namaDokter = this.user.GetNamaDokter(idDokter);
            user_lbl.Text = $"{namaDokter}!";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan keluar dari aplikasi?", "KONFIRMASI",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Close();
            }
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
    }
}
