using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    public class Lop
    {
        private string _IDLopCN;
        private string _TenLop;
        private string _IDNienKhoa;

        public string IDLopCN
        {
            get
            {
                return _IDLopCN;
            }

            set
            {
                _IDLopCN = value;
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
                _TenLop = value;
            }
        }

        public string IDNienKhoa
        {
            get
            {
                return _IDNienKhoa;
            }

            set
            {
                _IDNienKhoa = value;
            }
        }

        public Lop(string IDLopCN, string TenLop, string IDNienKhoa)
        {
            this.IDLopCN = IDLopCN.ToUpper();
            this.TenLop = TenLop;
            this.IDNienKhoa = IDNienKhoa.ToUpper();
        }

        public Lop()
        {
            this.IDLopCN = "";
            this.TenLop = "";
            this.IDNienKhoa = "";
        }
       
    }
}
