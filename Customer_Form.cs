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
    public partial class Customer_Form : Form
    {
        CustomerInfoBL cust=null;
        public Customer_Form()
        {
            InitializeComponent();
        }

        private void signinCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (signinCustomer.Checked == true)
            {
                signUpCustomer.Checked = false;
                continuewithoutLogin.Checked = false;
            }
        }

        private void signUpCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (signUpCustomer.Checked == true)
            {
                signinCustomer.Checked = false;
                continuewithoutLogin.Checked = false;
            }
        }

        private void continuewithoutLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (continuewithoutLogin.Checked == true)
            {
                signUpCustomer.Checked = false;
                signinCustomer.Checked = false;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {   
            if (signinCustomer.Checked == true)
            {
                takeLoginCustomer takesignIn = new takeLoginCustomer(true);
                takesignIn.ShowDialog();
                cust = takesignIn.getCust();
                if (cust == null)
                {
                    return;
                }
                CustomerMenu custmenu = new CustomerMenu(cust,true);
                custmenu.Show();
                signinCustomer.Checked = false;
            }
            else if (signUpCustomer.Checked == true)
            {
                takeLoginCustomer takeSignUp = new takeLoginCustomer();
                takeSignUp.ShowDialog();
                cust = takeSignUp.getCust();
                if (cust == null)
                {
                    return;
                }
                CustomerMenu custmenu = new CustomerMenu(cust,false);
                custmenu.Show();
                signUpCustomer.Checked = false;
            }
            else if (continuewithoutLogin.Checked == true)
            {
                CustomerMenu Amenu = new CustomerMenu();
                Amenu.Show();
                continuewithoutLogin.Checked = false;
            }
           
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
            signUpCustomer.Checked = false;
            signinCustomer.Checked = false;
            continuewithoutLogin.Checked = false;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Program.firstForm.Show();
            this.Close();
        }

        private void sideMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
