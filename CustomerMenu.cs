using Business_Project_GUI.BL;
using Business_Project_GUI.DL;
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
    public partial class CustomerMenu : Form
    {
        CustomerInfoBL cust=null;
        //private bool isSignedIn=false;

        public CustomerMenu()
        {
            InitializeComponent();
        }

        public CustomerMenu(CustomerInfoBL cust, bool v)
        {
            InitializeComponent();
            this.cust = cust;
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            buyProdbox.Checked = false;
            ViewpurchaseBox.Checked = false;
            feedbackBox.Checked = false;
            myCart.Checked = false;            
        }

        private void buyProdbox_CheckedChanged(object sender, EventArgs e)
        {
            ViewpurchaseBox.Checked = false;
            feedbackBox.Checked = false;
            myCart.Checked = false;
        }

        private void addtoCartBox_CheckedChanged(object sender, EventArgs e)
        {
            buyProdbox.Checked = false;
            ViewpurchaseBox.Checked = false;
            feedbackBox.Checked = false;
            myCart.Checked = false;
        }

        private void ViewpurchaseBox_CheckedChanged(object sender, EventArgs e)
        {
            buyProdbox.Checked = false;
            feedbackBox.Checked = false;
            myCart.Checked = false;
        }

        private void feedbackBox_CheckedChanged(object sender, EventArgs e)
        {
            buyProdbox.Checked = false;
            ViewpurchaseBox.Checked = false;
            myCart.Checked = false;
        }

        private void ViewChkBx_CheckedChanged(object sender, EventArgs e)
        {
            buyProdbox.Checked = false;
            ViewpurchaseBox.Checked = false;
            feedbackBox.Checked = false;
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            if (cust != null)
            {
                if (buyProdbox.Checked == true)
                {
                    buy_Product bProd = new buy_Product(cust);
                    bProd.ShowDialog();
                    buyProdbox.Checked = false;
                }
                else if (myCart.Checked == true)
                {
                    if (cust.getProductsCartList().Count > 0)
                    {
                        Carted_Form cartform = new Carted_Form(cust);
                        cartform.ShowDialog();
                    }
                    myCart.Checked = false;
                }
                else if (feedbackBox.Checked == true)
                {
                    FeedBack_Form fbackform = new FeedBack_Form(cust);
                    fbackform.ShowDialog();
                    feedbackBox.Checked = false;
                }
                else if(ViewpurchaseBox.Checked == true)
                {
                    if (cust.getProductsList().Count > 0)
                    {
                        viewPurchasedProducts viewform = new viewPurchasedProducts(cust);
                        viewform.ShowDialog();
                    }
                    ViewpurchaseBox.Checked = false;
                }
               
            }
            else
            {
                if (buyProdbox.Checked == true)
                {
                    buy_Product bProd = new buy_Product();
                    bProd.ShowDialog();
                    cust = bProd.getCust();
                    buyProdbox.Checked = false;
                }
                else if (feedbackBox.Checked == true)
                {
                    FeedBack_Form fbackform = new FeedBack_Form();
                    fbackform.ShowDialog();
                    feedbackBox.Checked = false;
                }
            }
        }
        private void AllExtBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("No " + CustomerInfoDL.getCustomersList().Count);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
