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

        private void btnTambah_Click(object sender, EventArgs e)
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
    }
}
