using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siredis
{
    abstract class Konfigurasi_Cls
    {
        //Untuk menangani instruksi INSERT, UPDATE, DELETE
        public abstract int eksekusiBukanQuery(string query, params MySqlParameter[] parameters);

        //Untuk menangani instruksi SELECT
        public abstract DataTable eksekusiQuery(string query, params MySqlParameter[] parameters);
    }
}
