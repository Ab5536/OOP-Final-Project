using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Project_GUI.DL;
using Business_Project_GUI.BL;

namespace Business_Project_GUI.BL
{
    public class ProductBL
    {
        string productName;
        string productID;
        float price;
        string category;
        int stock;
        public string getProductID()
        {
            return productID;
        }
        public int getStock()
        {
            return stock;
        }
        public void setStock(int stock)
        {
            this.stock = stock;
        }
        public void setProductID(string productID)
        {
            this.productID = productID;
        }
        public string getProductname()
        {
            return productName;
        }
        public float getPrice()
        {
            return price;
        }
        public string getCategory()
        {
            return category;
        }
        public void setProductname(string productName)
        {
            this.productName = productName;
        }
        public void setCaetgory(string category)
        {
            this.category = category;
        }
        public void setPrice(float price)
        {
            this.price = price;
        }
        public void getStock(int stock)
        {
            this.stock = stock;
        }
        public ProductBL(string productName, string productID, string category, float price, int stock)
        {
            this.price = price;
            this.category = category;
            this.productName = productName;
            this.productID = productID;
            this.stock = stock;
        }
        public ProductBL(ProductBL prod)
        {
            this.price = prod.getPrice();
            this.category = prod.getCategory();
            this.productName = prod.getProductname();
            this.productID = prod.getProductID();
            this.stock = prod.getStock();
        }
        public ProductBL()
        {

        }
        public double calculateBill()
        {
            double Bill;
            Bill = price * stock;
            return Bill;
        }
    }
}
