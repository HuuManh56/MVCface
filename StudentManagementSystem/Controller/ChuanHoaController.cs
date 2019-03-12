using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Controller
{
    public class ChuanHoaController
    {
        public int ChuanHoa( string ID, string Name)
        {
            if (ID.Length == 8 && Name !=null)
            {
                //Viet hoa ID 
                ID = ID.ToUpper();
                //Chuan hoa Name
                Name=Name.Trim();
                

                return 1;
            }
            else
            {
                MessageBox.Show("ID nhap phai co do dai bang 8 va ten khong duoc de trong");
                return 0;
            }
        }
    }
}
