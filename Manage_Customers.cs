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
    public partial class manage_Customer : Form
    {
        CustomerInfoBL cust = null;
        private List<CustomerInfoBL> customers;
        int rwIndex = 0;
        public manage_Customer()
        {
            InitializeComponent();
        }

        private void Manage_Customers_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            customers = CustomerInfoDL.getCustomersList();
            rwIndex = -1;
            Customer.Rows.Clear();
            foreach (CustomerInfoBL cust in customers)
            {
                if (cust.getProductsList().Count>0)
                {
                    Customer.Rows.Add(cust.getName(), cust.getCustID(), cust.getProductsList().Count, cust.getFeedback().Count,cust.getCustBill(), "Select");
                }
            }
            usr_NmTXT.Text = "";
            custId_TXT.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                rwIndex = e.RowIndex;
                if (rwIndex < customers.Count && rwIndex > -1)
                {
                    usr_NmTXT.Text = customers[rwIndex].getName();
                    custId_TXT.Text = customers[rwIndex].getCustID();
                }
            }
        }
        private void usr_NmTXT_TextChanged(object sender, EventArgs e)
        {

        }
        private void custId_TXT_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdteBTN_Click(object sender, EventArgs e)
        {
            string username = usr_NmTXT.Text;
            string CustID= custId_TXT.Text;
            if (username != "" && CustID != "")
            {
                if (rwIndex > -1)
                {
                    //CustomerInfoBL cust = new CustomerInfoBL(username,CustID);
                    if (!CustomerInfoDL.checkCustomer(username,CustID))
                    {
                        cust = customers[rwIndex];
                        cust.setName(username);
                        cust.setCustID(CustID);
                        CustomerInfoDL.StoreIntoFile();
                        MessageBox.Show("Customer Updated");
                        loadData();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("You need to change the Name or Customer ID to Update");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("You need to select Customer to Update");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You cannot leave any thing Empty");
                return;
            }

        }
        private void DLTBTN_Click(object sender, EventArgs e)
        {
            string CustName = usr_NmTXT.Text;
            string CustID = custId_TXT.Text;
            if (CustName != "" && CustID != "")
            {
               // ProductBL prod = new ProductBL(CustName, CustID, Category, price, stock);
                if (CustomerInfoDL.checkCustomer(CustName, CustID))
                {
                    if (rwIndex > -1)
                    {
                        customers.RemoveAt(rwIndex);
                        CustomerInfoDL.StoreIntoFile();
                        loadData();
                        MessageBox.Show("Customer Deleted");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Customer Not Found");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You cannot leave any thing Empty");
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
    }
}
