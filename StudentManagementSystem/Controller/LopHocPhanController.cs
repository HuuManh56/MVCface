using StudentManagementSystem.Database;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Update(LopHocPhan lop)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "update LopHocPhan set CodeView=N'" + lop.CodeView + "'"
                + " set TenLopHocPhan=N'" + lop.TenLopHocPhan + "' where ID=" + lop.Id;
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

        //public int Insert(Lop lop)
        //{
        //    SqlConnection connect = cn.getConnect();
        //    connect.Open();
        //    string sql = "insert into LopHocPhan values ( N'" + lop.CodeView + "',N'" + lop.TenLop + "')";
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

        public int Delete(String TenLopHocPhan)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "delete LopHocPhan where  TenLopHocPhan=N'" + TenLopHocPhan + "'";
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
