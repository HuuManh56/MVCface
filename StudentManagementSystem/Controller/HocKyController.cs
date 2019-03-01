using StudentManagementSystem.Database;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using StudentManagementSystem.Model;

namespace StudentManagementSystem.Controller
{
    class HocKyController
    {
        ConnectDB cn = new ConnectDB();
        public DataTable GetALL()
        {   // hien thi toan bo du lieu bang học kỳ
            SqlConnection connection = cn.getConnect();
            string sql = "exec [dbo].[Select_HocKy]";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}

