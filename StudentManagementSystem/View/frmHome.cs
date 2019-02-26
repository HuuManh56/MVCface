﻿using System;
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
        }

        private void showTVLopHocPhan()
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
            TreeNode node = tvLopChuyenNganh.SelectedNode;
            if ( node != null){
                int ret = lopController.Delete(node.Text);
                if (ret > 0)
                {
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
    }
}
