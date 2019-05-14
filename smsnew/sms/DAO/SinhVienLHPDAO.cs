using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sms.Entities;

namespace sms.DAO
{
    class SinhVienLHPDAO
    {
        private MyDBContext db;

        public SinhVienLHPDAO()
        {
            db = new MyDBContext();
        }

        public int Insert(SV_LHP svLhp)
        {
            db.SV_LHP.Add(svLhp);
            return db.SaveChanges();
        }

       
    }
}
