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
using sms.DTO;
using sms.Entities;
using sms.Entities.ViewModel;
using sms.GUI;
using System.Globalization;
using ClosedXML.Excel;

namespace sms
{
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
        }
        // hien thi tvlopHP
        public void ShowLopHP()
        {
            LopHpDAO lopHpDAO = new LopHpDAO();
            var lis = lopHpDAO.GetTen();
            foreach (Ten item in lis)
            {
                tvLopHocPhan.Nodes.Add(item.TenHp);
            }
        }
        private void nămHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNamHoc frmNamHoc = new frmNamHoc();
            frmNamHoc.ShowDialog();
        }

        private void HocKy_Click(object sender, EventArgs e)
        {
            frmHocKy frmHocKy = new frmHocKy();
            frmHocKy.ShowDialog();
        }

        private void HocPhan_Click(object sender, EventArgs e)
        {
            frmHocPhan frm = new frmHocPhan();
            frm.ShowDialog();
        }

        private void LopHP_Click(object sender, EventArgs e)
        {
            frmLopHP frmLopHP = new frmLopHP();
            frmLopHP.ShowDialog();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadCBKhoa();
           
            HocKyDAO hoc = new HocKyDAO();
            //dgvHocKy.DataSource = hoc.GetALL();
            var lst = hoc.Getcode();
            foreach (NamHocLNQ item in lst)
            {
                string a = item.code.Trim();
                cmbNamHK.Items.Add(a);
            }


        }

        private void cmbNamHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHocKY.Items.Clear();
            tvLopHocPhan.Nodes.Clear();
            HocKyDAO hoc = new HocKyDAO();
            var lstHK = hoc.GetTenHK(cmbNamHK.Text);
            foreach (HK1 item in lstHK)
            {
                string a = item.ten;
                cmbHocKY.Items.Add(a);

            }

        }

        private void thêmLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (cmbHocKY.SelectedIndex < 0 || cmbNamHK.SelectedIndex < 0)
            {
                MessageBox.Show(" Bạn phải chọn năm học và học kỳ");

            }
            else
            {
                frmLopHP_Them frm = new frmLopHP_Them();
                frm.txtHocKy.Text = cmbHocKY.Text + "";
                frm.txtNamHK.Text = cmbNamHK.Text;
                frm.ShowDialog();

                LoadLHP_HK();


            }
        }

        public void LoadLHP_HK()
        {
            LopHpDAO lopHpDAO = new LopHpDAO();
            var lstHK = lopHpDAO.GetLopHP_hk(cmbHocKY.Text, cmbNamHK.Text);
            tvLopHocPhan.Nodes.Clear();
            foreach (Ten item in lstHK)
            {
                string a = item.TenHp;
                tvLopHocPhan.Nodes.Add(a);
            }
        }
        private void cmbHocKY_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadLHP_HK();
        }

        private void sửaLớpHọcPhầnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tvLopHocPhan.SelectedNode.Index < 0 || cmbNamHK.SelectedIndex < 0 || tvLopHocPhan.SelectedNode == null)
            {
                MessageBox.Show("Bạn chưa chọn lớp học phần");
            }
            else
            {
                frmLopHP_Sua frm = new frmLopHP_Sua();
                frm.txtHocKy.Text = cmbHocKY.Text;
                frm.txtNamHK.Text = cmbNamHK.Text;
                string a = tvLopHocPhan.Tag + "";
                string[] b = a.Split('-');

                frm.txtTenLopHP.Text = a;
                frm.cmbHP.Text = b[0];
                frm.txtMaLopHP.Text = b[1];
                frm.txtTenLopHP.Tag = a;
                frm.ShowDialog();

                LoadLHP_HK();
            }
        }

        public void ShowSV_LHP(string s)
        {
            SinhVienLHPDAO sv = new SinhVienLHPDAO();

            //
            LopHpDAO lopHpDAO = new LopHpDAO();
            LopHocPhan lopHocPhan = new LopHocPhan();


            lopHocPhan.ID = lopHpDAO.IDLopHP(s);
            //
            SinhVienDAO sinhVien = new SinhVienDAO();


            dgvDanhSach.DataSource = sinhVien.GetAllByLHP(lopHocPhan.ID);
        }
        private void tvLopHocPhan_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvLopHocPhan.SelectedNode = e.Node;

            tvLopHocPhan.Tag = e.Node.Text;
            // loat sinh vien lớp học phần 
            ShowSV_LHP(e.Node.Text);
        }

        private void xóaLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tvLopHocPhan.SelectedNode.Index < 0 || cmbNamHK.SelectedIndex < 0 || tvLopHocPhan.SelectedNode == null)
            {
                MessageBox.Show(" ban chua chon nam hoc va hoc ky");

            }
            else
            {
                LopHpDAO lopHpDAO = new LopHpDAO();
                LopHocPhan lopHocPhan = new LopHocPhan();


                lopHocPhan.ID = lopHpDAO.IDLopHP(tvLopHocPhan.Tag.ToString());
                if (lopHocPhan.ID != 0)
                {

                    int ret = lopHpDAO.Delete(lopHocPhan);
                    if (ret > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadLHP_HK();//load lại tv
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }


                }
                else
                {
                    MessageBox.Show("Ban chua chon nam hoc can sua");

                }
            }

        }

        private void Khoa_Click(object sender, EventArgs e)
        {
            frmNienKhoa frm = new frmNienKhoa();
            frm.ShowDialog();
        }

        public void LoadCBKhoa()
        {
            NienKhoaDAO dao = new NienKhoaDAO();
            var lst = dao.GetAll2();
            foreach (NienKhoaVM item in lst)
            {
                Item a = new Item();
                a.Text = item.idview;
                a.Value = item.id;
                cmbKhoa.Items.Add(a);
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLopChuyenNganh();
        }

        private void LoadLopChuyenNganh()
        {
            tvLopChuyenNganh.Nodes.Clear();
            Item select = (Item)cmbKhoa.SelectedItem;
            LopDAO dao = new LopDAO();
            List<Lop> list = dao.GetByNienKhoa(select.Value);
            tvLopHocPhan.Nodes.Clear();
            foreach (Lop item in list)
            {
                TreeNode a = new TreeNode();
                a.Text = item.TenLop;
                a.Tag = item.ID;
                // string a = item.TenLop;
                tvLopChuyenNganh.Nodes.Add(a);

            }
        }

        private void tsThemLopCN_Click(object sender, EventArgs e)
        {
            Item select = (Item)cmbKhoa.SelectedItem;
            if (select == null)
            {
                MessageBox.Show("Chưa chọn khóa");
                return;

            }
            frmLop frm = new frmLop(select.Value);
            frm.ShowDialog();
            LoadLopChuyenNganh();

        }

        private void tsSuaLopCN_Click(object sender, EventArgs e)
        {
            TreeNode theNode = new TreeNode();
            theNode = tvLopChuyenNganh.SelectedNode;
            if (theNode == null)
            {
                MessageBox.Show("Chưa chọn lớp chuyên ngành");
                return;

            }
            LopDAO dao = new LopDAO();
            Lop lop = dao.GetById((int)theNode.Tag);
            frmLop frm = new frmLop(lop);
            frm.ShowDialog();
            LoadLopChuyenNganh();
        }

        private void tsXoaLopCN_Click(object sender, EventArgs e)
        {
            TreeNode theNode = new TreeNode();
            theNode = tvLopChuyenNganh.SelectedNode;
            if (theNode == null)
            {
                MessageBox.Show("Chưa chọn lớp chuyên ngành");
                return;

            }
            LopDAO dao = new LopDAO();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp " + theNode.Text + "?", "Xác nhận",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int ret = dao.Delete((int)theNode.Tag);
                if (ret < 0)
                {
                    MessageBox.Show("Xóa không thành công");
                }
                else
                {
                    LoadLopChuyenNganh();
                }
            }
        }

        private void stmThemLopCN_Click(object sender, EventArgs e)
        {
            tsThemLopCN_Click(sender, e);
        }

        private void stmSuaLopCN_Click(object sender, EventArgs e)
        {
            tsSuaLopCN_Click(sender, e);
        }

        private void stmXoaLopCN_Click(object sender, EventArgs e)
        {
            tsXoaLopCN_Click(sender, e);
        }

        private void tdmSVLopChuyenNganh_Click(object sender, EventArgs e)
        {
            TreeNode theNode = new TreeNode();
            theNode = tvLopChuyenNganh.SelectedNode;
            if (theNode == null)
            {
                MessageBox.Show("Chưa chọn lớp chuyên ngành");
                return;
            }
            frmSinhVien frm = new frmSinhVien((int)theNode.Tag);
            frm.ShowDialog();
            LoadSVLopCN();
        }

        private void LoadSVLopCN()
        {
            TreeNode theNode = new TreeNode();
            theNode = tvLopChuyenNganh.SelectedNode;
            if (theNode == null)
            {
                // MessageBox.Show("Chưa chọn lớp chuyên ngành");
                return;
            }

            SinhVienDAO dao = new SinhVienDAO();
            List<SinhVien> list = dao.GetByClassID2((int)theNode.Tag);
            List<SinhVienCNVM> listVM = new List<SinhVienCNVM>();
            foreach (var item in list)
            {
                SinhVienCNVM vm = new SinhVienCNVM();
                vm.id = item.ID;
                vm.HoTen = item.HoTen;
                vm.GioiTinh = (item.GioiTinh == 1 ? "Nam" : "Nữ");
                //  vm.NgaySinh = date2string((DateTime)item.NgaySinh);
                vm.NgaySinh = ((DateTime)item.NgaySinh).ToString("dd/MM/yyyy");
                listVM.Add(vm);
            }

            dgvDanhSach.DataSource = listVM;
        }

        private string date2string(DateTime date)
        {
            string result = "";
            DateTime dt = DateTime.ParseExact(date.ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);

            result = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            return result;
        }

        private void tvLopChuyenNganh_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadSVLopCN();
        }

        private void tsXoaSV_Click(object sender, EventArgs e)
        {
            var select = dgvDanhSach.SelectedRows;
            if (select == null)
            {
                MessageBox.Show("Chưa chọn sinh viên");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên " + select[0].Cells[1].Value.ToString(),
                "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SinhVienDAO dao = new SinhVienDAO();
                int ret = dao.Delete(Int32.Parse(select[0].Cells[0].Value.ToString()));
                if (ret < 0)
                {
                    MessageBox.Show("Không xóa được bản ghi");
                    return;
                }
                else
                {
                    LoadSVLopCN();
                }
            }


        }

        private void tsSuaSV_Click(object sender, EventArgs e)
        {
            var select = dgvDanhSach.SelectedRows;
            if (select == null)
            {
                MessageBox.Show("Chưa chọn sinh viên");
                return;
            }
            SinhVienDAO dao = new SinhVienDAO();
            SinhVien sinhVien = dao.GetByID(Int32.Parse(select[0].Cells[0].Value.ToString()));

            if (sinhVien != null)
            {
                frmSinhVien frm = new frmSinhVien(sinhVien);
                frm.ShowDialog();
                LoadSVLopCN();
            }

        }

        private void tdmSVLopHocPhan_Click(object sender, EventArgs e)
        {
            TreeNode theNode = tvLopHocPhan.SelectedNode;
            if (theNode == null)
            {
                MessageBox.Show("Chưa chọn lớp học phần");
                return;
            }
            LopHpDAO dao = new LopHpDAO();
            MyDBContext db = new MyDBContext();

            LopHocPhan lopHp = db.LopHocPhans.Find(dao.IDLopHP(theNode.Text));
            frmSinhVienLHP frm = new frmSinhVienLHP(lopHp);
            frm.ShowDialog();
            LoadSinhVienLHP();
        }
        private void LoadSinhVienLHP()
        {
            TreeNode theNode = tvLopHocPhan.SelectedNode;
            LopHpDAO dao = new LopHpDAO();
            int idLHP = dao.IDLopHP(theNode.Text);
            SinhVienDAO sinhVienDao = new SinhVienDAO();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC ListSVLHP @idLop"
                , new object[] { idLHP });
            dgvDanhSach.DataSource = data;
        }

        private void DiemDanh_Click(object sender, EventArgs e)
        {
            TreeNode theNode = tvLopHocPhan.SelectedNode;
            if (theNode == null)
            {
                MessageBox.Show("Chưa chọn lớp học phần");
                return;
            }
            LopHpDAO dao = new LopHpDAO();
            int idLHP = dao.IDLopHP(theNode.Text);
            frmDiemDanh frm = new frmDiemDanh(idLHP);
            frm.Show();
            LoadSinhVienLHP();
        }

        private void sửaĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sửaĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var select = dgvDanhSach.SelectedRows;
            if (select.Count == 0 )
            {
                MessageBox.Show("Chưa chọn sinh viên");
                return;
            }
            else
            {
                SinhVienDAO dao = new SinhVienDAO();
                SinhVien sinhVien = dao.GetByID(Int32.Parse(select[0].Cells[0].Value.ToString()));
                if (sinhVien != null)
                {
                    frmDiem frm = new frmDiem();
                    frm.txtDiem1.Text = select[0].Cells[5].Value.ToString();
                    frm.txtDiem2.Text = select[0].Cells[6].Value.ToString();
                    frm.txtDiem3.Text = select[0].Cells[7].Value.ToString();
                    frm.txtDiem1.Tag = sinhVien.ID;
                    frm.ShowDialog();

                }
                ShowSV_LHP(tvLopHocPhan.Tag + "");
            }
            
        }

        private void sửaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsSuaSV_Click( sender, e);
        }

        private void xóaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsXoaSV_Click(sender, e);
        }

        private void lớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tdmSVLopHocPhan_Click(sender, e);
        }

        private void thêmSinhViênLớpChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tdmSVLopChuyenNganh_Click(sender, e);
        }

        private void thêmLớpHọcPhầnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            thêmLớpHọcPhầnToolStripMenuItem_Click(sender, e);
        }

        private void sửaLớpHọcPhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sửaLớpHọcPhầnToolStripMenuItem1_Click(sender, e);
        }

        private void xóaLớpHọcPhầnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            xóaLớpHọcPhầnToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DiemDanh_Click(sender, e);
        }

        private void thêmLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsThemLopCN_Click(sender, e);
        }

        private void thêmSinhViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tdmSVLopHocPhan_Click(sender, e);
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            tsXoaSV_Click(sender, e);
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tdmSVLopChuyenNganh_Click(sender, e);
        }

        private void thêmSinhViênToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tdmSVLopHocPhan_Click(sender, e);
        }


        private void color()
        {
            int col = dgvDanhSach.Columns.Count;
            int row = this.dgvDanhSach.RowCount;
            for (int i = 0; i < row; i++)
            {
                if (dgvDanhSach.Rows[i].Cells[col - 1].Value.Equals(0))
                    dgvDanhSach.Rows[i].DefaultCellStyle.BackColor = Color.White;
                else
                if (dgvDanhSach.Rows[i].Cells[col - 1].Value.Equals(1))
                    dgvDanhSach.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                else
                {

                    if (dgvDanhSach.Rows[i].Cells[col - 1].Value.Equals(2))
                        dgvDanhSach.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    else
                    {
                        dgvDanhSach.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }

            }
        }

        private void In(int idLop)
        {
            var workbook = new XLWorkbook();
            // set author for this workbook
            workbook.Author = "sonnx.net";
            // create a sheet
            //    var worksheet = workbook.Worksheets.Add("new worksheet");
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC DanhSachThi @idLop", new object[] { idLop });
            workbook.Worksheets.Add(data, "Danh sách thi");
            //   var title  = new X
            // set value for A1 cell in this worksheet
            //worksheet.Cell("A1").Value = "This is value in A1 cell";
            // export excel file to disk
            string filePath = @"C:\Users\ADMIN\Documents\";
            DateTime dt = DateTime.Now;

            string fileName = filePath + "report" + dt.ToLongTimeString() + ".xlsx";
            workbook.SaveAs(filePath + "report.xlsx");
            // clean up
            workbook.Dispose();
            MessageBox.Show(@"Lưu  thành công: C:\Users\ADMIN\Documents\report.xlsx");
        }

        private void tsmIn_Click(object sender, EventArgs e)
        {
            TreeNode theNode = tvLopHocPhan.SelectedNode;
            if (theNode == null)
            {
                MessageBox.Show("Chưa chọn lớp học phần");
                return;
            }
            LopHpDAO dao = new LopHpDAO();
            int idLHP = dao.IDLopHP(theNode.Text);
            In(idLHP);

        }

        private void tvLopHocPhan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                tvLopHocPhan.Tag = tvLopHocPhan.SelectedNode.Text;
            }
            LoadSinhVienLHP();
        }
    }
}
