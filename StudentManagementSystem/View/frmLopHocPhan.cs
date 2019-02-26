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
        LopController controller= new LopController();
        public frmLopHocPhan()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.CodeView = txtMaLop.Text.ToUpper();
            lop.TenLop = txtTenLop.Text;
            int ret = controller.Insert(lop);
            if (ret > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập lại", "Thông báo");
            }
        }
    }
}
