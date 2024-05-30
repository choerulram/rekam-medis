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

            // Mengatur sumber data combo box pasien
            cbPasien.DataSource = rekam_medis.getComboPasien();
            cbPasien.DisplayMember = "nama";

            // Mengatur sumber data combo box dokter
            cbDokter.DataSource = rekam_medis.getComboDokter();
            cbDokter.ValueMember = "nama";
        }

        private void pendaftaran_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.pendaftaran_dgv.Rows[e.RowIndex];
                //id_txt.Text = baris.Cells[0].Value.ToString();
                //nama_txt.Text = baris.Cells[1].Value.ToString();
                //jurusan_cmb.Text = baris.Cells[2].Value.ToString();
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
    }
}
