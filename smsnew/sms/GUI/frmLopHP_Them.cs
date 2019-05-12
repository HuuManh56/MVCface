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
using sms.DTO;
using sms.Entities;

namespace sms.GUI
{
    public partial class frmLopHP_Them : Form
    {
        public frmLopHP_Them()
        {
            InitializeComponent();
        }

        private void frmLopHP_Them_Load(object sender, EventArgs e)
        {
            LopHpDAO lopHpDAO = new LopHpDAO();
            var lst=lopHpDAO.GetHocPhan_Tens();
            foreach( Ten item in lst)
            {
                cmbChonHocPhan.Items.Add(item.TenHp);
            }
        }

        private void txtMaLopHP_TextChanged(object sender, EventArgs e)
        {
            txtTenLopHP.Text = cmbChonHocPhan.Text + "-" + txtMaLopHP.Text;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            LopHocPhan lopHocPhan = new LopHocPhan();
            LopHpDAO lopHpDAO = new LopHpDAO();
            HocKyDAO hocKyDAO = new HocKyDAO();
            lopHocPhan.TenLopHocPhan = txtTenLopHP.Text;
            lopHocPhan.IDView = txtMaLopHP.Text;
            lopHocPhan.HocKyID = hocKyDAO.GetIDHocKY(txtHocKy.Text, txtNamHK.Text);// id học kỳ
            lopHocPhan.HocPhanID = lopHpDAO.GetIDHocPhan(cmbChonHocPhan.Text);// id học phần

            
            int ret = lopHpDAO.Insert(lopHocPhan);
            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công");
                //frmHome frmHome = new frmHome();
                //frmHome.LoadLHP_HK();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
            //load lại dgv
            

        }
    }
}
