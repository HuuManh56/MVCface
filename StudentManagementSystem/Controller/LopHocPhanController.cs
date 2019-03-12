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
    class LopHocPhanController
    {
        ConnectDB cn = new ConnectDB();
        public DataTable GetAll()
        {
            SqlConnection connect = cn.getConnect();
            String sql = "select * from LopHocPhan";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }

        //public int Update(LopHocPhan lop)
        //{
        //    SqlConnection connect = cn.getConnect();
        //    connect.Open();
        //    string sql = "update LopHocPhan set CodeView=N'" + lop.CodeView + "'"
        //        + " set TenLopHocPhan=N'" + lop.TenLopHocPhan + "' where ID=" + lop.Id;
        //    SqlCommand cmd = new SqlCommand(sql, connect);
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        connect.Close();
        //        return 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show(ex.ToString());
        //        return -1;
        //    }
        //}

        public int Insert(LopHocPhan lop)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "exec [dbo].[Insert_LopHP] '" + lop.IDLopHP + "','" + lop.IDHocKyHP + "',N'"
                + lop.TenLopHocPhan + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
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
        public DataTable LopHP_HK(string IDHK)
        {
            // select hoc phan theo ma hoc ky duoc chon
            SqlConnection connection = cn.getConnect();
            string sql = "exec [dbo].[Select_LopHP_Hk]'" + IDHK + "'";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(dt);
            return dt;
        }
        public int Delete(string TenLop)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "exec [dbo].[delete_LopHP] N'" + TenLop + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            try
            {
                cmd.ExecuteNonQuery();
                connect.Close();
                return 1;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Tostring());
                return -1;
            }
        }
    }
}
