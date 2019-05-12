using sms.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms.DAO
{
    class HocPhanDAO
    {
        private MyDBContext db;
        public HocPhanDAO()
        {
            db = new MyDBContext();
        }
        public List<HocPhan> GetALL()
        {
            var lst = db.HocPhans.ToList();
            return lst;
        }
        public int Insert(HocPhan hocPhan)
        {
            int ret = 0;
            try
            {
                db.HocPhans.Add(hocPhan);
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

        public int Update(HocPhan hocPhan)
        {
            int ret = 0;
            try
            {
                HocPhan hoc = db.HocPhans.Find(hocPhan.ID);
                hoc.TenHocPhan = hocPhan.TenHocPhan;
                hoc.SoDVHT = hocPhan.SoDVHT;
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

        public int Delete(HocPhan hoc)
        {
            int ret = 0;
            try
            {
                db.HocPhans.Remove(db.HocPhans.Find(hoc.ID));
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
