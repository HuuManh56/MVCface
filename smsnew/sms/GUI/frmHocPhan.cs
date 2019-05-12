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
    public partial class frmHocPhan : Form
    {
        public frmHocPhan()
        {
            InitializeComponent();
        }

        private void frmHocPhan_Load(object sender, EventArgs e)
        {
            TxtTenHP.Text = "";
            cmbTinChi.Text = "";
            HocPhanDAO hocPhanDAO = new HocPhanDAO();
            dgvHocPHan.DataSource= hocPhanDAO.GetALL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtTenHP.Text=="" || cmbTinChi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            }
            else
            {
                HocPhanDAO hocPhanDAO = new HocPhanDAO();
                HocPhan hocPhan = new HocPhan();
                hocPhan.TenHocPhan = TxtTenHP.Text;
                hocPhan.SoDVHT = Convert.ToInt16(cmbTinChi.Text);
                int ret = hocPhanDAO.Insert(hocPhan);
                if (ret > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    frmHocPhan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            
        }

        private void dgvHocPHan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            TxtTenHP.Tag = dgvHocPHan.Rows[row].Cells[0].Value + "";
            TxtTenHP.Text = dgvHocPHan.Rows[row].Cells[1].Value + "";
            cmbTinChi.Text= dgvHocPHan.Rows[row].Cells[2].Value + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocPhan hocPhan = new HocPhan();
            HocPhanDAO hocPhanDAO = new HocPhanDAO();
            hocPhan.ID = Convert.ToInt16(TxtTenHP.Tag);
            if (hocPhan.ID != 0)
            {
                hocPhan.TenHocPhan = TxtTenHP.Text;
                hocPhan.SoDVHT =Convert.ToInt16( cmbTinChi.Text);
                int ret = hocPhanDAO.Update(hocPhan);
                if (ret > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    frmHocPhan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }


            }
            else
            {
                MessageBox.Show("Ban chua chon nam hoc can sua");
                frmHocPhan_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocPhan hocPhan = new HocPhan();
            HocPhanDAO hocPhanDAO = new HocPhanDAO();
            hocPhan.ID = Convert.ToInt16(TxtTenHP.Tag); // ID duoc lấy khi cell lick
            if (hocPhan.ID != 0)
            {

                int ret = hocPhanDAO.Delete(hocPhan);
                if (ret > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    frmHocPhan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }


            }
            else
            {
                MessageBox.Show("Ban chua chon nam hoc can sua");
                frmHocPhan_Load(sender, e);
            }
        }
    }
}
