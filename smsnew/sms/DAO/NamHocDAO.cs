using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sms.Entities;

namespace sms.DAO
{

    class NamHocDAO
    {
        private MyDBContext db;
        public NamHocDAO()
        {
            db = new MyDBContext();
        }

        public List<NamHoc> GetNamHoc()
        {
            var lis = db.NamHocs.ToList();
            return lis;
        }

        public int Insert(NamHoc nam)
        {
            int ret = 0;
            try
            {
                db.NamHocs.Add(nam);
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

        public int Update(NamHoc nam)
        {
            int ret = 0;
            try
            {
                NamHoc namHoc = db.NamHocs.Find(nam.ID);
                namHoc.BatDau = nam.BatDau;
                namHoc.KetThuc = nam.KetThuc;
                namHoc.Code = nam.Code;

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

        public int Delete(NamHoc nam)
        {
            int ret = 0;
            try
            {
                db.NamHocs.Remove(db.NamHocs.Find(nam.ID));
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
    }
}
