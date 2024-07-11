using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using siredis.layanan;



namespace siredis.antarmuka
{
    public partial class DataPasien : Form
    {
        private DataPasien_Cls data_pasien;
        public DataPasien()
        {
            InitializeComponent();
            data_pasien = new DataPasien_Cls();
        }

        private void DataPasien_Load(object sender, EventArgs e)
        {
            tampilGrid(); // Panggil method untuk menampilkan data
        }
        //tampilan home
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        // Metode untuk menampilkan data di DataGridView
        void tampilGrid()
        {
            if (tCari.Text.Length == 0)
            {
                pasien_dgv.DataSource = data_pasien.tampilkanDataPasien();
            }
            else
            {
                DataTable hasilPencarian = data_pasien.tampilkanDataPasienDgNama(tCari.Text);
                pasien_dgv.DataSource = hasilPencarian;
            }
            belangBelang(pasien_dgv);
            pasien_dgv.ClearSelection();
        }

        // Metode untuk menerapkan warna selang-seling pada baris di DataGridView
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

        // Event handler untuk perubahan teks di kotak pencarian
        private void tCari_TextChanged(object sender, EventArgs e)
        {
            // Panggil fungsi tampilGrid() untuk menampilkan data yang sesuai dengan teks pencarian
            tampilGrid();
        }

        //tampilan tambah
        private void btnTambah_Click(object sender, EventArgs e)
        {

            if (!IsInputValid())
            {
                return;
            }

            data_pasien.Id_Pasien = tId.Text;
            data_pasien.Nama = tNama.Text;
            data_pasien.No_Kartu = tNokartu.Text;
            data_pasien.Jenis_Kelamin = cbGender.Text;
            data_pasien.Umur = tUmur.Text;

            // Cek apakah data sudah ada
            if (data_pasien.apakahAda())
            {
                MessageBox.Show("Data sudah ada, silakan gunakan tombol Edit.");
            }
            else
            {
                // Simpan data
                int result = data_pasien.simpanData();
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
        }

        // Fungsi untuk membersihkan input setelah data disimpan
        private void ClearInput()
        {
            tNama.Text = "";
            tNokartu.Text = "";
            cbGender.SelectedIndex = -1;
            tUmur.Text = "";
        }

        //tampilan edit
        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            // Pastikan ID Pasien telah diatur
            if (!IsInputValid() || string.IsNullOrEmpty(data_pasien.Id_Pasien))
            {
                MessageBox.Show("Pilih data pasien yang ingin diubah.");
                return;
            }

            data_pasien.Id_Pasien = tId.Text;
            data_pasien.Nama = tNama.Text;
            data_pasien.No_Kartu = tNokartu.Text;
            data_pasien.Jenis_Kelamin = cbGender.Text;
            data_pasien.Umur = tUmur.Text;

            // Memanggil metode untuk mengupdate data pasien di database
            int result = data_pasien.updateData();
            if (result >= 0) // Mengasumsikan hasil yang lebih besar dari 0 menandakan keberhasilan
            {
                MessageBox.Show("Data berhasil diubah.");
            }
            else
            {
                MessageBox.Show("Gagal mengubah data.");
            }

            // Perbarui DataGridView dengan data terbaru
            tampilGrid();
        }

        //tampilan hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {

            if (pasien_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = pasien_dgv.SelectedRows[0];
                int idPasien = Convert.ToInt32(selectedRow.Cells[0].Value);

                if (MessageBox.Show("Yakin data akan dihapus?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (data_pasien.hapusData(idPasien) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private bool IsInputValid()
        {
            if (string.IsNullOrEmpty(tNama.Text) || string.IsNullOrEmpty(tNokartu.Text) || string.IsNullOrEmpty(cbGender.Text) || string.IsNullOrEmpty(tUmur.Text))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(tUmur.Text, out _))
            {
                MessageBox.Show("Umur harus diisi dengan angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Metode untuk menampilkan data pasien 
        private void pasien_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pasien_dgv.ClearSelection();
        }

        private void pasien_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.pasien_dgv.Rows[e.RowIndex];

            // Set nilai properti pada objek data_pasien sesuai dengan nilai sel pada baris yang diklik
            data_pasien.Id_Pasien = baris.Cells[0].Value.ToString();
            tNama.Text = baris.Cells[2].Value.ToString();
            tNokartu.Text = baris.Cells[1].Value.ToString();
            cbGender.Text = baris.Cells[3].Value.ToString();
            tUmur.Text = baris.Cells[4].Value.ToString();

            // Tampilkan Id_Pasien di kontrol yang sesuai di form, misalnya TextBox atau Label
            tId.Text = data_pasien.Id_Pasien;
        }
    }
}

