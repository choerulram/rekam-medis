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
        Pemeriksaan_Cls pemeriksaan = new Pemeriksaan_Cls();
        string idDokter;

        public FormPemeriksaan(string idDokter)
        {
            InitializeComponent();
            this.idDokter = idDokter;
        }

        void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
            {
                pemeriksaan_dgv.DataSource = pemeriksaan.tampikanData(idDokter);
            }
            else
            {
                DataTable hasilPencarian = pemeriksaan.tampilkanDgNama(cari_txt.Text, idDokter);
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
        }

        private void pemeriksaan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.pemeriksaan_dgv.Rows[e.RowIndex];
                lpasien.Text = baris.Cells[2].Value.ToString();
                ldokter.Text = baris.Cells[6].Value.ToString();
                lstatus.Text = baris.Cells[5].Value.ToString();
            }
        }

        private void btnPeriksa_Click(object sender, EventArgs e)
        {
            if (pemeriksaan_dgv.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = pemeriksaan_dgv.SelectedCells[0];
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tampilGrid();
            MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
