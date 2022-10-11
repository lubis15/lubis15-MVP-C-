using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLITE_TEST
{
    internal class Connection
    {
        SQLiteConnection con;
        public SQLiteCommand cmd;
        SQLiteDataAdapter sqlDataAdapter;
        string conString = @"Data Source=data_table.db; providerName= System.Data.SqlClient";
        public Connection()
        {
            con = new SQLiteConnection(conString, true);
            con.Open();
        }

        public void Query(string query)
        {
            cmd = new SQLiteCommand(query, con);
            sqlDataAdapter = new SQLiteDataAdapter(cmd);
        }

        public DataTable ExecuteSelectQuery()
        {
            using (sqlDataAdapter)
            {
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                return dt;
            }
        }

        public void ExecuteNonSelectQuery()
        {
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
