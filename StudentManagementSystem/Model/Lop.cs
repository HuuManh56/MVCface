using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    class Lop
    {
        private int _id;
        private String _TenLop;
        private string _CodeView;
        private int _NienKhoaID;
        public Lop()
        {

        }

        public Lop(int _id, String _TenLop, String _CodeView, int _NienKhoaID)
        {
            this._id = _id;
            this._TenLop = _TenLop;
            this._CodeView = _CodeView;
            this._NienKhoaID = _NienKhoaID;
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

        public string CodeView
        {
            get
            {
                return _CodeView;
            }

            set
            {
                _CodeView = value;
            }
        }
        public int NienKhoaID
        {
            get
            {
                return _NienKhoaID;
            }

            set
            {
                _NienKhoaID = value;
            }
        }
    }
}
