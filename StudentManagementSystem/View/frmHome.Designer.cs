﻿namespace StudentManagementSystem.View
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TvDanhSachLop = new System.Windows.Forms.TreeView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.thêmLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSinhViênToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.xóaLớpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.sửaTtSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStripContainer1);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(986, 476);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TvDanhSachLop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(199, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp học";
            // 
            // TvDanhSachLop
            // 
            this.TvDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvDanhSachLop.Location = new System.Drawing.Point(4, 19);
            this.TvDanhSachLop.Margin = new System.Windows.Forms.Padding(4);
            this.TvDanhSachLop.Name = "TvDanhSachLop";
            this.TvDanhSachLop.Size = new System.Drawing.Size(191, 453);
            this.TvDanhSachLop.TabIndex = 0;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_BottomToolStripPanel_Click);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox2);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(782, 421);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(782, 448);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(782, 421);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(774, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(4, 19);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(774, 398);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripSplitButton1,
            this.toolStripSeparator2,
            this.toolStripSplitButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(136, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLớpHọcToolStripMenuItem,
            this.thêmSinhViênToolStripMenuItem2});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "Thêm mới";
            // 
            // thêmLớpHọcToolStripMenuItem
            // 
            this.thêmLớpHọcToolStripMenuItem.Name = "thêmLớpHọcToolStripMenuItem";
            this.thêmLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.thêmLớpHọcToolStripMenuItem.Text = "Thêm lớp học ";
            // 
            // thêmSinhViênToolStripMenuItem2
            // 
            this.thêmSinhViênToolStripMenuItem2.Name = "thêmSinhViênToolStripMenuItem2";
            this.thêmSinhViênToolStripMenuItem2.Size = new System.Drawing.Size(182, 26);
            this.thêmSinhViênToolStripMenuItem2.Text = "Thêm sinh viên";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaLớpToolStripMenuItem1,
            this.xóaSinhVienToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // xóaLớpToolStripMenuItem1
            // 
            this.xóaLớpToolStripMenuItem1.Name = "xóaLớpToolStripMenuItem1";
            this.xóaLớpToolStripMenuItem1.Size = new System.Drawing.Size(175, 26);
            this.xóaLớpToolStripMenuItem1.Text = "Xóa Lớp";
            // 
            // xóaSinhVienToolStripMenuItem
            // 
            this.xóaSinhVienToolStripMenuItem.Name = "xóaSinhVienToolStripMenuItem";
            this.xóaSinhVienToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.xóaSinhVienToolStripMenuItem.Text = "Xóa Sinh Vien";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaTtSinhVienToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // sửaTtSinhVienToolStripMenuItem
            // 
            this.sửaTtSinhVienToolStripMenuItem.Name = "sửaTtSinhVienToolStripMenuItem";
            this.sửaTtSinhVienToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.sửaTtSinhVienToolStripMenuItem.Text = "Sửa tt sinh vien";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(139, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(36, 27);
            this.toolStrip2.TabIndex = 1;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Diem danh";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.điểmDanhToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLớpToolStripMenuItem,
            this.thêmSinhViênToolStripMenuItem});
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.thêmMớiToolStripMenuItem.Text = "Thêm mới";
            // 
            // thêmLớpToolStripMenuItem
            // 
            this.thêmLớpToolStripMenuItem.Name = "thêmLớpToolStripMenuItem";
            this.thêmLớpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.thêmLớpToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.thêmLớpToolStripMenuItem.Text = "Thêm lớp học ";
            // 
            // thêmSinhViênToolStripMenuItem
            // 
            this.thêmSinhViênToolStripMenuItem.Name = "thêmSinhViênToolStripMenuItem";
            this.thêmSinhViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.thêmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.thêmSinhViênToolStripMenuItem.Text = "Thêm sinh viên ";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaLớpToolStripMenuItem,
            this.sửaThôngTinSinhVienToolStripMenuItem});
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa ";
            // 
            // sửaLớpToolStripMenuItem
            // 
            this.sửaLớpToolStripMenuItem.Name = "sửaLớpToolStripMenuItem";
            this.sửaLớpToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.sửaLớpToolStripMenuItem.Text = "Sửa lớp";
            // 
            // sửaThôngTinSinhVienToolStripMenuItem
            // 
            this.sửaThôngTinSinhVienToolStripMenuItem.Name = "sửaThôngTinSinhVienToolStripMenuItem";
            this.sửaThôngTinSinhVienToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.sửaThôngTinSinhVienToolStripMenuItem.Text = "Sửa thông tin sinh vien";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaLớpToolStripMenuItem,
            this.xóaSinhViênToolStripMenuItem});
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.xóaToolStripMenuItem.Text = "Xóa ";
            // 
            // xóaLớpToolStripMenuItem
            // 
            this.xóaLớpToolStripMenuItem.Name = "xóaLớpToolStripMenuItem";
            this.xóaLớpToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.xóaLớpToolStripMenuItem.Text = "Xóa lớp";
            // 
            // xóaSinhViênToolStripMenuItem
            // 
            this.xóaSinhViênToolStripMenuItem.Name = "xóaSinhViênToolStripMenuItem";
            this.xóaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.xóaSinhViênToolStripMenuItem.Text = "Xóa sinh viên";
            // 
            // điểmDanhToolStripMenuItem
            // 
            this.điểmDanhToolStripMenuItem.Name = "điểmDanhToolStripMenuItem";
            this.điểmDanhToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.điểmDanhToolStripMenuItem.Text = "Điểm danh";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.thoatToolStripMenuItem.Text = "Thoát";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 476);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly sinh vien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView TvDanhSachLop;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem thêmLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSinhViênToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem xóaLớpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xóaSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem sửaTtSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
    }
}