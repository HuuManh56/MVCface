using StudentManagementSystem.Controller;
using StudentManagementSystem.Database;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.View
{
    public partial class frmLop : Form
    {
        ChuanHoaController ChuanHoaController = new ChuanHoaController();
        LopController lopcontroller= new LopController();
        public frmLop()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtMaLopCN.Text = "";
            txtTenLop.Text = "";
        }
        //public int ChuanHoa(string str)
        //{
        //    if (str.Length <3)
        //    {
        //        MessageBox.Show("Chuoi nhap vao phai lon hon 3");
        //        txtMaLopCN.Text = "";
        //        return -1;
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}
        
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            try
            {
                string IDLop = txtMaLopCN.Text.ToUpper();
                string Ten = txtTenLop.Text;
                string IDNienKhoa = cmbChonKhoa.Tag.ToString();
                if (ChuanHoaController.ChuanHoa(IDLop,Ten)>0)
                {
                    Lop lop = new Lop(IDLop, Ten, IDNienKhoa);
                    // lopcontroller.Insert(lop);
                    int red = lopcontroller.Insert(lop);
                    if (red > 0)
                    {
                        MessageBox.Show(" Them thanh cong");
                        this.Close();
                    }
                }
                else
                {
                    Reset();
                }
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ShowChonKHoa()
        {
            ConnectDB connectDB = new ConnectDB();
            string sql = " select * from NienKhoa";
            DataTable dt = connectDB.getTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbChonKhoa.Items.Add(dt.Rows[i]["TenKhoa"].ToString());
            }
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            ShowChonKHoa();


        }

        private void cmbChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
            string sql = " select * from NienKhoa where TenKhoa=N'"+cmbChonKhoa.Text+"'";
            DataTable dt = connectDB.getTable(sql);
            cmbChonKhoa.Tag= dt.Rows[0][0].ToString();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();
        }
    }
}
