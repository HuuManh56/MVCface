namespace sms.GUI
{
    partial class frmNamHoc
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTimeBD = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtTimeKT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNK)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTimeBD);
            this.splitContainer1.Panel1.Controls.Add(this.txtCode);
            this.splitContainer1.Panel1.Controls.Add(this.txtTimeKT);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lb1);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvNK);
            this.splitContainer1.Size = new System.Drawing.Size(1014, 296);
            this.splitContainer1.SplitterDistance = 444;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtTimeBD
            // 
            this.txtTimeBD.Location = new System.Drawing.Point(34, 56);
            this.txtTimeBD.Name = "txtTimeBD";
            this.txtTimeBD.Size = new System.Drawing.Size(231, 22);
            this.txtTimeBD.TabIndex = 2;
            this.txtTimeBD.TextChanged += new System.EventHandler(this.txtTimeBD_TextChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(34, 195);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(231, 22);
            this.txtCode.TabIndex = 4;
            this.txtCode.TextChanged += new System.EventHandler(this.txtTimeKT_TextChanged);
            // 
            // txtTimeKT
            // 
            this.txtTimeKT.Location = new System.Drawing.Point(34, 125);
            this.txtTimeKT.Name = "txtTimeKT";
            this.txtTimeKT.Size = new System.Drawing.Size(231, 22);
            this.txtTimeKT.TabIndex = 3;
            this.txtTimeKT.TextChanged += new System.EventHandler(this.txtTimeKT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian kết thúc";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(33, 19);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(119, 17);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Thời gian bắt đầu";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(249, 247);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(135, 247);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 247);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNK
            // 
            this.dgvNK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNK.Location = new System.Drawing.Point(0, 0);
            this.dgvNK.Name = "dgvNK";
            this.dgvNK.RowTemplate.Height = 24;
            this.dgvNK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNK.Size = new System.Drawing.Size(566, 296);
            this.dgvNK.TabIndex = 0;
            this.dgvNK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNK_CellClick);
            this.dgvNK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNK_CellContentClick);
            // 
            // frmNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 296);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNamHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Năm học";
            this.Load += new System.EventHandler(this.frmNamHoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtTimeBD;
        private System.Windows.Forms.TextBox txtTimeKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
    }
}