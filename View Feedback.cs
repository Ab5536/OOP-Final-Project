using Business_Project_GUI.DL;
using Business_Project_GUI.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Project_GUI
{
    public partial class view_FeedBack : Form
    {
        CustomerInfoBL cust = null;
        List<string> Feedbacks=null;
        public view_FeedBack()
        {
            InitializeComponent();
            richTextBox1.Text = "";
        }

        private void View_Feedback_Load(object sender, EventArgs e)
        {
          
        }

        private void cust_ID_LBL_Click(object sender, EventArgs e)
        {

        }

        private void usr_NmTXT_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void viewBTN_Click(object sender, EventArgs e)
        {
            string username = usr_NmTXT.Text;
            string CustID = custId_TXT.Text;
            if (username != "" && CustID != "")
            {
                cust = new CustomerInfoBL(username, CustID);
                  if (CustomerInfoDL.checkCustomer(cust))
                  {
                    cust = CustomerInfoDL.assignCustomer(cust);
                    Feedbacks = cust.getFeedback();
                    foreach(string f in Feedbacks)
                    {
                        richTextBox1.Text = richTextBox1.Text + f + "\n\n\n";
                    }
                  }
                usr_NmTXT.Text="";
                custId_TXT.Text="";
            }
            else
            {
                MessageBox.Show("You cannot leave any thing Empty");
                return;
            }
        }

        private void custId_TXT_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
