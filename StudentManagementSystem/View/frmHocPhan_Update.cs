using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Model;
using StudentManagementSystem.Controller;

namespace StudentManagementSystem.View
{
    public partial class frmHocPhan_Update : Form
    {
        public frmHocPhan_Update()
        {
            InitializeComponent();
        }
        
        private void frmHocPhan_Update_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHocPhan frm = new frmHocPhan();
            string a = txtIDHp.Text;
            string b = txtTenHP1.Text;
            int c =Convert.ToInt16( txtSoTC1.Text);
            string d =txtHocKy.Tag.ToString(); // lay id hoc ky
            HocPhan hocPhan = new HocPhan(a, b, c, d);
            HocPhanController hoc = new HocPhanController();
            int red = hoc.Update(hocPhan);
            try
            {
                if (red > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua khong thanh cong");
                }

            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
