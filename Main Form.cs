using System;
using EZInput;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Project_GUI.DL;
using Business_Project_GUI.BL;

namespace Business_Project_GUI
{
    public partial class mainForm : Form
    {
        readonly string productPath = "Product.txt";
        readonly string loginPath = "Login.txt";
        public mainForm()
        {
            InitializeComponent();
            
            if (!File.Exists(loginPath))
            {
                FileStream fs = File.Create(loginPath);
                fs.Close();
            }
            if (!File.Exists(productPath))
            {
                FileStream fs = File.Create(productPath);
                fs.Close();
            }
            ProductDL.readfromFile(productPath);
          /*  if (!File.Exists(""))
            {
                FileStream fs = File.Create();
                fs.Close();
            }*/
            CustomerInfoDL.readfromFile();
            //MessageBox.Show("No " + CustomerInfoDL.getCustomersList().Count);
            if (LoginDL.readfromFile(loginPath))
            {
                if (LoginDL.checkAdmin())
                {
                    LoginBL admin = new AdminBL("Abdullah Zahid", "AN87", "Admin");
                    LoginDL.addintoList(admin);
                    LoginDL.storeintoFile(admin);
                }
               // MessageBox.Show("Data Loaded From the File");
            }
            else
            {
               // MessageBox.Show("Data not Loaded");
            }
        }


        private void signinUser_CheckedChanged(object sender, EventArgs e)
        {
            if (signinUser.Checked == true)
            {
                Help.Checked = false;
                customer.Checked = false;
            }
        }

        private void customer_CheckedChanged(object sender, EventArgs e)
        {
            if (customer.Checked == true)
            {
                Help.Checked = false;
                signinUser.Checked = false;

            }
        }

        private void Help_CheckedChanged(object sender, EventArgs e)
        {
            if (Help.Checked == true)
            {
                customer.Checked = false;
                signinUser.Checked = false;
            }
        }

     

        private void mainForm_Load(object sender, EventArgs e)
        {
            Help.Checked = false;
            customer.Checked = false;
            signinUser.Checked = false;
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            
            if (Help.Checked == true)
            {
               
            }
            
            else if (signinUser.Checked == true)
            {           
                SignIn_Form oneform = new SignIn_Form();
                oneform.Show();
                signinUser.Checked = false;
                this.Hide();
            }
            else if (customer.Checked == true)
            {
                Customer_Form cust = new Customer_Form();
                cust.Show();
                customer.Checked = false;
                this.Hide();
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            buy_Product buy = new buy_Product();
            buy.Show();
        }
    }
}
