using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Project_GUI.BL;
using Business_Project_GUI.DL;

namespace Business_Project_GUI
{
    public partial class takeLoginCustomer : Form
    {
        private bool isSignedIn=false;
        int type=0;
        public CustomerInfoBL cust;
        public takeLoginCustomer()
        {
            InitializeComponent();
        }
        public takeLoginCustomer(int type)
        {
            InitializeComponent();
            this.type = type;
        }

        public takeLoginCustomer(bool runtime)
        {
            InitializeComponent();
            this.isSignedIn = runtime;
        }

        private void takeSignUpCustomer_Load(object sender, EventArgs e)
        {
            if (isSignedIn == true)
            {
                Signupbtn.Text = "S I G N I N";
            }
            nameTxt.Text="";
            custIDTxt.Text = "";
        }
        public CustomerInfoBL getCust()
        {
            return cust;
        }
        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void custIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            if (isSignedIn == false)
            {
                string Name = nameTxt.Text;
                string custID = custIDTxt.Text;
                if (!CustomerInfoDL.checkCustomer(Name,custID))
                {
                    cust = new CustomerInfoBL(Name, custID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Customer ID already Present");
                    return;
                }
            }
            else
            {
                string name = nameTxt.Text;
                string custID = custIDTxt.Text;
                if (name != "" || custID != "")
                {
                    CustomerInfoBL custo = new CustomerInfoBL(name, custID);
                    if (CustomerInfoDL.checkCustomer(custo))
                    {
                        cust = CustomerInfoDL.assignCustomer(custo);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Results didn't Match");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
            }
            
        }

        private void TOPpIC_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

