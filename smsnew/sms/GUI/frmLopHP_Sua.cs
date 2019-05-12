using sms.DAO;
using sms.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sms.Entities;
namespace sms.GUI
{
    public partial class frmLopHP_Sua : Form
    {
        public frmLopHP_Sua()
        {
            InitializeComponent();
        }

        private void frmLopHP_Sua_Load(object sender, EventArgs e)
        {
            LopHpDAO lopHpDAO = new LopHpDAO();
            var lst = lopHpDAO.GetHocPhan_Tens();
            foreach (Ten item in lst)
            {
                cmbHP.Items.Add(item.TenHp);
            }
            
            cmbHP.Tag = cmbHP.Text;
        }

        private void txtMaLopHP_TextChanged(object sender, EventArgs e)
        {
            txtTenLopHP.Text = cmbHP.Text + "-" + txtMaLopHP.Text;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            LopHpDAO lopHpDAO = new LopHpDAO();
            LopHocPhan lopHocPhan = new LopHocPhan();
            
            int idHPmoi = lopHpDAO.GetIDHocPhan(cmbHP.Text);// id học phần mới
            lopHocPhan.ID = lopHpDAO.IDLopHP(txtTenLopHP.Tag.ToString());
            if (lopHocPhan.ID != 0)
            {
                lopHocPhan.HocPhanID = idHPmoi;
                lopHocPhan.IDView = txtMaLopHP.Text;
                lopHocPhan.TenLopHocPhan = txtTenLopHP.Text;
                int ret = lopHpDAO.Update(lopHocPhan);
                if (ret > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    //frmHome frmHome = new frmHome();
                    //frmHome.LoadLHP_HK();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }


            }
            else
            {
                MessageBox.Show("Ban chua chon nam hoc can sua");

            }
        }
    }
}
