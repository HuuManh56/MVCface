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

        public frmHocPhan()
        {
            InitializeComponent();
        }
        public void ShowHocPhan()
        {
            DataTable dt = hocPhanController.GetAll();
            dtgvHocPhan.DataSource = dt;
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

        }
        public void ShowHP_HK ( string IDHk )
        {
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
            string IDHocPhan = txtIDHocPhan.Text;
            string TenHocPhan = txtTenHP.Text;
            int SoTc =Convert.ToInt16( txtSoTC.Text);
            string IDHocky =dtgvHocPhan.Tag.ToString();
            HocPhan hp = new HocPhan(IDHocPhan, TenHocPhan, SoTc, IDHocky);
            try
            {
                int red= hocPhanController.Insert(hp);
                if( red > 0)
                {
                    MessageBox.Show("Them thanh cong");
                    Reset();
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Reset()
        {
            txtIDHocPhan.ResetText();
            txtSoTC.ResetText();
            txtTenHP.ResetText();

        }
    }
}
