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
    public partial class FeedBack_Form : Form
    {
        CustomerInfoBL cust = null;
        public FeedBack_Form(CustomerInfoBL cust)
        {
            InitializeComponent();
            this.cust = cust;
        }

        public FeedBack_Form()
        {
            InitializeComponent();
        }

        private void FeedBack_Form_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            string txt = fdbckTXT.Text;
            if (cust == null)
            {
                this.Hide();
                takeLoginCustomer takeSignUp = new takeLoginCustomer();
                takeSignUp.ShowDialog();
                cust = takeSignUp.getCust();
                this.Show();
            }
            cust.addinFeedbackList(txt);
            if (CustomerInfoDL.checkCustomer(cust))
            {
                CustomerInfoDL.StoreIntoFile();
            }
            else
            {
                CustomerInfoDL.addintoList(cust);
                CustomerInfoDL.storeIntoFile(cust);
            }
            this.Close();
        }
        private void fdbckTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
