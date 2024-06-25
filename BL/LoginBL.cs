using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Project_GUI.BL
{
    class LoginBL
    {
        protected string username;
        protected string password;
        protected string role;
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setRole(string role)
        {
            this.role = role;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
        public string getUsername()
        {
            return username;
        }
        public string getRole()
        {
            return role;
        }
        public LoginBL()
        {

        }
        public LoginBL(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public LoginBL(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
