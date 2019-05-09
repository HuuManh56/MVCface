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
            string sql = "exec [dbo].[select_Lop]";
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
        //        //MessageBox.Show(ex.Tostring());
        //        return -1;
        //    }
        //}

        public int Insert(Lop lop)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "exec [dbo].[insert_Lop] '"
                + lop.IDLopCN + "',N'" + lop.TenLop + "','" + lop.IDNienKhoa + "'";
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

        public int Delete(string TenLop)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "exec [dbo].[delete_Lop] N'" + TenLop+"'";
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
        
        public DataTable Truyvan(string TenNienKhoa)
        {
            SqlConnection connect = cn.getConnect();
            string sql = "select TenLop from Lop inner join NienKhoa"
                + " on lop.IDNienKhoa = NienKhoa.IDNienKhoa "
                + "where TenKhoa = N'" + TenNienKhoa + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }

        public string getIdByName(string name)
        {
            string ID = "";
            string sql = "select IDLopCN from Lop where TenLop=N'" + name + "'";
            DataTable tb = cn.getTable(sql);
            if(tb.Rows.Count>0)
            {
                ID = tb.Rows[0][0].ToString();
            }
            return ID;
        }
        public Lop getByName(string name)
        {
            Lop lop = new Lop();

            SqlConnection connect = cn.getConnect();
            string sql = "select * from Lop where TenLop=N'" + name + "'";

            DataTable dt = cn.getTable(sql);
           
            if (dt.Rows.Count > 0)
            {
                lop.IDLopCN = dt.Rows[0][0].ToString();
                lop.TenLop = dt.Rows[0][1].ToString();
                lop.IDNienKhoa = dt.Rows[0]["IDNienKhoa"].ToString();
            }
            return lop;
        }

    }
}
