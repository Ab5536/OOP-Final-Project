using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Project_GUI.DL;
using Business_Project_GUI.BL;

namespace Business_Project_GUI.BL
{
    public class CustomerInfoBL
    {       
            private string Name;
            private string CustID;
            private double Bill;
            List<string> feedback;
            List<ProductBL> products;
            List<ProductBL> cart;
            public void setCustBill(double no)
            {
              Bill = no;
            }
            public void addinCustBill(double no)
            {
               Bill = Bill + no;
            }
            public double getCustBill()
            {
              return Bill;
            }
        public CustomerInfoBL(string name, string custID)
        {
                this.Name = name;
                this.CustID = custID;
                feedback = new List<string>();
                products = new List<ProductBL>();
                cart = new List<ProductBL>();
                Bill = 0;
        }
         public CustomerInfoBL()
         {
                feedback = new List<string>();
                products = new List<ProductBL>();
                cart = new List<ProductBL>();
                Bill = 0;
         }
         public string getName()
         {
             return Name;
         }
         public string getCustID()
         {
             return CustID;
         }
         public void setCustID(string CustID)
         {
            this.CustID = CustID;
         }
            public void setName(string Name)
            {
                this.Name = Name;
            }
            public void setProductsList(List<ProductBL> products)
            {
                this.products = products;
            }
            public void addinProductList(ProductBL obj)
            {
                products.Add(obj);
            }
            public List<ProductBL> getProductsList()
            {
                return products;
            }
            public void setProductsCartList(List<ProductBL> cart)
            {
                this.cart = cart;
            }
            public void addinCartList(ProductBL obj)
            {
                cart.Add(obj);
            }
            public List<ProductBL> getProductsCartList()
            {
                return cart;
            }
            public void addinFeedbackList(string f)
            {
                feedback.Add(f);
            }
            public List<String> getFeedback()
            {
                return feedback;
            }
    }
}
