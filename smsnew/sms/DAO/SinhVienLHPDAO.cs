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

        public List<SV_LHP> litSV_LHP( int id)
        {
            var lst = db.SV_LHP.SqlQuery("  select * from SV_LHP where LopHocPhanID = " + id).ToList();
            return lst;
        }
        public int GetID( int idsv, int idlhp)
        {
            var lst = db.SV_LHP.SqlQuery(" select * from SV_LHP where SinhVienID = " + idsv +" and LopHocPhanID = "+ idlhp).ToList();
            return lst[0].ID;
        }
    }
}
