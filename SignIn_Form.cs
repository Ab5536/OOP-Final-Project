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
    public partial class SignIn_Form : Form
    {
        public SignIn_Form()
        {
            InitializeComponent();
        }
        private void cleardatafromForm()
        {
            usernameTxt.Text = "";
            passwordTxt.Text = "";
        }

        private void SignIn_Form_Load(object sender, EventArgs e)
        {
            adminRole.Checked = false;
            employeeRole.Checked = false;
            cleardatafromForm();
        }

        private void head_Click(object sender, EventArgs e)
        {

        }

        private void Signinbtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string role = "";
            if (username != "" && password != "")
            {
                if (adminRole.Checked == true)
                {
                    role = "Admin";
                }
                else if (employeeRole.Checked == true)
                {
                    role = "Employee";
                }
                LoginBL user = LoginDL.checkRole(username, password, role, 1);
                if (user != null)
                {
                    int index = LoginDL.indexofUser(user);
                    if (index != -1)
                    {
                        user = LoginDL.returnUser(index);
                        if (user.getRole() == "Admin")
                        {
                            AdminMenu oneAdmin = new AdminMenu();
                            oneAdmin.Show();
                            adminRole.Checked = false;
                            this.Close();
                            return;
                        }
                        else if (user.getRole() == "Employee")
                        {
                            Employee_Menu empmenu = new Employee_Menu();
                            empmenu.Show();
                            employeeRole.Checked = false;
                            this.Close();
                            return;
                        }
                    }
                }          
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Program.firstForm.Show();
            this.Close();
        }

        private void adminRole_CheckedChanged(object sender, EventArgs e)
        {
            employeeRole.Checked = false;
          
        }
        private void employeeRole_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeRole.Checked == true)
            {
                adminRole.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
