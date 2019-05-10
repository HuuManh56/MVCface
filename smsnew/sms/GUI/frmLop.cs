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
    public partial class frmLop : Form
    {
        public int id { get; set; }
        public int idNienKhoa { get; set; }
        public frmLop()
        {
            InitializeComponent();
            this.id = -1;
        }

        public frmLop(int _idNienKhoa)
        {
            InitializeComponent();
            this.id = -1;
            NienKhoaDAO dao = new NienKhoaDAO();
            NienKhoa nienKhoa = dao.GetByID(_idNienKhoa);
            txtKhoa.Text = nienKhoa.Ten;
            this.idNienKhoa = (int)nienKhoa.ID;
        }

        public frmLop(Lop lop)
        {
            NienKhoaDAO nienKhoaDao = new NienKhoaDAO();
            InitializeComponent();
            this.id = lop.ID;
            txtMaLop.Text = lop.IDView;
            txtTenLop.Text = lop.TenLop;
            NienKhoaDAO dao = new NienKhoaDAO();
            NienKhoa nienKhoa = dao.GetByID((int)lop.NienKhoaID);
            txtKhoa.Text = nienKhoa.Ten;
            this.idNienKhoa = (int)nienKhoa.ID;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LopDAO lopDao = new LopDAO();
            Lop lop = new Lop();
            lop.IDView = txtMaLop.Text;
            lop.TenLop = txtTenLop.Text;
            lop.NienKhoaID = this.idNienKhoa;
            if (string.IsNullOrEmpty(lop.IDView))
            {
                MessageBox.Show("Chưa nhập mã lớp", "Thông báo");
                txtMaLop.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lop.TenLop))
            {
                MessageBox.Show("Chưa nhập tên lớp", "Thông báo");
                txtTenLop.Focus();
                return;
            }

            int add = 0;
            if (id == -1)
            {
                add = 1;
            }
            else
            {
                lop.ID = id;
            }

            int ret = 0;
            if (add == 1)
                ret = lopDao.Insert(lop);
            else
            {
                ret = lopDao.Update(lop);
            }
            if (ret <= 0)
            {
                MessageBox.Show("Không thể lưu dữ liệu", "Thông báo");
            }
            else
            {
                this.Dispose();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtMaLop_Leave(object sender, EventArgs e)
        {
            txtMaLop.Text = txtMaLop.Text.ToUpper();
        }
    }
}
