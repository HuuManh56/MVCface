using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Database;
using StudentManagementSystem.Model;

namespace StudentManagementSystem.Controller
{
    class UserController
    {
        private  ConnectDB connect = new ConnectDB();

        public  int Login(User user)
        {
            int ret=0;
            String sql = "select * from [dbo].[user] where username=N'" + user.Username +
                "' and password=N'" + user.Password + "'";

            DataTable tb= connect.getTable(sql);
            if (tb.Rows.Count == 1)
            {
                //Dang nhap thanh cong
                ret = 1;
            }
            else
            {
                ret = -1;
            }
            return ret;
        }
    }
}
