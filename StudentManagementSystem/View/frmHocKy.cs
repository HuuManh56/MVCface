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
    public partial class frmHocKy : Form
    {
        HocKyController controller = new HocKyController();
        public frmHocKy()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //HocKy hocky = new HocKy();
            //hocky.TenHocKy = txtTenHocKy.Text;
            //String[] a = txtNamHoc.Text.Split('-');
            //hocky.NamBatDau = Convert.ToInt16(a[0]);
            //hocky.NamKetThuc = Convert.ToInt16(a[1]);
            //int ret = controller.Insert(hocky);
            //if(ret>0)
            //{
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show( "Nhập lại", "Thông báo");
            //}
        }
    }
}
