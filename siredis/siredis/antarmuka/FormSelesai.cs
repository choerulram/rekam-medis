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
    public partial class FormSelesai : Form
    {
        Selesai_Cls selesai = new Selesai_Cls();
        public FormSelesai()
        {
            InitializeComponent();
        }

        void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
            {
                selesai_dgv.DataSource = selesai.tampikanData();
            }
            else
            {
                DataTable hasilPencarian = selesai.tampilkanDgNama(cari_txt.Text);
                if (hasilPencarian.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan atau kosong");
                }
                selesai_dgv.DataSource = hasilPencarian;
            }
            belangBelang(selesai_dgv);
            selesai_dgv.ClearSelection();
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

        private void FormSelesai_Load(object sender, EventArgs e)
        {
            // Menampilkan data terkait di DataGridView
            tampilGrid();
        }

        private void Homelb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnResep_Click(object sender, EventArgs e)
        {
            if (selesai_dgv.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = selesai_dgv.SelectedCells[0];
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

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(rekam_medis.ambilKodeDgNama(nama_txt.Text));
        }

        private void selesai_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selesai_dgv.ClearSelection();
        }

        private void selesai_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.selesai_dgv.Rows[e.RowIndex];
                lpasien.Text = baris.Cells[2].Value.ToString();
                ldokter.Text = baris.Cells[7].Value.ToString();
                cbStatus.Text = baris.Cells[5].Value.ToString();
            }
        }
    }
}
