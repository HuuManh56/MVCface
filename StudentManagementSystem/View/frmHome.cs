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

namespace StudentManagementSystem.View
{
    public partial class frmHome : Form
    {
        LopController lopController = new LopController();
        LopHocPhanController lopHocPhanController = new LopHocPhanController();
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
            showTvLopChuyenNganh();
            showTVLopHocPhan();
            ShowCmbKhoa();
        }

        public void showTVLopHocPhan()
        {
         //   ConnectDB connect = new ConnectDB();
         //   string sql = " select * from LopHocPhan ";
            DataTable tb = lopHocPhanController.GetAll();//connect.getTable(sql);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tvLopHocPhan.Nodes.Add(tb.Rows[i]["TenLopHocPhan"].ToString());
            }
        }

        private void showTvLopChuyenNganh()
        {
            // ConnectDB connect = new ConnectDB();
            //string sql = " select * from Lop ";
            DataTable tb = lopController.GetAll(); //connect.getTable(sql);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tvLopChuyenNganh.Nodes.Add(tb.Rows[i]["TenLop"].ToString());
            }
        }

        private void xóaLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeNode treeLopCN = this.tvLopChuyenNganh.SelectedNode;
            MessageBox.Show(" Ban co chac chan muon xoa khong", "Thong bao", MessageBoxButtons.YesNo);
           // string

            TreeNode node = tvLopChuyenNganh.SelectedNode;
            if ( node != null){
                MessageBox.Show("Ban co chac chan muon xoa", "Thong bao", MessageBoxButtons.YesNo);
                int ret = lopController.Delete(node.Text);
                if (ret > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                    tvLopChuyenNganh.Nodes.Clear();
                    showTvLopChuyenNganh();
                }
                else
                {
                    MessageBox.Show("CO Loi", "thong bao");
                }
            }
            else
            {
                 node = tvLopHocPhan.SelectedNode;
                int red = lopHocPhanController.Delete(node.Text);
                if (red > 0)
                {
                    tvLopHocPhan.Nodes.Clear();
                    showTVLopHocPhan();
                }
                else
                {
                    MessageBox.Show("Da xay ra loi", " Thong bao");
                }

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
            MessageBox.Show(cmbKhoa.Text);
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
    }
}
