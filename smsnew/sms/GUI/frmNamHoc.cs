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
    public partial class frmNamHoc : Form
    {
        public frmNamHoc()
        {
            InitializeComponent();
        }
        // hien thi lst nam hoc 
        public void GetAll_NamHoc()
        {
            NamHocDAO namHocDAO = new NamHocDAO();
            dgvNK.DataSource = namHocDAO.GetNamHoc();
            
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            txtTimeKT.Text = null;
            txtTimeBD.Text = null;
            txtCode.Text ="";    
            GetAll_NamHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NamHocDAO namHocDAO = new NamHocDAO();
            NamHoc namHoc = new NamHoc();
             namHoc.BatDau = Convert.ToDateTime(txtTimeBD.Text.ToString());
             namHoc.KetThuc = Convert.ToDateTime(txtTimeKT.Text.ToString());
             namHoc.Code = namHoc.BatDau.Value.Year.ToString() + " - " + namHoc.KetThuc.Value.Year.ToString();
            int ret = namHocDAO.Insert(namHoc);
            if (ret> 0)
            {
                MessageBox.Show( "Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }

            
            // loat lại
            frmNamHoc_Load(sender, e);

        }



        private void dgvNK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtTimeBD.Tag = dgvNK.Rows[row].Cells[0].Value + "";
            string[] a = dgvNK.Rows[row].Cells[1].Value.ToString().Split(' ');
            string[] b = dgvNK.Rows[row].Cells[2].Value.ToString().Split(' ');
            txtTimeBD.Text = a[0];
            txtTimeKT.Text = b[0];
            txtCode.Text = a[0].Substring(a[0].Length - 4, 4) +" - "+ b[0].Substring(b[0].Length - 4, 4);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NamHocDAO namHocDAO = new NamHocDAO();
            NamHoc namHoc = new NamHoc();
            namHoc.ID = Convert.ToInt16(txtTimeBD.Tag);
            if (namHoc.ID !=0)
            {
                namHoc.BatDau = Convert.ToDateTime(txtTimeBD.Text.ToString());
                namHoc.KetThuc = Convert.ToDateTime(txtTimeKT.Text.ToString());
                namHoc.Code = namHoc.BatDau.Value.Year.ToString() + " - " + namHoc.KetThuc.Value.Year.ToString();
                int ret = namHocDAO.Update(namHoc);
                if (ret > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    frmNamHoc_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
               

            }
            else
            {
                MessageBox.Show("Ban chua chon nam hoc can sua");
                frmNamHoc_Load(sender, e);
            }
        }

        private void txtTimeKT_TextChanged(object sender, EventArgs e)
        {
            
        }
            

        private void txtTimeBD_TextChanged(object sender, EventArgs e)
        {
            //txtCode.Text = txtTimeBD.Text ;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NamHocDAO namHocDAO = new NamHocDAO();
            NamHoc namHoc = new NamHoc();
            namHoc.ID = Convert.ToInt16(txtTimeBD.Tag);// ID duoc lấy khi cell lick
            if (namHoc.ID != 0) 
            {
                
                int ret = namHocDAO.Delete(namHoc);
                if (ret > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    frmNamHoc_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }


            }
            else
            {
                MessageBox.Show("Ban chua chon nam hoc can sua");
                frmNamHoc_Load(sender, e);
            }
        }

        private void dgvNK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
