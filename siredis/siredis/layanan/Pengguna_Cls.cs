using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siredis.layanan
{
    using konfigurasi;
    using MySql.Data.MySqlClient;
    using MySqlX.XDevAPI.Common;
    using System.Data;

    internal class Pengguna_Cls
    {
        KoneksiDB_Cls server;
        string Query;


        public Pengguna_Cls()
        {
            server = new KoneksiDB_Cls();
            Query = "";
        }

        public string UserType { get; private set; }

        public bool apakahAdaUser(string uid, string pwd)
        {
            bool cek = false;
            Query = "SELECT * FROM tb_user WHERE username='" + uid + "' and password='" + pwd + "'";
            DataTable dt = server.eksekusiQuery(Query);
            if (dt.Rows.Count > 0)
            {
                cek = true;
                UserType = dt.Rows[0]["level"].ToString();
            }
            return cek;
        }
    }
}
