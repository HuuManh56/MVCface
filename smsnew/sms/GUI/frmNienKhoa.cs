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
        public  int id1 { get; set; }
        public frmNienKhoa()
        {
            InitializeComponent();
            this.id1 = -1;
            NienKhoaDAO dao = new NienKhoaDAO();
            dgvKhoa.DataSource = dao.GetAll2();

        }
        public frmNienKhoa(NienKhoa nienKhoa)
        {
            InitializeComponent();
            this.id1 = nienKhoa.ID;
            txtMaNienKhoa.Text = nienKhoa.IDView;
            txtTenNienKhoa.Text = nienKhoa.Ten;
        }
        public void SetInput(NienKhoa nienKhoa)
        {
            this.id1 = nienKhoa.ID;
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
            if (id1==-1)
            {
                add = 1;
            }
            else
            {
                nienKhoa.ID = id1;
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
                this.id1 = -1;
                txtMaNienKhoa.Text = "";
                txtTenNienKhoa.Text = "";
                dgvKhoa.DataSource = dao.GetAll2();

                // this.Dispose();
            }
        }

        private void frmNienKhoa_Load(object sender, EventArgs e)
        {

        }

        private void list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                var x = dgvKhoa.Rows[row];
                this.id1 = Int32.Parse(dgvKhoa.Rows[row].Cells[0].Value.ToString());
                txtMaNienKhoa.Text = dgvKhoa.Rows[row].Cells[1].Value.ToString();
                txtTenNienKhoa.Text = dgvKhoa.Rows[row].Cells[2].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NienKhoaDAO dao = new NienKhoaDAO();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa " + dao.GetByID(this.id1).Ten,
                "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int ret = dao.Delete(this.id1);
                if (ret < 0)
                {
                    MessageBox.Show("Không xóa được bản ghi");

                }
                else
                {
                    this.id1 = -1;
                    txtMaNienKhoa.Text = "";
                    txtTenNienKhoa.Text = "";
                    dgvKhoa.DataSource = dao.GetAll2();
                }
            }
        }
    }
}
