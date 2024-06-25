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
    public partial class Carted_Form : Form
    {
        int RwIndx = 0;
        double CalculatedBill = 0;
        CustomerInfoBL cust = null;
        List<ProductBL> products = null;
        ProductBL prod = null;
        public Carted_Form()
        {
            InitializeComponent();
        }
        public Carted_Form(CustomerInfoBL cust)
        {
            InitializeComponent();
            this.cust = cust;
           // MessageBox.Show("In constructor of Cart"+cust.getProductsCartList().Count);
        }

        private void Carted_Form_Load(object sender, EventArgs e)
        {
            loadData();
        }
        
        private void loadData()
        {
            RwIndx = -1;
            products = cust.getProductsCartList();
            prdctGrid.Rows.Clear();
            foreach (ProductBL prod in products)
            {
                prdctGrid.Rows.Add(prod.getProductname(), prod.getProductID(), prod.getCategory(), prod.getPrice(), prod.getStock(), "Select");
            }
            pr_NmTXT.Text = "";
            pr_IDTXT.Text = "";
            stckTXT.Text = "";
            categoryTXT.Text = "";
            categoryTXT.ReadOnly = true;
            pr_IDTXT.ReadOnly = true;
            pr_NmTXT.ReadOnly = true;
            stckTXT.ReadOnly = true;

        }

        private void buy_OrderBTN_Click(object sender, EventArgs e)
        {
            string prName = pr_NmTXT.Text;
            string prID = pr_IDTXT.Text;
            int Stock=int.Parse(stckTXT.Text);
            if (ProductDL.checkProduct(prName, prID))
            {
                prod = ProductDL.assignnewProduct(prName, prID);
                if (Stock > 0)
                {
                    prod.setStock(Stock);
                    if (ProductDL.ReduceStock(prod))
                    {
                        CalculatedBill = prod.calculateBill() + CalculatedBill;
                        if (CustomerInfoDL.checkPurchasedProducts(prod, cust))
                        {
                            CustomerInfoDL.changePurchasedStock(prod, cust);
                        }
                        else
                        {
                            cust.addinProductList(prod);
                        }
                        MessageBox.Show("Bill: " + CalculatedBill);
                        cust.addinCustBill(CalculatedBill);
                        ProductDL.StoreintoFile();
                        int x = CustomerInfoDL.findProductCustomer(cust.getProductsCartList(),prod); 
                        products.RemoveAt(x);
                        CustomerInfoDL.StoreIntoFile();
                        loadData();
                    }
                }
                else
                {
                    MessageBox.Show("Enter Stock greater than zero ");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Select from Given Products");
                loadData();
                return;
            }
        }

        private void pr_NmTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void prdctGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                categoryTXT.ReadOnly = false;
                pr_IDTXT.ReadOnly = false;
                stckTXT.ReadOnly = false;
                categoryTXT.ReadOnly = false;
                RwIndx = e.RowIndex;
                if (RwIndx < products.Count && RwIndx > -1)
                {
                    pr_NmTXT.Text = products[RwIndx].getProductname();
                    pr_IDTXT.Text = products[RwIndx].getProductID();
                    categoryTXT.Text = products[RwIndx].getCategory();
                    stckTXT.Text = products[RwIndx].getStock().ToString();
                    categoryTXT.ReadOnly = true;
                    pr_IDTXT.ReadOnly = true;
                    pr_NmTXT.ReadOnly = true;
                    stckTXT.ReadOnly = true;
                }
            }
        }

        private void cartBTN_Click(object sender, EventArgs e)
        {
            string prName = pr_NmTXT.Text;
            string prID = pr_IDTXT.Text;
            int Stock = int.Parse(stckTXT.Text);
            if (ProductDL.checkProduct(prName, prID))
            {
                prod = ProductDL.assignnewProduct(prName, prID);
                int x = CustomerInfoDL.findProductCustomer(cust.getProductsCartList(), prod);
                products.RemoveAt(x);
                CustomerInfoDL.StoreIntoFile();
            }
        }
    }
}
