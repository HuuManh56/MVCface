using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sms.DAO;
using sms.Entities;

namespace sms.GUI
{
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(txtDiem1.Tag.ToString());
            decimal a = 0, b = 0, c = 0;
            a = Convert.ToDecimal(txtDiem1.Text);
            b = Convert.ToDecimal(txtDiem2.Text);
            c = Convert.ToDecimal(txtDiem3.Text);
            if ( (a<0 || a>10) || (b < 0 || b > 10) || (c < 0 || b > 10))
            {
                MessageBox.Show("Nhập điểm sai");
                return;
            }
            else
            {
                MyDBContext db = new MyDBContext();
                SinhVienLHPDAO svDao = new SinhVienLHPDAO();
                    int id1=svDao.GetID(id);// id1 la id trong bảng sv_lhp
                SV_LHP sV_LHP=  db.SV_LHP.Find(id1);
                sV_LHP.Diem1 = a;
                sV_LHP.Diem2 = b;
                sV_LHP.Diem3 = c;
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
