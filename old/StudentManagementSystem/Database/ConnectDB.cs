using StudentManagementSystem.Constant;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Database
{
    class ConnectDB
    {
        SqlConnection con;
        SqlCommand sqlcom;
        SqlDataReader sqldr;
        public ConnectDB()
        {
            SqlConnection con = new SqlConnection(DBConstant.DBstring );

        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(DBConstant.DBstring);
        }
        public DataTable getTable(string sql)
        {
            con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
