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

            // Periksa di tabel tb_admin
            Query = "SELECT 'Admin' as UserType FROM tb_admin WHERE username=@uid AND password=@pwd";
            DataTable result = server.eksekusiQuery(Query, new MySqlParameter("@uid", uid), new MySqlParameter("@pwd", pwd));

            if (result.Rows.Count > 0)
            {
                cek = true;
                UserType = result.Rows[0]["UserType"].ToString();
                return cek;
            }

            // Periksa di tabel tb_dokter
            Query = "SELECT 'Dokter' as UserType FROM tb_dokter WHERE username=@uid AND password=@pwd";
            result = server.eksekusiQuery(Query, new MySqlParameter("@uid", uid), new MySqlParameter("@pwd", pwd));

            if (result.Rows.Count > 0)
            {
                cek = true;
                UserType = result.Rows[0]["UserType"].ToString();
                return cek;
            }

            return cek;
        }
    }
}
