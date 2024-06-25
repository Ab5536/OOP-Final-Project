using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Project_GUI.DL;
using Business_Project_GUI.BL;


namespace Business_Project_GUI
{
    public partial class Manage_Employee : Form
    {
        int rwIndex;
       List<LoginBL> logins;
        public Manage_Employee()
        {
            InitializeComponent();
        }

        private void Manage_Employee_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            RoleTXT.Text = "Employee";
            RoleTXT.ReadOnly = true;
            logins = LoginDL.getList();
            rwIndex = -1;
            dataGridView1.Rows.Clear();
            foreach (LoginBL log in logins)
            {
                if (log.getRole() == "Employee"|| log.getRole() == "employee")
                {
                    dataGridView1.Rows.Add(log.getUsername(), log.getPassword(), log.getRole(), "Select");
                }
              
            }
            usr_NmTXT.Text = "";
            password_TXT.Text = "";
        }
        private void usr_NmTXT_TextChanged(object sender, EventArgs e)
        {
        }

        private void stckTXT_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void UpdteBTN_Click(object sender, EventArgs e)
        {
            string username = usr_NmTXT.Text;
            string password = password_TXT.Text;
            string role = RoleTXT.Text;
            if (username != "" && password != "" )
            {
                if (rwIndex != -1)
                {
                    LoginBL login = new EmployeeBL(username, password, role);
                    if (!LoginDL.checkUser(login))
                    {
                        //MessageBox.Show(" " + rwIndex);
                        login = LoginDL.getoneLoginList(rwIndex);
                        login.setUsername(username);
                        login.setPassword(password);
                        login.setRole(role);
                        LoginDL.StoreintoFile();
                        MessageBox.Show("Employee Updated");
                        loadData();
                        return;
                    }
                    else
                    {
                         MessageBox.Show("You need to change the username or password to Update");
                         return;
                    }
                }
                else
                {
                    MessageBox.Show("You need to select Employee to Update");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You cannot leave any thing Empty");
                return;
            }
        }

        private void insrtBTN_Click(object sender, EventArgs e)
        {

            string username=usr_NmTXT.Text; 
            string password=password_TXT.Text;
            string role=RoleTXT.Text;

            if (username != "" & password != "")
            {
                LoginBL login = new EmployeeBL(username,password,role);
                if (!LoginDL.checkUser(login))
                {
                    LoginDL.addintoList(login);
                    LoginDL.storeintoFile(login);
                    MessageBox.Show("Employee Added");
                    loadData();
                    return;
                }
                else
                {
                    MessageBox.Show("Username or password Exist Already");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You cannot leave any thing Empty");
                return;
            }
        }

        private void dltBTN_Click(object sender, EventArgs e)
        {
            string username = usr_NmTXT.Text;
            string password = password_TXT.Text;
            string role = RoleTXT.Text;

            if (username != "" && password != "")
            {
                if (rwIndex != -1)
                {
                    LoginBL login = new EmployeeBL(username, password, role);
                    if (LoginDL.checkUser(login))
                    {
                        LoginDL.RemovefromList(rwIndex);
                        LoginDL.StoreintoFile();
                        loadData();
                        MessageBox.Show("Employee Deleted");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Username or password does not Exist");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Select Employee to Delete");
                    return;
                }
              
            }
            else
            {
                MessageBox.Show("You cannot leave any thing Empty");
                return;
            }
        }
        public void loadinGrid()
        {
            if (rwIndex < logins.Count && rwIndex > -1)
            {
                usr_NmTXT.Text = logins[rwIndex].getUsername();
                password_TXT.Text = logins[rwIndex].getPassword();
                RoleTXT.Text = logins[rwIndex].getRole();
            }
            else
            {
                MessageBox.Show("No Data");
                return;
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                rwIndex = e.RowIndex+1;
                loadinGrid();
            }
        }

        private void SrchBTN_Click(object sender, EventArgs e)
        {
            string employeeName = srchTXT.Text;
            string employeePass = srchPassTXT.Text;
            string role = "Employee";
            if (employeeName != ""&&employeePass != "")
            {
                LoginBL log = new EmployeeBL(employeeName, employeePass,role);
                int index = LoginDL.indexofUser(log);
                rwIndex = index;
                loadinGrid();
               // rwIndex = -1;
                return;
                // log = LoginDL.returnUser(index);
            }
            else
            {
                MessageBox.Show("UserNameBox should not be Empty");
                return;
            }
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void extBTN_Click(object sender, EventArgs e)
        {   
            Environment.Exit(0);
        }

        private void srchTXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
