using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    class HocPhan
    {
        private int _id;
        private String _TenHocPhan;
        private int _SoDVHT;
        public HocPhan()
        {

        }

        public HocPhan(int _id, String _TenHocPhan, int _SoDVHT)
        {
            this._id = _id;
            this._TenHocPhan = _TenHocPhan;
            this._SoDVHT = _SoDVHT;
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string TenHocPhan
        {
            get
            {
                return _TenHocPhan;
            }

            set
            {
                _TenHocPhan = value;
            }
        }

        public int SoDVHT
        {
            get
            {
                return _SoDVHT;
            }

            set
            {
                _SoDVHT = value;
            }
        }
    }
}
