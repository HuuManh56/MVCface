using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    class Lop
    {
        private string _IDLopCN;

        private String _TenLop;
        private string _IDNienKHoa;
        public Lop(string IDLopCN, string TenLop, string IDNienKhoa)
        {
            this._IDLopCN = IDLopCN;
            this._TenLop = TenLop;
            this._IDNienKHoa = IDNienKhoa;
        }

        public Lop()
        {
           
        }
        public string IDLopCN
        {
            get
            {
                return _IDLopCN;
            }
            set
            {
                value = _IDLopCN;
            }
        }
        public string TenLop
        {
            get
            {
                return _TenLop;
            }
            set
            {
                value = _TenLop;
            }
        }
        public string IDNienKhoa
        {
            get
            {
                return _IDNienKHoa;
            }
            set
            {
                value = _IDNienKHoa;
            }
        }
    }
}
