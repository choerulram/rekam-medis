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
    using System.Windows.Forms.VisualStyles;

    public partial class FormPendaftaran : Form
    {
        RekamMedis_Cls rekam_medis = new RekamMedis_Cls();

        public FormPendaftaran(string adminId)
        {
            InitializeComponent();
        }

        void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
            {
                pendaftaran_dgv.DataSource = rekam_medis.tampikanData();
            }
            else
            {
                DataTable hasilPencarian = rekam_medis.tampilkanDgNama(cari_txt.Text);
                if (hasilPencarian.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan atau kosong");
                }
                pendaftaran_dgv.DataSource = hasilPencarian;
            }
            belangBelang(pendaftaran_dgv);
        }

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

        private void FormPendaftaran_Load(object sender, EventArgs e)
        {
            // Menampilkan data terkait di DataGridView
            tampilGrid();

            tampilkanComboPasien();
            tampilkanComboDokter();
        }

        private void tampilkanComboPasien()
        {
            DataTable pasien = rekam_medis.getComboPasien();
            cbPasien1.DataSource = pasien;
            cbPasien1.DisplayMember = "nama";
            cbPasien1.ValueMember = "id_pasien";
            cbPasien1.SelectedIndex = -1;
        }

        private void tampilkanComboDokter()
        {
            DataTable dokter = rekam_medis.getComboDokter();
            cbDokter.DataSource = dokter;
            cbDokter.DisplayMember = "nama";
            cbDokter.ValueMember = "id_dokter";
            cbDokter.SelectedIndex = -1;
        }

        private void pendaftaran_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.pendaftaran_dgv.Rows[e.RowIndex];
                rekam_medis.Id_Rekam = baris.Cells[0].Value.ToString();
                cbPasien1.Text = baris.Cells[2].Value.ToString();
                cbDokter.Text = baris.Cells[7].Value.ToString();
                tKeluhan.Text = baris.Cells[3].Value.ToString();
                string dateValue = baris.Cells[4].Value.ToString().Trim();

                // Format yang digunakan di tabel termasuk waktu
                string dateFormat = "dd/MM/yyyy HH.mm.ss"; // Contoh: "28/03/2021 00.00.00"

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
                cbStatus.Text = baris.Cells[5].Value.ToString();
            }
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(rekam_medis.ambilKodeDgNama(nama_txt.Text));
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            rekam_medis.Id_Pasien = cbPasien1.SelectedValue.ToString();
            rekam_medis.Id_Dokter = cbDokter.SelectedValue.ToString();
            rekam_medis.Keluhan_RekamMedis = tKeluhan.Text;
            rekam_medis.Tanggal_RekamMedis = dtTanggal.Value.ToString("yyyy-MM-dd");
            rekam_medis.Status_RekamMedis = cbStatus.Text;

            if (rekam_medis.apakahAda())
            {
                MessageBox.Show("Data sudah ada, silakan gunakan tombol Perbarui.");
            }
            else
            {
                int result = rekam_medis.simpanData();
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

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            rekam_medis.Id_Pasien = cbPasien1.SelectedValue.ToString();
            rekam_medis.Id_Dokter = cbDokter.SelectedValue.ToString();
            rekam_medis.Keluhan_RekamMedis = tKeluhan.Text;
            rekam_medis.Tanggal_RekamMedis = dtTanggal.Value.ToString("yyyy-MM-dd");
            rekam_medis.Status_RekamMedis = cbStatus.Text;

            if (rekam_medis.apakahAda())
            {
                int result = rekam_medis.ubahData();
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
                    if (rekam_medis.hapusData(idRekam) > 0)
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
    }
}
