using StudentManagementSystem.Database;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Controller
{
    class LopController
    {
        ConnectDB cn = new ConnectDB();
        public DataTable GetAll()
        {
            SqlConnection connect = cn.getConnect();
            String sql = "select * from Lop";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }

        public int Update(Lop lop)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "update Lop set CodeView=N'"+lop.CodeView+"'"
                +" set TenLop=N'"+lop.TenLop+"' where ID=" + lop.Id;
            SqlCommand cmd = new SqlCommand(sql, connect);
            try
            {
                cmd.ExecuteNonQuery();
                connect.Close();
                return 1;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        public int Insert(Lop lop)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "insert into Lop values ( N'" + lop.CodeView + "',N'" +lop.TenLop + "')";
            SqlCommand cmd = new SqlCommand(sql, connect);
            try
            {
                cmd.ExecuteNonQuery();
                connect.Close();
                return 1;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        public int Delete(String CodeView)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "delete Lop where CodeView=N'"+CodeView+"'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            try
            {
                cmd.ExecuteNonQuery();
                connect.Close();
                return 1;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return -1;
            }
        }
    }
}
