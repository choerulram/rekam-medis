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
    public partial class DataDokter : Form
    {
        DataDokter_Cls data_dokter = new DataDokter_Cls();
        public DataDokter()
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
                dokter_dgv.DataSource = data_dokter.tampikanData();
            }
            else
            {
                DataTable hasilPencarian = data_dokter.tampilkanDgNama(cari_txt.Text);
                if (hasilPencarian.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan atau kosong");
                }
                dokter_dgv.DataSource = hasilPencarian;
            }
            belangBelang(dokter_dgv);
            dokter_dgv.ClearSelection();
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

        private void dokter_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.dokter_dgv.Rows[e.RowIndex];
                tNama.Text = baris.Cells[1].Value.ToString();
                cbGender.Text = baris.Cells[2].Value.ToString();
                tSpesialis.Text = baris.Cells[3].Value.ToString();
                tUsername.Text = baris.Cells[4].Value.ToString();
                tPassword.Text = baris.Cells[5].Value.ToString();
            }
        }

        private void dokter_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dokter_dgv.ClearSelection();
        }

        private void DataDokter_Load(object sender, EventArgs e)
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
            data_dokter.Nama = tNama.Text;
            data_dokter.Jenis_Kelamin = cbGender.Text;
            data_dokter.Spesialis = tSpesialis.Text;
            data_dokter.Username = tUsername.Text;
            data_dokter.Password = tPassword.Text;

            if (data_dokter.apakahAda())
            {
                MessageBox.Show("Data sudah ada, silakan gunakan tombol Perbarui.");
            }
            else
            {
                int result = data_dokter.simpanData();
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
    }
}
