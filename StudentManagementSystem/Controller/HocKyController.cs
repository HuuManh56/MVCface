using StudentManagementSystem.Database;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Controller
{
    class HocKyController
    {
        ConnectDB cn = new ConnectDB();
        public void Update()
        {

        }

        public int Insert(HocKy _hocky)
        {
            SqlConnection connect = cn.getConnect();
            connect.Open();
            string sql = "insert into HocKy values ( N'" + _hocky.TenHocKy + "',"+_hocky.NamBatDau+","+_hocky.NamKetThuc+")";
            SqlCommand cmd = new SqlCommand(sql, connect);
            try
            {
                cmd.ExecuteNonQuery();
                connect.Close();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        public void Delete()
        {

        }
    }
}
