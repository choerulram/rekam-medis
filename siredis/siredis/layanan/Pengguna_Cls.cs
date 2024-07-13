using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace siredis.layanan
{
    using konfigurasi;

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

        // Metode untuk mendapatkan UserId
        public string GetUserId(string username)
        {
            string userId = "";
            Query = "SELECT id_user FROM tb_user WHERE username='" + username + "'";
            DataTable dt = server.eksekusiQuery(Query);
            if (dt.Rows.Count > 0)
            {
                userId = dt.Rows[0]["id_user"].ToString();
            }
            return userId;
        }

        // Metode untuk mendapatkan IdDokter
        public string GetIdDokter(string username)
        {
            string idDokter = "";
            Query = "SELECT id_dokter FROM tb_user WHERE username='" + username + "'";
            DataTable dt = server.eksekusiQuery(Query);
            if (dt.Rows.Count > 0)
            {
                idDokter = dt.Rows[0]["id_dokter"].ToString();
            }
            return idDokter;
        }
    }
}
