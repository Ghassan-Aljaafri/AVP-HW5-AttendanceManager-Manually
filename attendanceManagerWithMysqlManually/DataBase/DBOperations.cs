using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace attendanceManagerWithMysqlManually
{
    class DBOperations
    {
        public static string query = "";
        public static MySqlCommand cmd = default(MySqlCommand);

        public static DataTable Execute(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return dt;
        }
    }
}
