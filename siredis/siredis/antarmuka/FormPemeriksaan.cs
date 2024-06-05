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
    using layanan;
    using System.Globalization;
    using siredis.antarmuka;
    using System.Windows.Forms.VisualStyles;
    public partial class FormPemeriksaan : Form
    {
        Pemeriksaan_Cls rekam_medis = new Pemeriksaan_Cls();
        public FormPemeriksaan()
        {
            InitializeComponent();
        }

        void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
            {
                pemeriksaan_dgv.DataSource = rekam_medis.tampikanData();
            }
            else
            {
                DataTable hasilPencarian = rekam_medis.tampilkanDgNama(cari_txt.Text);
                if (hasilPencarian.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan atau kosong");
                }
                pemeriksaan_dgv.DataSource = hasilPencarian;
            }
            belangBelang(pemeriksaan_dgv);
            pemeriksaan_dgv.ClearSelection();
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

        private void FormPemeriksaan_Load(object sender, EventArgs e)
        {
            // Menampilkan data terkait di DataGridView
            tampilGrid();
        }

        private void Homelb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(rekam_medis.ambilKodeDgNama(nama_txt.Text));
        }

        private void pemeriksaan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.pemeriksaan_dgv.Rows[e.RowIndex];
                lpasien.Text = baris.Cells[2].Value.ToString();
                ldokter.Text = baris.Cells[7].Value.ToString();
                cbStatus.Text = baris.Cells[5].Value.ToString();
            }
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (pemeriksaan_dgv.SelectedCells.Count > 0)
            {
                // Ambil sel yang dipilih
                DataGridViewCell selectedCell = pemeriksaan_dgv.SelectedCells[0];
                // Dapatkan baris yang terkait dengan sel yang dipilih
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                // Ambil ID Rekam dari baris yang dipilih
                if (selectedRow.Cells["ID Rekam"] != null && selectedRow.Cells["ID Rekam"].Value != null)
                {
                    string idRekam = selectedRow.Cells["ID Rekam"].Value.ToString();
                    string status = cbStatus.SelectedItem?.ToString();

                    if (!string.IsNullOrEmpty(status))
                    {
                        // Ubah status rekam medis
                        int result = rekam_medis.ubahData(idRekam, status);
                        if (result >= 0)
                        {
                            MessageBox.Show("Status rekam medis berhasil diubah.");
                            tampilGrid();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah status rekam medis.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silakan pilih status untuk rekam medis yang akan diubah.");
                    }
                }
                else
                {
                    MessageBox.Show("Kolom ID Rekam tidak ditemukan atau nilainya kosong.");
                }
            }
            else
            {
                MessageBox.Show("Pilih sel dalam baris data rekam medis terlebih dahulu.");
            }
        }

        private void btnPeriksa_Click(object sender, EventArgs e)
        {
            if (pemeriksaan_dgv.SelectedCells.Count > 0)
            {
                // Ambil sel yang dipilih
                DataGridViewCell selectedCell = pemeriksaan_dgv.SelectedCells[0];
                // Dapatkan baris yang terkait dengan sel yang dipilih
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (selectedRow.Cells["ID Rekam"] != null && selectedRow.Cells["ID Rekam"].Value != null)
                {
                    string id_rekam = selectedRow.Cells["ID Rekam"].Value.ToString();

                    FormPemeriksaanDokter obj = new FormPemeriksaanDokter();
                    obj.ID = id_rekam;
                    obj.ShowDialog();

                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Kolom ID Rekam tidak ditemukan atau nilainya kosong.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Pilih sel dalam baris data rekam medis terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pemeriksaan_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pemeriksaan_dgv.ClearSelection();
        }

        private void btnResep_Click(object sender, EventArgs e)
        {
            if (pemeriksaan_dgv.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = pemeriksaan_dgv.SelectedCells[0];
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (selectedRow.Cells["ID Rekam"] != null && selectedRow.Cells["ID Rekam"].Value != null)
                {
                    string id_rekam = selectedRow.Cells["ID Rekam"].Value.ToString();

                    ListResep listResepForm = new ListResep();
                    listResepForm.Id_Rekam = id_rekam;
                    listResepForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kolom ID Rekam tidak ditemukan atau nilainya kosong.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Pilih sel dalam baris data rekam medis terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh data pada DataGridView
            tampilGrid();

            // Tampilkan pesan bahwa berhasil refresh
            MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
