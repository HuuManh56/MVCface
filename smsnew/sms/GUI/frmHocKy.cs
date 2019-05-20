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
    public partial class frmHocKy : Form
    {
        public frmHocKy()
        {
            InitializeComponent();
        }

        private void frmHocKy_Load(object sender, EventArgs e)
        {
            HocKyDAO hoc = new HocKyDAO();
            //dgvHocKy.DataSource = hoc.GetALL();
            var lst = hoc.Getcode();
            foreach (NamHocLNQ item in lst)
            {
                string a = item.code.Trim();
                cmbNamHk.Items.Add(a);
            }
            
        }
        private void cmbNamHk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cmbNamHk.SelectedItem.ToString();
            HocKyDAO hoc = new HocKyDAO();
           dgvHocKy.DataSource= hoc.GetByNamHoc(a);
            txtTenHK.Text = "";
        }
        private void btnThem_HK_Click(object sender, EventArgs e)
        {
            string a = cmbNamHk.SelectedItem.ToString();
            HocKyDAO hoc = new HocKyDAO();
            HocKy hocKy = new HocKy();
            hocKy.TenHocKy = txtTenHK.Text;
            hocKy.Id_Namhoc = hoc.GetIDNamhoc(a);
            

            int ret = hoc.Insert(hocKy); 
            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
            //load lại dgv
            dgvHocKy.DataSource = hoc.GetByNamHoc(a);

        }

        private void dgvHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtTenHK.Text = dgvHocKy.Rows[row].Cells[1].Value + "";
            txtTenHK.Tag = dgvHocKy.Rows[row].Cells[0].Value + "";
        }

        private void btnXoaHk_Click(object sender, EventArgs e)
        {
            HocKy hocKy = new HocKy();
            hocKy.ID = Convert.ToInt16( txtTenHK.Tag);
            HocKyDAO hocKyDAO = new HocKyDAO();
            
            if (hocKy.ID != 0)
            {

                int ret = hocKyDAO.Delete(hocKy);
                if (ret > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    string a = cmbNamHk.Text;
                    dgvHocKy.DataSource = hocKyDAO.GetByNamHoc(a);

                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }


            }
            else
            {
                MessageBox.Show("Ban chua chon nam hoc can sua");
               
            }
        }

        private void btnSuaHK_Click(object sender, EventArgs e)
        {
            HocKyDAO hocKyDAO = new HocKyDAO();
            HocKy hoc = new HocKy();
            hoc.ID = Convert.ToInt16(txtTenHK.Tag);
            if (hoc.ID != 0)
            {
                hoc.TenHocKy = txtTenHK.Text;
                int ret=hocKyDAO.Update(hoc);
                if (ret > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    string a = cmbNamHk.Text;
                    dgvHocKy.DataSource = hocKyDAO.GetByNamHoc(a);
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
