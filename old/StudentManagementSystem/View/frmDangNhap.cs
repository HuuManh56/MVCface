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
    public partial class frmDangNhap : Form
    {
        UserController userController = new UserController();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = this.txtUsername.Text;
            user.Password = this.txtPassword.Text;
            int ret = userController.Login(user);
            if (ret == 1)
            {
                //Dang nhap thanh cong
                this.Hide();
                frmHome frm = new frmHome();
                frm.Show();
               
            }
            else
            {
                MessageBox.Show("Username hoặc Password không chính xác.", "Thông báo");

            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
