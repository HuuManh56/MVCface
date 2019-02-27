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
    public partial class frmLop : Form
    {
        LopController lopcontroller= new LopController();
        public frmLop()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.CodeView = txtCodeView.ToString();
            lop.TenLop = txtTenLop.Text;
            int red = lopcontroller.Insert(lop);
            try
            {
                if (red > 0)
                {
                    MessageBox.Show(" Them thanh cong");
                    this.Close();
                    
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            
        }
    }
}
