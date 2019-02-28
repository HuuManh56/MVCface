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
using StudentManagementSystem.View;

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

        //public int Update(Lop lop)
        //{
        //    SqlConnection connect = cn.getConnect();
        //    if(connect.State==ConnectionState.Closed)
        //     connect.Open();
        //    string sql = "update Lop set CodeView=N'"+lop.CodeView+"'"
        //        +" set TenLop=N'"+lop.TenLop+"' where ID=" + lop.Id;
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

        public int Insert(Lop lop)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "insert into Lop values (N'"+lop.IDLopCN+"',N'"+lop.TenLop+"',"+lop.IDNienKhoa+")";
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

        public int Delete(String TenLop)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "delete Lop where TenLop=N'"+TenLop+"'";
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
        
        public DataTable Truyvan(string TenNienKhoa)
        {
            SqlConnection connect = cn.getConnect();
            String sql = "select TenLop from Lop inner join NienKhoa"
                + " on lop.IDNienKhoa = NienKhoa.IDNienKhoa "
                + "where TenKhoa = N'" + TenNienKhoa + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }
    }
}
