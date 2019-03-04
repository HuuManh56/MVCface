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
        
        LopController lopcontroller= new LopController();
        public frmLop()
        {
            InitializeComponent();
        }
        public string ChuanHoa(string str)
        {
            if (str.Length <3)
            {
                DialogResult result= MessageBox.Show(" chuoi dua va phai co do dai lon hon 3","Thong bao",MessageBoxButtons.OK);
                if( result== DialogResult.OK)
                {

                }
                
            }
            return str;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           
            string IDLop = txtMaLopCN.Text.ToUpper();
            ChuanHoa(IDLop);
            string Ten = txtTenLop.Text;
            string IDNienKhoa = cmbChonKhoa.Tag.ToString();
            Lop lop = new Lop(IDLop,Ten,IDNienKhoa);
           // lopcontroller.Insert(lop);
            int red = lopcontroller.Insert(lop);
            try
            {
                if (red > 0)
                {
                    MessageBox.Show(" Them thanh cong");
                    this.Close();


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
    }
}
