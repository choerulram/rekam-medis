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
    public partial class FormPendaftaran : Form
    {

        public FormPendaftaran(string adminId)
        {
            InitializeComponent();
        }
    }
}
