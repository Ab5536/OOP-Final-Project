using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Project_GUI. BL;
using Business_Project_GUI.DL;

namespace Business_Project_GUI
{
    public partial class buy_Product : Form
    {
        private Dictionary<int, DataGridViewCellStyle> originalRowStyles = new Dictionary<int, DataGridViewCellStyle>();
        ProductBL prod = null;
        double CalculatedBill=0;
        List<ProductBL> products;
        int RwIndx;
        CustomerInfoBL cust=null;
       // bool isSignedIn=false;
        

        public buy_Product()
        {
            InitializeComponent();
        }
        public buy_Product(CustomerInfoBL cust)
        {
            InitializeComponent();
            this.cust = cust;
        }

        public buy_Product(CustomerInfoBL cust, bool v) 
        {
            InitializeComponent();
            this.cust = cust;
          //  this.isSignedIn = v;
        }
        public CustomerInfoBL getCust()
        {
            return cust;
        }
        private void buy_Product_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            //dataGridView1.Columns
            RwIndx = -1;
            products = ProductDL.getList();
            dataGridView1.Rows.Clear();
            foreach (ProductBL prod in products)
            {
                dataGridView1.Rows.Add(prod.getProductname(), prod.getProductID(), prod.getCategory(), prod.getPrice(), prod.getStock(), "Buy");
            }
            pr_NmTXT.Text = "";
            pr_IDTXT.Text = "";           
            stckTXT.Text = "";
            categoryTXT.ReadOnly = false;
            categoryTXT.Text = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int rowIndex = row.Index;
                if (originalRowStyles.ContainsKey(rowIndex))
                {
                    row.DefaultCellStyle = originalRowStyles[rowIndex]; 
                    originalRowStyles.Remove(rowIndex); 
                }
            }
        }

        private void pr_IDTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void stckTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                categoryTXT.ReadOnly = false;
                RwIndx = e.RowIndex;
                if (RwIndx < products.Count && RwIndx > -1)
                {
                    pr_NmTXT.Text = products[RwIndx].getProductname();
                    pr_IDTXT.Text = products[RwIndx].getProductID();
                    categoryTXT.Text= products[RwIndx].getCategory();
                    categoryTXT.ReadOnly = true;
                    stckTXT.Text = "";
                }
            }
        }

        private void buy_OrderBTN_Click(object sender, EventArgs e)
        {
            string prName=pr_NmTXT.Text;
            string prID=pr_IDTXT.Text ;
            int Stock;
            if (stckTXT.Text != "")
            {
                if (ProductDL.IsInt(stckTXT.Text))
                {
                    Stock = int.Parse(stckTXT.Text);
                }
                else
                {
                    MessageBox.Show("You cannot Enter String in Int TextBox");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You cannot Leave TextBox Empty");
                return;
            }
            if (ProductDL.checkProduct(prName, prID))
            {
                prod = ProductDL.assignnewProduct(prName, prID);
                if (Stock > 0)
                {
                    prod.setStock(Stock);
                    if (ProductDL.ReduceStock(prod))
                    {
                        if (cust==null)
                        {
                            this.Hide();
                            takeLoginCustomer takeSignUp = new takeLoginCustomer();
                            takeSignUp.ShowDialog();
                            cust = takeSignUp.getCust();
                            this.Show();
                            if (cust == null)
                            {
                                return;
                            }
                        }
                        CalculatedBill = prod.calculateBill() + CalculatedBill;
                        cust.addinCustBill(CalculatedBill);
                        if (CustomerInfoDL.checkPurchasedProducts(prod, cust))
                        {
                            CustomerInfoDL.changePurchasedStock(prod, cust);
                        }
                        else
                        {
                            cust.addinProductList(prod);
                        }
                        ProductDL.StoreintoFile();
                        if (CustomerInfoDL.checkCustomer(cust))
                        {
                            CustomerInfoDL.StoreIntoFile();
                        }
                        else
                        {
                            CustomerInfoDL.addintoList(cust);
                            CustomerInfoDL.storeIntoFile(cust);
                        }
                        MessageBox.Show("Bill: " + CalculatedBill);
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

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pr_NmTXT_TextChanged(object sender, EventArgs e)
        {
        }

        private void cartBTN_Click(object sender, EventArgs e)
        {
            string prName = pr_NmTXT.Text;
            string prID = pr_IDTXT.Text;
            int Stock;
            if (stckTXT.Text != "")
            {
                if (ProductDL.IsInt(stckTXT.Text))
                {
                    Stock = int.Parse(stckTXT.Text);
                }
                else
                {
                    MessageBox.Show("You cannot Enter String in Int TextBox");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You cannot Leave TextBox Empty");
                return;
            }
            if (ProductDL.checkProduct(prName, prID))
            {
                prod = ProductDL.assignnewProduct(prName, prID);
                if (Stock > 0)
                {
                    prod.setStock(Stock);
                    if (ProductDL.CheckStock(prod))
                    {
                        if (cust == null)
                        {
                            this.Hide();
                            takeLoginCustomer takeSignUp = new takeLoginCustomer();
                            takeSignUp.ShowDialog();
                            cust = takeSignUp.getCust();
                            this.Show();
                        }
                        if (CustomerInfoDL.checkPurchasedCartProducts(cust, prName))
                        {
                            CustomerInfoDL.changeCartedStock(prod.getStock(), prName);
                        }
                        else
                        {
                            cust.addinCartList(prod);
                        }
                        if (CustomerInfoDL.checkCustomer(cust))
                        {
                            CustomerInfoDL.StoreIntoFile();
                        }
                        else
                        {
                            CustomerInfoDL.addintoList(cust);
                            CustomerInfoDL.storeIntoFile(cust);
                        }
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

        private void SrchBTN_Click(object sender, EventArgs e)
        {
            int x = 0;
            string productName = srchTXT.Text;
            string productID = prIDTXT.Text;
            if (productName != ""&& productID != "")
            {
                if (ProductDL.checkProduct(productName, productID))
                {
                    foreach (ProductBL prod in products)
                    {
                        if (prod.getProductname() == productName && prod.getProductID() == productID)
                        {
                            srchTXT.Text = "";
                            prIDTXT.Text = "";
                            loadData();
                            HighlightRow(x);
                        }
                        x++;
                    }
                }
                else
                {
                    MessageBox.Show("Product does not Exist");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Box cannot be Empty");
                return;
            }
        }
        private void removeHighLight()
        {

        }
        private void HighlightRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.DefaultCellStyle.BackColor = Color.Red;
               // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            }
        }
        private void srchTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void prIDTXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
