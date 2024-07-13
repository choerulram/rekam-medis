using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using siredis.konfigurasi;


namespace siredis.antarmuka
{
    using layanan;
    using System.Globalization;
    using siredis.antarmuka;
    using System.Windows.Forms.VisualStyles;

    public partial class FormPendaftaran : Form
    {
        Pendaftaran_Cls pendaftaran = new Pendaftaran_Cls();

        public FormPendaftaran(string adminId)
        {
            InitializeComponent();

            // Set DateTimePicker to current time
            dtTanggal.Value = DateTime.Now;

            // Disable DateTimePicker
            dtTanggal.Enabled = false;
        }

        // menampilkan data pada DataGridView
        void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
            {
                pendaftaran_dgv.DataSource = pendaftaran.tampikanData();
            }
            else
            {
                DataTable hasilPencarian = pendaftaran.tampilkanDgNama(cari_txt.Text);
                pendaftaran_dgv.DataSource = hasilPencarian;
            }
            belangBelang(pendaftaran_dgv);
        }

        // mengatur warna latar belakang baris ganjil dan genap pada DataGridView
        void belangBelang(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Index % 2 == 0)
                    {
                        cell.Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        // method yang dipanggil saat form dimuat
        private void FormPendaftaran_Load(object sender, EventArgs e)
        {
            // Menampilkan data terkait di DataGridView
            tampilGrid();

            tampilkanComboPasien();
            tampilkanComboDokter();
        }

        // mengisi combobox pasien dengan data dari database
        private void tampilkanComboPasien()
        {
            DataTable pasien = pendaftaran.getComboPasien();
            cbPasien1.DataSource = pasien;
            cbPasien1.DisplayMember = "nama";
            cbPasien1.ValueMember = "id_pasien";
            cbPasien1.SelectedIndex = -1;
        }

        // mengisi combobox dokter dengan data dari database
        private void tampilkanComboDokter()
        {
            DataTable dokter = pendaftaran.getComboDokter();
            cbDokter.DataSource = dokter;
            cbDokter.DisplayMember = "nama_spesialis";
            cbDokter.ValueMember = "id_dokter";
            cbDokter.SelectedIndex = -1;
        }

        // menangani klik pada sel DataGridView untuk mengisi form dengan data terkait
        private void pendaftaran_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow baris = this.pendaftaran_dgv.Rows[e.RowIndex];

                    // Pastikan nama kolom yang Anda akses benar dan sesuai dengan nama kolom di DataGridView
                    pendaftaran.Id_Rekam = baris.Cells["ID Rekam"].Value.ToString();
                    cbPasien1.Text = baris.Cells["Pasien"].Value.ToString();
                    cbDokter.Text = baris.Cells["Dokter"].Value.ToString();
                    tKeluhan.Text = baris.Cells["Keluhan"].Value.ToString();

                    string dateValue = baris.Cells["Tanggal"].Value.ToString().Trim();
                    string dateFormat = "dd/MM/yyyy HH.mm.ss";

                    // Parsing dateValue menggunakan format dari tabel
                    if (DateTime.TryParseExact(dateValue, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime tanggal))
                    {
                        // Set nilai ke DateTimePicker dalam format yang diinginkan
                        dtTanggal.Value = tanggal;
                    }
                    else
                    {
                        MessageBox.Show("Tanggal tidak valid. Format yang diharapkan: dd/MM/yyyy HH.mm.ss", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    cbStatus.Text = baris.Cells["Status"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // memfilter data saat teks pencarian diubah
        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        // menampilkan dialog konfirmasi untuk pencarian data
        private void btnCari_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(rekam_medis.ambilKodeDgNama(nama_txt.Text));
        }

        // menambahkan data baru ke database
        private void btnTambah_Click(object sender, EventArgs e)
        {
            pendaftaran.Id_Pasien = cbPasien1.SelectedValue.ToString();
            pendaftaran.Id_Dokter = cbDokter.SelectedValue.ToString();
            pendaftaran.Keluhan_RekamMedis = tKeluhan.Text;
            pendaftaran.Tanggal_RekamMedis = dtTanggal.Value.ToString("yyyy-MM-dd");
            pendaftaran.Status_RekamMedis = cbStatus.Text;

            if (pendaftaran.apakahAda())
            {
                MessageBox.Show("Data sudah ada, silakan gunakan tombol Perbarui.");
            }
            else
            {
                int result = pendaftaran.simpanData();
                if (result >= 0)
                {
                    MessageBox.Show("Data berhasil disimpan.");
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data.");
                }
            }

            tampilGrid();
        }

        // mengubah data yang sudah ada di database
        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            pendaftaran.Id_Pasien = cbPasien1.SelectedValue.ToString();
            pendaftaran.Id_Dokter = cbDokter.SelectedValue.ToString();
            pendaftaran.Keluhan_RekamMedis = tKeluhan.Text;
            pendaftaran.Tanggal_RekamMedis = dtTanggal.Value.ToString("yyyy-MM-dd");
            pendaftaran.Status_RekamMedis = cbStatus.Text;

            if (pendaftaran.apakahAda())
            {
                int result = pendaftaran.ubahData();
                if (result >= 0)
                {
                    MessageBox.Show("Data berhasil diubah.");
                }
                else
                {
                    MessageBox.Show("Gagal mengubah data.");
                }
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan, silakan gunakan tombol Tambah.");
            }

            tampilGrid();
        }

        // menghapus data yang dipilih dari database
        private void btnHapus_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Jumlah baris terpilih: {pendaftaran_dgv.SelectedRows.Count}"); // Debug

            if (pendaftaran_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = pendaftaran_dgv.SelectedRows[0];
                int idRekam = Convert.ToInt32(selectedRow.Cells["ID Rekam"].Value);

                Console.WriteLine($"ID Rekam yang dipilih: {idRekam}"); // Debug

                if (MessageBox.Show("Yakin data akan dihapus?", "KONFIRMASI",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (pendaftaran.hapusData(idRekam) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "INFORMASI",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris data yang ingin dihapus.");
            }
        }

        // menutup form saat link Homelb diklik
        private void Homelb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            kosongkanField();
        }

        void kosongkanField()
        {
            cbPasien1.SelectedIndex = -1;
            cbDokter.SelectedIndex = -1;
            tKeluhan.Clear();
            dtTanggal.Value = DateTime.Now;
            cbStatus.SelectedIndex = -1;
        }
    }
}
