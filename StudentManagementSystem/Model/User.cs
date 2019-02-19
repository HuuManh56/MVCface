using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    class User
    {
        private int _id;
        private String _username;
        private String _password;

        public int ID { get; set; }
        public String Username { get; set; }

        public String Password { get; set; }
        public User()
        {
            this._id = 0;
            this._username = "";
            this._password = "";
        }
        public User(int _id, String _username, String _password)
        {
            this._id = _id;
            this._username = _username;
            this._password = _password;
        }

    }
}
