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

namespace StudentManagementSystem.View
{
    public partial class frmHome : Form
    {
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
        }

        private void showTVLopHocPhan()
        {
            ConnectDB connect = new ConnectDB();
            string sql = " select * from LopHocPhan ";
            DataTable tb = connect.getTable(sql);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tvLopHocPhan.Nodes.Add(tb.Rows[i]["TenLopHocPhan"].ToString());
            }
        }

        private void showTvLopChuyenNganh()
        {
            ConnectDB connect = new ConnectDB();
            string sql = " select * from Lop ";
            DataTable tb = connect.getTable(sql);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tvLopChuyenNganh.Nodes.Add(tb.Rows[i]["TenLop"].ToString());
            }
        }

        private void xóaLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode treeLopCN = this.tvLopChuyenNganh.SelectedNode;
            MessageBox.Show(" Ban co chac chan muon xoa khong", "Thong bao", MessageBoxButtons.YesNo);
            string
        }
    }
}
