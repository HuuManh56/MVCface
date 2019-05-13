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
            foreach( Ten item in lis)
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
            ShowLopHP();
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
            
            if( cmbHocKY.SelectedIndex<0 && cmbNamHK.SelectedIndex<0)
            {
                MessageBox.Show(" ban chua chon nam hoc va hoc ky");
                
            }
            else
            {
                frmLopHP_Them frm = new frmLopHP_Them();
                frm.txtHocKy.Text= cmbHocKY.Text+"";
                frm.txtNamHK.Text= cmbNamHK.Text;
                frm.ShowDialog();
               

                
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
            if( tvLopHocPhan.SelectedNode.Index <0 || cmbNamHK.SelectedIndex < 0)
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
               
                frm.txtTenLopHP.Text =a;
                frm.cmbHP.Text = b[0];
                frm.txtMaLopHP.Text = b[1];
                frm.txtTenLopHP.Tag = a;
                frm.ShowDialog();

                LoadLHP_HK();
            }
        }

        private void tvLopHocPhan_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvLopHocPhan.SelectedNode = e.Node;
        }

        private void tvLopHocPhan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node != null)
            {
                tvLopHocPhan.Tag = tvLopHocPhan.SelectedNode.Text;
            }
        }

        private void xóaLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (cmbHocKY.SelectedIndex < 0 && cmbNamHK.SelectedIndex < 0)
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
            var lst =dao.GetAll2();
            foreach (NienKhoaVM item in lst)
            {
                ComboboxItem a = new ComboboxItem();
                a.Text = item.idview;
                a.Value = item.id;
                cmbKhoa.Items.Add(a);
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            tvLopChuyenNganh.Nodes.Clear();
            ComboboxItem select = (ComboboxItem)cmbKhoa.SelectedItem;
            LoadLopChuyenNganh(select.Value);
        }

        private void LoadLopChuyenNganh(int NienKhoaId)
        {
            
            LopDAO dao = new LopDAO();
            List<Lop> list = dao.GetByNienKhoa(NienKhoaId);
            tvLopHocPhan.Nodes.Clear();
            foreach (Lop item in list)
            {
                string a = item.TenLop;
                tvLopChuyenNganh.Nodes.Add(a);
            }
        }
    }
}
