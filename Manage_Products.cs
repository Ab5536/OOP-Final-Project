using System;
using System.IO;
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
    public partial class Manage_Products : Form
    {
        readonly string productPath = @"E:\2nd Semester\OOP\Product.txt";
        List<ProductBL> products = ProductDL.getList();
        int RwIndx ;
        public Manage_Products()
        {
            InitializeComponent();
            if (!File.Exists(productPath))
            {
                FileStream fs = File.Create(productPath);
                fs.Close();
            }
            ProductDL.readfromFile(productPath);
            loadData();
        }

        private void loadData()
        {
            RwIndx = -1;
            products = ProductDL.getList();
            dataGridView1.Rows.Clear();
            foreach (ProductBL prod in products)
            {
                dataGridView1.Rows.Add(prod.getProductname(), prod.getProductID(), prod.getCategory(), prod.getPrice(), prod.getStock(), "Edit/Delete");
            }
             prnameinpTXT.Text="";
             prIDinpTXT.Text="";
             categoryinpTXT.Text = "";
             prPriceinpTXT.Text = "";
             prStockinpTXT.Text = "";

        }
        private void Manage_Products_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                RwIndx = e.RowIndex;
                if (RwIndx < products.Count && RwIndx > -1)
                {
                    prnameinpTXT.Text = products[RwIndx].getProductname();
                    prIDinpTXT.Text = products[RwIndx].getProductID();
                    categoryinpTXT.Text = products[RwIndx].getCategory();
                    prPriceinpTXT .Text = products[RwIndx].getPrice().ToString();
                    prStockinpTXT.Text = products[RwIndx].getStock().ToString();               
                }
            }
        }

        private void prnameinpTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void prIDinpTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void prPriceinpTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void prStockinpTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            float price;
            int stock;
            string productName= prnameinpTXT.Text;
            string productID= prIDinpTXT.Text;
            string Category=categoryinpTXT.Text ;
            if (ProductDL.IsFloat(prPriceinpTXT.Text))
            {
                price = float.Parse(prPriceinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in floating point Text");
                return;
            }
            if (ProductDL.IsInt(prStockinpTXT.Text))
            {
                stock = int.Parse(prStockinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in Int TextBox");
                return;
            }
           
                if (productName != "" && productID != "" && Category != "")
                {
                    ProductBL prod = new ProductBL(productName, productID, Category, price, stock);
                    if (!ProductDL.productExist(prod))
                    {
                        ProductDL.addintoList(prod);
                        ProductDL.storeintoFile(prod,productPath);
                        loadData();
                        MessageBox.Show("Product Added");
                    }
                    else
                    {
                        MessageBox.Show("Product ID and Name cannot be Same");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("You cannot leave any thing Empty");
                    return;
                }
         
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            float price;
            int stock;
            string productName = prnameinpTXT.Text;// = products[RwIndx].getProductname();
            string productID = prIDinpTXT.Text;// = products[RwIndx].getProductID();
            string Category = categoryinpTXT.Text;//= products[RwIndx].getCategory();
            if (ProductDL.IsFloat(prPriceinpTXT.Text))
            {
                price = float.Parse(prPriceinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in floating point Text");
                return;
            }
            // = products[RwIndx].getPrice().ToString();
            // = products[RwIndx].getStock().ToString();
            if (ProductDL.IsInt(prStockinpTXT.Text))
            {
                stock = int.Parse(prStockinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in Int TextBox");
                return;
            }
            if (RwIndx!=-1)
            {
                if (productName != "" && productID != "" && Category != "")
                {
                    ProductBL prod = new ProductBL(productName, productID, Category, price, stock);
                    if (ProductDL.productExist(prod))
                    {
                        prod = ProductDL.returnbyIndex(RwIndx);
                        prod.setProductname(productName);
                        prod.setProductID(productID);
                        prod.setCaetgory(Category);
                        prod.setPrice(price);
                        prod.setStock(stock);
                        ProductDL.StoreintoFile();
                        loadData();
                        MessageBox.Show("Product Updated");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Product ID and Name cannot be Same");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("You cannot leave any thing Empty");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You need to Select First to Update");
                return;
            }
           
        }

        private void dltBTN_Click(object sender, EventArgs e)
        {
            float price;
            int stock;
            string productName = prnameinpTXT.Text;
            string productID = prIDinpTXT.Text;
            string Category = categoryinpTXT.Text;
            if (ProductDL.IsFloat(prPriceinpTXT.Text))
            {
                price = float.Parse(prPriceinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in floating point Text");
                return;
            }
            if (ProductDL.IsInt(prStockinpTXT.Text))
            {
                stock = int.Parse(prStockinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in Int TextBox");
                return;
            }
            if (productName != "" && productID != "" && Category != "")
            {
                ProductBL prod = new ProductBL(productName, productID, Category, price, stock);
                if (ProductDL.productExist(prod))
                {
                    products.RemoveAt(RwIndx);                   
                    ProductDL.StoreintoFile();
                    loadData();
                    MessageBox.Show("Product Deleted");
                    return;
                }
                else
                {
                    MessageBox.Show("Product ID and Name cannot be Same");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You cannot leave any thing Empty");
                return;
            }
        }

        private void prnameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void srchBTN_Click(object sender, EventArgs e)
        {
            string productName = prnameTXT.Text;
            string productID = prIDTXT.Text;
            if (productName != "")
            {
                if (ProductDL.checkProduct(productName,productID))
                {
                   foreach(ProductBL prod in products)
                    {
                        if (prod.getProductname() == productName)
                        {

                        }
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

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allCloseBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

    public partial class CopyOfManage_Products : Form
    {
        readonly string productPath = @"E:\2nd Semester\OOP\Product.txt";
        List<ProductBL> products = ProductDL.getList();
        int RwIndx;
        public CopyOfManage_Products()
        {
            InitializeComponent();
            if (!File.Exists(productPath))
            {
                FileStream fs = File.Create(productPath);
                fs.Close();
            }
            ProductDL.readfromFile(productPath);
            loadData();
        }

        private void loadData()
        {
            RwIndx = -1;
            products = ProductDL.getList();
            dataGridView1.Rows.Clear();
            foreach (ProductBL prod in products)
            {
                dataGridView1.Rows.Add(prod.getProductname(), prod.getProductID(), prod.getCategory(), prod.getPrice(), prod.getStock(), "Edit/Delete");
            }
            prnameinpTXT.Text = "";
            prIDinpTXT.Text = "";
            categoryinpTXT.Text = "";
            prPriceinpTXT.Text = "";
            prStockinpTXT.Text = "";

        }
        private void Manage_Products_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                RwIndx = e.RowIndex;
                if (RwIndx < products.Count && RwIndx > -1)
                {
                    prnameinpTXT.Text = products[RwIndx].getProductname();
                    prIDinpTXT.Text = products[RwIndx].getProductID();
                    categoryinpTXT.Text = products[RwIndx].getCategory();
                    prPriceinpTXT.Text = products[RwIndx].getPrice().ToString();
                    prStockinpTXT.Text = products[RwIndx].getStock().ToString();
                }
            }
        }

        private void prnameinpTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void prIDinpTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void prPriceinpTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void prStockinpTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            float price;
            int stock;
            string productName = prnameinpTXT.Text;
            string productID = prIDinpTXT.Text;
            string Category = categoryinpTXT.Text;
            if (ProductDL.IsFloat(prPriceinpTXT.Text))
            {
                price = float.Parse(prPriceinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in floating point Text");
                return;
            }
            if (ProductDL.IsInt(prStockinpTXT.Text))
            {
                stock = int.Parse(prStockinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in Int TextBox");
                return;
            }

            if (productName != "" && productID != "" && Category != "")
            {
                ProductBL prod = new ProductBL(productName, productID, Category, price, stock);
                if (!ProductDL.productExist(prod))
                {
                    ProductDL.addintoList(prod);
                    ProductDL.storeintoFile(prod, productPath);
                    loadData();
                    MessageBox.Show("Product Added");
                }
                else
                {
                    MessageBox.Show("Product ID and Name cannot be Same");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You cannot leave any thing Empty");
                return;
            }

        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            float price;
            int stock;
            string productName = prnameinpTXT.Text;// = products[RwIndx].getProductname();
            string productID = prIDinpTXT.Text;// = products[RwIndx].getProductID();
            string Category = categoryinpTXT.Text;//= products[RwIndx].getCategory();
            if (ProductDL.IsFloat(prPriceinpTXT.Text))
            {
                price = float.Parse(prPriceinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in floating point Text");
                return;
            }
            // = products[RwIndx].getPrice().ToString();
            // = products[RwIndx].getStock().ToString();
            if (ProductDL.IsInt(prStockinpTXT.Text))
            {
                stock = int.Parse(prStockinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in Int TextBox");
                return;
            }
            if (RwIndx != -1)
            {
                if (productName != "" && productID != "" && Category != "")
                {
                    ProductBL prod = new ProductBL(productName, productID, Category, price, stock);
                    if (ProductDL.productExist(prod))
                    {
                        prod = ProductDL.returnbyIndex(RwIndx);
                        prod.setProductname(productName);
                        prod.setProductID(productID);
                        prod.setCaetgory(Category);
                        prod.setPrice(price);
                        prod.setStock(stock);
                        ProductDL.StoreintoFile();
                        loadData();
                        MessageBox.Show("Product Updated");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Product ID and Name cannot be Same");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("You cannot leave any thing Empty");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You need to Select First to Update");
                return;
            }

        }

        private void dltBTN_Click(object sender, EventArgs e)
        {
            float price;
            int stock;
            string productName = prnameinpTXT.Text;
            string productID = prIDinpTXT.Text;
            string Category = categoryinpTXT.Text;
            if (ProductDL.IsFloat(prPriceinpTXT.Text))
            {
                price = float.Parse(prPriceinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in floating point Text");
                return;
            }
            if (ProductDL.IsInt(prStockinpTXT.Text))
            {
                stock = int.Parse(prStockinpTXT.Text);
            }
            else
            {
                MessageBox.Show("You cannot Enter String in Int TextBox");
                return;
            }
            if (productName != "" && productID != "" && Category != "")
            {
                ProductBL prod = new ProductBL(productName, productID, Category, price, stock);
                if (ProductDL.productExist(prod))
                {
                    products.RemoveAt(RwIndx);
                    ProductDL.StoreintoFile();
                    loadData();
                    MessageBox.Show("Product Deleted");
                    return;
                }
                else
                {
                    MessageBox.Show("Product ID and Name cannot be Same");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You cannot leave any thing Empty");
                return;
            }
        }

        private void prnameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void srchBTN_Click(object sender, EventArgs e)
        {
            string productName = prnameTXT.Text;
            string productID = prIDTXT.Text;
            if (productName != "")
            {
                if (ProductDL.checkProduct(productName, productID))
                {
                    foreach (ProductBL prod in products)
                    {
                        if (prod.getProductname() == productName)
                        {

                        }
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

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allCloseBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
