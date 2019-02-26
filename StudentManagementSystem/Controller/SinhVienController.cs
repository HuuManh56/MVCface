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
        public int Insert(SinhVien sinhvien, byte[] pic)
        {
            int ret=0;
            String sql = "insert into SinhVien values(@HoTen,@NgaySinh,@GioiTinh,@LopID,@image)";
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = connect.getConnect();
            cn.Open();
            cmd.CommandText = sql;
            cmd.Connection = cn;

            //ImageBox img = new ImageBox();
            //img.Image = sinhvien.Image;
            //MemoryStream stream = new MemoryStream();
            //int width = Convert.ToInt32(sinhvien.Image.Width);
            //int height = Convert.ToInt32(sinhvien.Image.Height);
            //Bitmap bmp = new Bitmap(width, height);
            //img.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));
            //bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            //byte[] pic = stream.ToArray();

            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = sinhvien.HoTen;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = sinhvien.NgaySinh;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Int).Value = sinhvien.GioiTinh;
            cmd.Parameters.Add("@LopID", SqlDbType.Int).Value = sinhvien.LopId;
            cmd.Parameters.Add("@image", SqlDbType.Image).Value = pic;

            ret = cmd.ExecuteNonQuery();
            return ret;
        }

    }
}
