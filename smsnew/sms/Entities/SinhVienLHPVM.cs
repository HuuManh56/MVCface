using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.Entities
{
    class SinhVienLHPVM
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public double Diem1 { get; set; }
        public double Diem2 { get; set; }
        public double Diem3 { get; set; }
        public int SoBuoiNghi { get; set; }
    }
}
