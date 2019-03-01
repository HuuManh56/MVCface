using StudentManagementSystem.Database;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementSystem.Controller
{
    class HocPhanController
    {
        ConnectDB cn = new ConnectDB();
        public DataTable GetAll()
        {
            SqlConnection connection = cn.getConnect();
            string sql = "exec [dbo].[HocPhanFull]";
         //   string sql = " select * from HocPhan";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql,connection);
            da.Fill(dt);
            return dt;
        }
        public DataTable HocPhanHK(string IDHocKy)
        {
            SqlConnection connection = cn.getConnect();
            string sql = "exec [dbo].[select_HP_Hk] "+IDHocKy;
            //   string sql = " select * from HocPhan";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(dt);
            return dt;
        }
        public int Insert ( HocPhan hocPhan)
        {
            SqlConnection connect = cn.getConnect();
            string sql = " exec [dbo].[Insert_HocPhan] "
                + hocPhan.IDHocPhan + ",N'" + hocPhan.TenHocPhan + "'," 
                + hocPhan.SoTC +","+ hocPhan.IDHocKy;

            SqlCommand cmd = new SqlCommand(sql, connect);
            connect.Open();
            try
            {
                cmd.ExecuteNonQuery();
                connect.Close();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        public void Delete()
        {

        }
        public int Update()
        {
            return 1;
        }
    }
}
