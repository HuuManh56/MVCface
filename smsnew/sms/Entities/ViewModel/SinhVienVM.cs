using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.Entities.ViewModel
{
    class SinhVienVM
    {
        public int ID;
        public byte[] image { get; set; }
        public string HoTen { get; set; }
        public int GioiTinh { get; set; }
        public int LopID { get; set; }
        public DateTime NgaySinh { get; set; }
    }
}
