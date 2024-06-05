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
    public partial class ListResep : Form
    {
        public string Id_Rekam { get; set; }
        Resep_Cls resep = new Resep_Cls();

        public ListResep()
        {
            InitializeComponent();
        }

        private void ListResep_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id_Rekam))
            {
                resep.Id_Rekam = Id_Rekam;
                DataTable data = resep.tampilkanResep();

                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    lpasien.Text = row["nama_pasien"].ToString();
                    tKeluhan.Text = row["keluhan"].ToString();
                    tDiagnosa.Text = row["diagnosa"].ToString();

                    // Clear existing items in the list box
                    listBoxResep.Items.Clear();

                    foreach (DataRow dataRow in data.Rows)
                    {
                        if (dataRow["resep_obat"] != DBNull.Value)
                        {
                            string resepObat = dataRow["resep_obat"].ToString();
                            if (!listBoxResep.Items.Contains(resepObat))
                            {
                                listBoxResep.Items.Add(resepObat);
                            }
                        }
                    }
                }
            }
        }
    }
}
