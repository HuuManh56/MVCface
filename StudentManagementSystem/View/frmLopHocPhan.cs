using StudentManagementSystem.Controller;
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
    public partial class frmLopHocPhan : Form
    {
        LopHocPhanController LopHpcontroller = new LopHocPhanController();
        HocPhanController HocPhanController = new HocPhanController();
        HocKyController HocKyController = new HocKyController();
        public frmLopHocPhan()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            try
            {
                string IDLophocPhan = txtMaLopHP.Text;
                string IDHocPhan = cmbChonHocPhan.Tag.ToString();
                txtTenLopHP.Text = cmbChonHocPhan.Text + " " + IDLophocPhan;

                LopHocPhan lop = new LopHocPhan(IDLophocPhan, IDHocPhan, txtTenLopHP.Text);
                int red = LopHpcontroller.Insert(lop);
                if (red > 0)
                {
                    MessageBox.Show(" Them thanh cong");

                }
                else
                {
                    MessageBox.Show(" them khong thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" khong duoc bo trong thong tin");
              //  MessageBox.Show(ex.Message);
            }
           // this.Dispose();

        }
        public void showCmbHP(string IDHk)
        {
            DataTable dt = HocPhanController.HocPhanHK(IDHk);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbChonHocPhan.Items.Add(dt.Rows[i][1]);
            }
        }
        public void ShowTxtHkNam( string IDhk)
        {
            DataTable dt = HocKyController.GetHk(IDhk);

            string a = dt.Rows[0][1] +"/"+ dt.Rows[0][2];
            txtHkNam.Text = a;
        }
        private void frmLopHocPhan_Load(object sender, EventArgs e)
        {
            frmHocPhan frmHocPhan = new frmHocPhan();
            frmHocPhan.KiemTraNgay();
            txtMaLopHP.Tag = frmHocPhan.dtgvHocKy.Tag;//id hoc ky
            string idhk = txtMaLopHP.Tag.ToString();
            showCmbHP(idhk);// show ra cmb hoc phan theo id hoc ky
            ShowTxtHkNam(idhk);
        }

        private void cmbChonHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt= HocPhanController.NamHp(cmbChonHocPhan.Text);
            string id = dt.Rows[0][0] + "";
            cmbChonHocPhan.Tag = id;
        }

        private void txtMaLopHP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaLopHP.MaxLength < 2)
            {
                MessageBox.Show("nhap lai");
            }
            txtTenLopHP.Text = cmbChonHocPhan.Text + " " + txtMaLopHP.Text;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
