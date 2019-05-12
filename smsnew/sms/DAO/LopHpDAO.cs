using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sms.DAO;
using sms.Entities;
using sms.DTO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sms.DAO
{
    class LopHpDAO
    {
        private MyDBContext db;
        public LopHpDAO()
        {
            db = new MyDBContext();
        }
        public List<LopHocPhan> GetAll()
        {
            var lst = db.LopHocPhans.ToList();
            return lst;
        }
        public List<Ten> GetHocPhan_Tens()
        {
            var lst = from p in db.HocPhans select new Ten { TenHp = p.TenHocPhan };
            return lst.ToList();
        }
        //lay id học phần theo tên 
        public int GetIDHocPhan(string tenhp)
        {
            var lst = db.HocPhans.SqlQuery("select * from HocPhan where TenHocPhan=@ten", new SqlParameter("ten", tenhp)).ToList();
            int id = lst[0].ID;
            return id;
        }
        // lay colum tên lớp học phần
        public List<Ten> GetTen()
        {
            var lst = from p in db.LopHocPhans select new Ten { TenHp = p.TenLopHocPhan };
            return lst.ToList();
        }
        // lay ra lớp học phần theo id học kỳ
        public List<Ten> GetLopHP_hk( string tenhk, string code)
        {
            HocKyDAO hocKyDAO = new HocKyDAO();
            int id = hocKyDAO.GetIDHocKY(tenhk, code);
            var lst = from p in db.LopHocPhans where p.HocKyID == id select new Ten { TenHp = p.TenLopHocPhan };
            return lst.ToList();

        }
        public int IDLopHP( string TenLHP)
        {
            var lst = db.LopHocPhans.SqlQuery("select * from LopHocPhan where TenLopHocPhan=@tenLHP ", new SqlParameter("tenLHP",TenLHP)).ToList();
            int id = lst[0].ID;
            return id;
        }

        public int Insert( LopHocPhan lopHocPhan)
        {
            int ret = 0;
            try
            {
                db.LopHocPhans.Add(lopHocPhan);
                db.SaveChanges();
                ret = 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo");
                ret = -1;
            }
            return ret;
        }

        public int Update(LopHocPhan  lop)
        {
            int ret = 0;
            try
            {
                LopHocPhan lopHocPhan = db.LopHocPhans.Find(lop.ID);
                lopHocPhan.HocPhanID = lop.HocPhanID;
                lopHocPhan.IDView = lop.IDView;
                db.SaveChanges();
                ret = 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo");
                ret = -1;
            }
            return ret;
        }

        public int Delete(LopHocPhan lopHocPhan)
        {
            int ret = 0;
            try
            {
                db.LopHocPhans.Remove(db.LopHocPhans.Find(lopHocPhan.ID));
                db.SaveChanges();
                ret = 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Bạn chưa chọn học kỳ cần sửa", "Thông báo");
                ret = -1;
            }
            return ret;
        }

    }
}
