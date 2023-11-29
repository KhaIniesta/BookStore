using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class DatabaseConnection
    {
        public static String ConnectString = "Data Source=.;Initial Catalog=QLNhaSach;User ID=sa;Password=1234";

        private SqlConnection conn;
        internal ConnectionState State;
        public DatabaseConnection()
        {
            conn = new SqlConnection(DatabaseConnection.ConnectString);
        }
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable GetTable(String sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }


        public SqlConnection GetConnection()
        {
            return conn;
        }

    }
}
}
