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
    public partial class frmNienKhoa : Form
    {
        public  int id { get; set; }
        public frmNienKhoa()
        {
            InitializeComponent();
            this.id = -1;

        }
        public frmNienKhoa(NienKhoa nienKhoa)
        {
            InitializeComponent();
            this.id = nienKhoa.ID;
            txtMaNienKhoa.Text = nienKhoa.IDView;
            txtTenNienKhoa.Text = nienKhoa.Ten;
        }
        public void SetInput(NienKhoa nienKhoa)
        {
            this.id = nienKhoa.ID;
            txtMaNienKhoa.Text = nienKhoa.IDView;
            txtTenNienKhoa.Text = nienKhoa.Ten;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            NienKhoaDAO dao = new NienKhoaDAO();
            NienKhoa nienKhoa = new NienKhoa();
            nienKhoa.IDView = txtMaNienKhoa.Text;
            nienKhoa.Ten = txtTenNienKhoa.Text;
            if (string.IsNullOrEmpty(nienKhoa.IDView))
            {
                MessageBox.Show("Chưa nhập mã niên khóa", "Thông báo");
                txtMaNienKhoa.Focus();
                return;
            }

            if (string.IsNullOrEmpty(nienKhoa.Ten))
            {
                MessageBox.Show("Chưa nhập tên niên khóa","Thông báo");
                txtTenNienKhoa.Focus();
                return;
            }

            int add = 0;
            if (id==-1)
            {
                add = 1;
            }
            else
            {
                nienKhoa.ID = id;
            }

            int ret = 0;
            if (add == 1)
                ret = dao.Insert(nienKhoa);
            else
            {
                ret = dao.Update(nienKhoa);
            }
            if (ret <= 0)
            {
                MessageBox.Show("Không thể lưu niên khóa","Thông báo");
            }
            else
            {
                this.Dispose();
            }
        }
    }
}
