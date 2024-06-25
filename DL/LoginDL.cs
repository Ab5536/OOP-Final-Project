using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Project_GUI.DL;
using Business_Project_GUI.BL;
using System.Windows.Forms;

namespace Business_Project_GUI.DL
{
    class LoginDL
    {
        private static List<LoginBL> logins = new List<LoginBL>();
        public static List<LoginBL> getLoginList()
        {
            return logins;
        }
        public static LoginBL getoneLoginList(int x)
        {
            return logins[x];
        }

        public static void addintoList(LoginBL user)
        {
            logins.Add(user);
        }
        public static bool checkAdmin()
        {
            if (logins.Count == 0)
            {
                return true;
            }
            return false;
        }
        public static List<LoginBL> getList()
        {
            return logins;
        }
        public static int indexofUser(LoginBL user)
        {
            bool flag = false;
            int x = 0;
            foreach (LoginBL log in logins)
            {
                if ((log.getPassword() == user.getPassword()) && (log.getUsername() == user.getUsername()&&log.getRole()==user.getRole()))
                {
                    flag = true;
                    break;
                }
                x++;
            }
            if (flag == true)
            {
                return x;
                //return "Signed In Succesfully as " + used.getRole();
            }
            else
            {
                return -1;
                //    return "user not found ";
            }

        }
        public static bool checkUser(LoginBL user)
        {
            bool flag = false;
            foreach (LoginBL log in logins)
            {
                if ((log.getPassword() == user.getPassword()) && (log.getUsername() == user.getUsername()))
                {
                    return true;
                }
            }
            return flag;
        }

        public static LoginBL returnUser(int index)
        {            
            return logins[index];
        }

        public static void storeintoFile(LoginBL user)
        {
            string path = "Login.txt";
            StreamWriter filevar = new StreamWriter(path, true);
            filevar.Write("{0},{1},{2}\n", user.getUsername(), user.getPassword(), user.getRole());
            filevar.Flush();
            filevar.Close();
        }
        public static bool readfromFile(string path)
        {
            StreamReader filevar = new StreamReader(path);
            string text;
            string username = null;
            string password = null;
            string role = null;
            if (File.Exists(path))
            {
                while ((text = filevar.ReadLine()) != null)
                {
                    string[] texted = text.Split(',');
                    if (texted.Length == 3)
                    {
                        username = texted[0];
                        password = texted[1];
                        role = texted[2];
                    }
                    LoginBL newuser = checkRole(username, password, role, 1);
                    if (newuser != null)
                        if (!checkUser(newuser))
                        {
                            addintoList(newuser);
                        }

                }
                filevar.Close();
                return true;
            }
            return false;

        }
        public static LoginBL checkRole(string username, string password, string role, int num)
        {
            if (num == 1)
            {
                if (role == "Admin" || role == "admin")
                {
                  //  MessageBox.Show(" Admin ");
                    LoginBL user = new AdminBL(username, password, role);
                    return user;
                }
            }
            if (role == "Employee" || role == "employee")
            {
               // MessageBox.Show(" Employee ");
                LoginBL user = new EmployeeBL(username, password, role);
                return user;
            }
            return null;
        }

        internal static void RemovefromList(int x)
        {
            logins.RemoveAt(x);
        }

      /*
        internal static void removeEmployee(LoginBL emp)
        {
            int x = 0;
            foreach (LoginBL log in logins)
            {
                if (x > 0)
                {
                    if (log.getUsername() == emp.getUsername() && log.getPassword() == log.getPassword())
                    {
                        break;
                    }
                }
                x++;
            }
            logins.RemoveAt(x);
        }
      */
        internal static bool EmployeeExist(LoginBL emp)
        {
            int x = 0;
            foreach (LoginBL log in logins)
            {
                if (x > 0)
                {
                    if (log.getUsername() == emp.getUsername() && log.getPassword() == log.getPassword() && log.getRole() == emp.getRole())
                    {
                        return true;
                    }
                }
                x++;
            }
            return false;
        }

        internal static void StoreintoFile()
        {
            string path = "Login.txt";
            StreamWriter filevar = new StreamWriter(path);
            foreach (LoginBL log in logins)
            {
                filevar.Write("{0},{1},{2}\n", log.getUsername(), log.getPassword(), log.getRole());

            }
            filevar.Flush();
            filevar.Close();
        }
    }
}
