using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Project_GUI.BL
{
    class EmployeeBL:LoginBL
    {
        public EmployeeBL(string username, string password, string role) : base(username, password, role)
        {
        }
        public EmployeeBL()
        {

        }
        public EmployeeBL(string username, string password) : base(username, password)
        {

        }
    }
}
