using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Controller;
using StudentManagementSystem.Model;

namespace StudentManagementSystem.View
{
    public partial class frmHocPhan : Form
    {
        HocPhanController hocPhanController = new HocPhanController();
        HocKyController HocKyController = new HocKyController();
        ChuanHoaController ChuanHoaController = new ChuanHoaController();
        public frmHocPhan()
        {
            InitializeComponent();
        }
        public void ShowHocPhan()
        {
            DataTable dt = hocPhanController.GetAll();
            dtgvHocPhan.DataSource = dt;// do du dieu ra dtgv
        }
        public void ShowHocKy()
        {
            DataTable dt = HocKyController.GetALL();
            dtgvHocKy.DataSource = dt;
        }
        private void frmHocPhan_Load(object sender, EventArgs e)
        {
            ShowHocPhan();
            ShowHocKy();
           // KiemTraNgay();
        }
        public void ShowHP_HK ( string IDHk )
        {
            // do du lieu ra dtgv theo id hoc ky
            DataTable dt = hocPhanController.HocPhanHK(IDHk);
            dtgvHocPhan.DataSource = dt;
        }
        

        private void dtgvHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgvHocKy.Rows[e.RowIndex];//goi ra dong duoc chon
            string a = row.Cells[1].Value + "/" + row.Cells[2].Value;//gia tri cua cot 1+ cot 2
            txtHocKyNamHoc.Text = a;
            // truy van cac hoc phan theo idHocky
            string IDHocKy = row.Cells[0].Value + "";

            ShowHP_HK(IDHocKy);
            dtgvHocPhan.Tag = IDHocKy;
            
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtgvHocKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvHocKy_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string IDHocPhan = txtIDHocPhan.Text;
                string TenHocPhan = txtTenHP.Text;
                int SoTc =Convert.ToInt16(txtSoTC.Text);
                string IDHocky =dtgvHocPhan.Tag.ToString();
                // chuan hoa chuoi 
                int red = ChuanHoaController.ChuanHoa(IDHocPhan, TenHocPhan);
                //
                HocPhan hp = new HocPhan(IDHocPhan, TenHocPhan, SoTc, IDHocky);
           
                hocPhanController.Insert(hp);
                if( red > 0)
                {
                    MessageBox.Show("Them thanh cong");
                    Reset();
                }
                else
                {
                    MessageBox.Show(" Them khong thanh cong");
                    Reset();
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ShowHocPhan();

        }

        private void Reset()
        {
            txtIDHocPhan.ResetText();
            txtSoTC.ResetText();
            txtTenHP.ResetText();

        }
        //chon hoc phan
        private void dtgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgvHocPhan.Rows[e.RowIndex];// dòng được chọn
            txtIDHocPhan.Tag = row.Cells[0].Value + "";
            txtTenHP.Tag = row.Cells[1].Value + "";
            txtSoTC.Tag = Convert.ToString( row.Cells[2].Value );
            dtgvHocPhan.Tag = row.Cells[3].Value + "";
        }
        // update
        private void button2_Click(object sender, EventArgs e)
        {
            frmHocPhan_Update frm = new frmHocPhan_Update();
            frm.Show();
            frm.txtHocKy.Text = txtHocKyNamHoc.Text;
            frm.txtIDHp.Text = txtIDHocPhan.Tag.ToString();
            frm.txtTenHP1.Text = txtTenHP.Tag.ToString();
            frm.txtSoTC1.Text = txtSoTC.Tag.ToString();
            frm.txtHocKy.Tag = dtgvHocPhan.Tag.ToString();
            
        }
        //xoa hoc phan
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Ban co chac chan muon xoa hoc phan nay", "Thong bao", MessageBoxButtons.YesNo);
            if ( result==DialogResult.Yes)
            {
                string a = txtIDHocPhan.Text;
                HocPhan hocPhan = new HocPhan(a);

                int red = hocPhanController.Delete(hocPhan);
                try
                {
                    if (red > 0)
                    {
                        MessageBox.Show(" Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show(" xóa không thành công ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // this.Dispose();
                ShowHocPhan();
                Reset();//text rỗng
            }

            
        }
        //chon ra hoc ky gan nhât
        public void  KiemTraNgay()
        {
            // lay ra hoc ky gan nhat
            DataTable dt = HocKyController.GetALL();
            for (int i=0; i<dt.Rows.Count; i++){
                DateTime a = Convert.ToDateTime(dt.Rows[i][3]);
                DateTime b = Convert.ToDateTime(dt.Rows[i][4]);
                DateTime date = DateTime.Now;
                if (a < date && b > date)
                {
                    dtgvHocKy.Tag = dt.Rows[i][0];
                  //  MessageBox.Show(dtgvHocKy.Tag+"");
                }

            }
            

        }
    }
}
