using Emgu.CV.UI;
using StudentManagementSystem.Database;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Controller
{
    class SinhVienController
    {
        ConnectDB connect = new ConnectDB();
        public DataTable getListCN(string IdLop)
        {
            string sql = "select * from SinhVien where IDLopCN='" + IdLop + "'";
            DataTable tb = connect.getTable(sql);
            return tb;
        }
        public DataTable getListHP(string IdLop)
        {
            string sql = "select * from SinhVien a join SinhVien_LopHocPhan b on(a.MSV=b.MSV) where IDMaLopHP='" + IdLop + "'";
            DataTable tb = connect.getTable(sql);
            return tb;
        }
        public int Insert(SinhVien sinhvien, byte[] pic)
        {
            int ret=0;
            String sql = "insert into SinhVien values(@MaSV,@HoTen,@NgaySinh,@GioiTinh,@image,@LopID)";
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = connect.getConnect();
            cn.Open();
            cmd.CommandText = sql;
            cmd.Connection = cn;
            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = sinhvien.Id;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = sinhvien.HoTen;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = sinhvien.NgaySinh;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Int).Value = sinhvien.GioiTinh;
            cmd.Parameters.Add("@LopID", SqlDbType.NVarChar).Value = sinhvien.LopId;
            cmd.Parameters.Add("@image", SqlDbType.Image).Value = pic;

            ret = cmd.ExecuteNonQuery();
            return ret;
        }

    }
}
