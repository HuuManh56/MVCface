using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Database;
using StudentManagementSystem.Constant;
using StudentManagementSystem.Controller;
using StudentManagementSystem.Model;

namespace StudentManagementSystem.View
{
    public partial class frmHome : Form
    {
        LopController lopController = new LopController();
        HocKyController hocKyController = new HocKyController();
        LopHocPhanController lopHocPhanController = new LopHocPhanController();
        SinhVienController sinhVienController = new SinhVienController();
        public frmHome()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'faceDBDataSet.HocKy' table. You can move, or remove it, as needed.
            this.hocKyTableAdapter.Fill(this.faceDBDataSet.HocKy);
            showTvLopChuyenNganh();
            //showTVLopHocPhan();
            ShowCmbKhoa();
           
            
        }
        public void getNode()
        {

        }
        public void showListSV()
        {
            TreeNode node = tvLopChuyenNganh.SelectedNode;
            string IdLop = lopController.getIdByName(node.Text);
            dgvDanhSach.DataSource = sinhVienController.getListCN(IdLop);
        }

        //public void showTVLopHocPhan()
        //{
        // //   ConnectDB connect = new ConnectDB();
        // //   string sql = " select * from LopHocPhan ";
        //    DataTable tb = lopHocPhanController.GetAll();//connect.getTable(sql);
        //    for (int i = 0; i < tb.Rows.Count; i++)
        //    {
        //        tvLopHocPhan.Nodes.Add(tb.Rows[i]["TenLopHocPhan"].ToString());
        //    }
        //}

        private void showTvLopChuyenNganh()
        {
            
            DataTable tb = lopController.GetAll(); //connect.getTable(sql);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tvLopChuyenNganh.Nodes.Add(tb.Rows[i]["TenLop"].ToString());
            }
        }
        private void showTvLopHocPhan()
        {
            DataTable tb = lopHocPhanController.GetAll();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tvLopHocPhan.Nodes.Add(tb.Rows[i][2].ToString());
            }
        }
        private void xóaLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode nodeCN = tvLopChuyenNganh.SelectedNode;
            TreeNode nodeHP = tvLopHocPhan.SelectedNode;
                if (nodeCN != null && nodeHP == null)// xoa lop chuyen nganh
                {

                    DialogResult resul = MessageBox.Show("Ban co chac chan muon xoa", "Thong bao", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        int ret = lopController.Delete(nodeCN.Text);
                        if (ret > 0)
                        {
                            MessageBox.Show("Xoa thanh cong");
                            tvLopChuyenNganh.Nodes.Clear();
                            cmbKhoa.Refresh();
                            showTvLopChuyenNganh();
                        }
                        else
                        {
                            MessageBox.Show("CO Loi", "thong bao");
                        }
                    }
                    
                }
                else if(nodeHP != null && nodeCN == null)// xoa lop hoc phan
                {
                    DialogResult resul = MessageBox.Show("Ban co chac chan muon xoa", "Thong bao", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        int ret = lopHocPhanController.Delete(nodeHP.Text);
                        if (ret > 0)
                        {
                            MessageBox.Show("Xoa thanh cong");
                            tvLopHocPhan.Nodes.Clear();
                            showTvLopHocPhan();
                        }
                        else
                        {
                            MessageBox.Show("CO Loi", "thong bao");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn lớp");
                }
        }

        private void tvLopChuyenNganh_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvLopChuyenNganh.SelectedNode = e.Node;
        }

        private void tvLopHocPhan_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvLopHocPhan.SelectedNode = e.Node;
        }

        private void xoaLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xóaLớpToolStripMenuItem_Click(sender, e);
        }

        private void tdmThemLopChuyenNganh_Click(object sender, EventArgs e)
        {
            frmLop frmLop = new frmLop();
            frmLop.ShowDialog();
            cmbKhoa.Text = "";
            tvLopChuyenNganh.Nodes.Clear();
            showTvLopChuyenNganh();

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ShowCmbKhoa()
        {
            ConnectDB connectDB = new ConnectDB();
            string sql = " select * from NienKhoa";
            DataTable dt = connectDB.getTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               cmbKhoa.Items.Add(dt.Rows[i]["TenKhoa"].ToString());
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbKhoa.Text);
            tvLopChuyenNganh.Nodes.Clear();
            DataTable tb = lopController.Truyvan(cmbKhoa.Text);
            for(int i = 0; i < tb.Rows.Count; i++)
            {
                string a = tb.Rows[i][0].ToString();
                tvLopChuyenNganh.Nodes.Add(tb.Rows[i][0].ToString());
            }
        }

        private void họcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocPhan frmHocPhan = new frmHocPhan();
            frmHocPhan.Show();
        }

        private void tdmThemLpHocPhan_Click(object sender, EventArgs e)
        {
            frmLopHocPhan frm = new frmLopHocPhan();
            frm.Show();
        }

        private void tdmSVLopChuyenNganh_Click(object sender, EventArgs e)
        {
            TreeNode node = tvLopChuyenNganh.SelectedNode;
            Lop lop = lopController.getByName(node.Text);
            if (lop.IDLopCN.Equals("")==true)
            {
                MessageBox.Show("Bạn chưa chọn lớp", "Thông báo");
            }
            else
            {
                frmSinhVien frm = new frmSinhVien(lop);
                frm.Show();
                this.showListSV();
            }
        }

        private void tvLopChuyenNganh_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.showListSV();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listTenHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listTenHK_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void listTenHK_MouseClick(object sender, MouseEventArgs e)
        {
            tvLopHocPhan.Nodes.Clear();
            string a = listTenHK.SelectedIndex.ToString();
            int i = 0;
            i=Convert.ToInt16(a );

            //MessageBox.Show(a);
            if (i >= 0)
            {
                DataTable dt = hocKyController.GetALL();
                string idhk = dt.Rows[i][0] + "";
                DataTable dt1 = lopHocPhanController.LopHP_HK(idhk);
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    tvLopHocPhan.Nodes.Add(dt1.Rows[j][2] + "");
                }
                
            }
            else
            {
                this.Close();
                
            }
            
                       
        }

        private void listNamhk_MouseClick(object sender, MouseEventArgs e)
        {
            tvLopHocPhan.Nodes.Clear();
            string a = listNamhk.SelectedIndex.ToString();
            int i = 0;
            i = Convert.ToInt16(a);
            DataTable dt = hocKyController.GetALL();
            string idhk = dt.Rows[i][0] + "";
            DataTable dt1 = lopHocPhanController.LopHP_HK(idhk);
            for (int j = 0; j < dt1.Rows.Count; j++)
            {
              tvLopHocPhan.Nodes.Add(dt1.Rows[j][2] + "");
            }

        }

        private void sửaLớpChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
