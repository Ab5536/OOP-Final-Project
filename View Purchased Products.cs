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
    public partial class viewPurchasedProducts : Form
    {
        CustomerInfoBL cust = null;
        List<ProductBL> products = null;
        public viewPurchasedProducts()
        {
            InitializeComponent();
        }
        public viewPurchasedProducts(CustomerInfoBL cust)
        {
            InitializeComponent();
            this.cust = cust;
        }
        private void viewPurchasedProducts_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            products = cust.getProductsList();
            prchsedprdctGrid.Rows.Clear();
            foreach (ProductBL prod in products)
            {
                prchsedprdctGrid.Rows.Add(prod.getProductname(), prod.getProductID(),prod.getPrice()*prod.getStock(), prod.getStock());
            }
        }
        private void prchsedprdctGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
