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

    public partial class DataObat : Form
    {
        DataObat_Cls data_obat = new DataObat_Cls();
        public DataObat()
        {
            InitializeComponent();
        }

        private void Homelb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
            {
                obat_dgv.DataSource = data_obat.tampikanData();
            }
            else
            {
                DataTable hasilPencarian = data_obat.tampilkanDgNama(cari_txt.Text);
                obat_dgv.DataSource = hasilPencarian;
            }
            belangBelang(obat_dgv);
            obat_dgv.ClearSelection();
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

        private void obat_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.obat_dgv.Rows[e.RowIndex];
                tIdObat.Text = baris.Cells[0].Value.ToString();
                tNama.Text = baris.Cells[1].Value.ToString();
                data_obat.Id_Obat = tIdObat.Text;
            }
        }

        private void obat_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obat_dgv.ClearSelection();
        }

        private void DataObat_Load(object sender, EventArgs e)
        {
            // Menampilkan data terkait di DataGridView
            tampilGrid();
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
            if (!IsInputValid())
            {
                return;
            }

            data_obat.Id_Obat = tIdObat.Text;
            data_obat.Nama = tNama.Text;

            if (data_obat.apakahAda())
            {
                MessageBox.Show("Data sudah ada, silakan gunakan tombol Edit.");
            }
            else
            {
                // Simpan data
                int result = data_obat.simpanData();
                if (result >= 0)
                {
                    MessageBox.Show("Data berhasil disimpan.");
                    tampilGrid(); // Tampilkan data terbaru di DataGridView
                    ClearInput(); // Bersihkan input setelah menyimpan data
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data.");
                }
            }

            tampilGrid();
        }

        private void ClearInput()
        {
            tIdObat.Text = "";
            tNama.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Pastikan ID Obat telah diatur
            if (!IsInputValid() || string.IsNullOrEmpty(data_obat.Id_Obat))
            {
                MessageBox.Show("Pilih data pasien yang ingin diubah.");
                return;
            }

            data_obat.Id_Obat = tIdObat.Text;
            data_obat.Nama = tNama.Text;

            int result = data_obat.ubahData();
            if (result >= 0)
            {
                MessageBox.Show("Data berhasil diubah.");
            }
            else
            {
                MessageBox.Show("Gagal mengubah data.");
            }

            tampilGrid();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tIdObat.Text))
            {
                MessageBox.Show("Pilih data obat yang ingin dihapus.");
                return;
            }

            int idObat = Convert.ToInt32(tIdObat.Text);
            if (MessageBox.Show("Yakin data akan dihapus?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = data_obat.hapusData(idObat);
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil dihapus.");
                    tampilGrid();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.");
                }
            }
        }
        private bool IsInputValid()
        {
            if (string.IsNullOrEmpty(tIdObat.Text) || string.IsNullOrEmpty(tNama.Text))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
