using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Project_GUI.DL;
using System.Windows.Forms;
using Business_Project_GUI.BL;

namespace Business_Project_GUI.DL
{
    class CustomerInfoDL
    {
        private static List<CustomerInfoBL> customers = new List<CustomerInfoBL>();
        public static void addintoList(CustomerInfoBL cust)
        {
            customers.Add(cust);
        }

        public static bool checkCustomer(CustomerInfoBL cust)
        {
            foreach (CustomerInfoBL custom in customers)
            {
                if (custom.getCustID() == cust.getCustID() && custom.getName() == cust.getName())
                {
                    return true;
                }
            }
            return false;
        }
        public static bool checkCustomer(string custName,string CustID )
        {
            foreach (CustomerInfoBL custom in customers)
            {
                if (custom.getCustID() == CustID&& custom.getName()==custName)
                {
                    return true;
                }
            }
            return false;
        }
        public static void storeFeedBack(List<string> feedback, string path)
        {
            StreamWriter filevar = new StreamWriter(path, true);

            filevar.Flush();
            filevar.Close();
        }
        public static void storeIntoFile(CustomerInfoBL cust)
        {
            string path = "CustomerFile.txt";
            StreamWriter filevar = new StreamWriter(path, true);
            filevar.Write("{0}^{1}^{2}^", cust.getName(), cust.getCustID(),cust.getCustBill());
            List<ProductBL> productsList = cust.getProductsList();
            if (productsList.Count > 0)
            {
                for (int x = 0; x < productsList.Count; x++)
                {
                    ProductBL pr = productsList[x];
                    filevar.Write("{0},{1},{2},{3},{4}", pr.getProductname(), pr.getProductID(), pr.getCategory(), pr.getPrice(), pr.getStock());
                    if (x + 1 < productsList.Count)
                    {
                        filevar.Write(";");
                    }
                }
            }
            else
            {
                filevar.Write("-");
            }
            filevar.Write("^");
            productsList = cust.getProductsCartList();
            if (productsList.Count > 0)
            {
                for (int x = 0; x < productsList.Count; x++)
                {
                    ProductBL pr = productsList[x];
                    filevar.Write("{0},{1},{2},{3},{4}", pr.getProductname(), pr.getProductID(), pr.getCategory(), pr.getPrice(), pr.getStock());
                    if (x + 1 < productsList.Count)
                    {
                        filevar.Write(";");
                    }
                }
            }
            else
            {
                filevar.Write("-");
            }
            List<string> feedback = cust.getFeedback();
            filevar.Write("^");
            if (feedback.Count > 0)
            {
                int x = 0;
                foreach (string f in feedback)
                {
                    filevar.Write("{0}", f);
                    if (x + 1 < feedback.Count)
                    {
                        filevar.Write("*");
                    }
                    x++;
                }
            }
            else
            {
                filevar.Write("-");
            }
            filevar.Write("\n");
            filevar.Flush();
            filevar.Close();
        }

        internal static void readfromFile()
        {
            string path= "CustomerFile.txt";
            CustomerInfoBL cust = new CustomerInfoBL();
            StreamReader filevar = new StreamReader(path);
            string text;
            while ((text = filevar.ReadLine()) != null)
            {
                List<string> split1 = text.Split('^').ToList();
                string Name = split1[0];
                string CustID = split1[1];
                double Bill = double.Parse(split1[2]);
                cust.setName(Name);
                cust.setCustID(CustID);
                cust.setCustBill(Bill);
               // MessageBox.Show(" " + cust.getCustID());
                if (split1[3] != "-")
                {
                    List<string> split2 = split1[3].Split(';').ToList();
                    foreach (string s in split2)
                    {
                        Console.WriteLine(s);
                        ProductBL prod = ProductDL.readProduct(s);
                        cust.addinProductList(prod);
                    }
                }
                if (split1[4] != "-")
                {
                    string[] split3 = split1[4].Split(';');
                    foreach (string s in split3)
                    {
                        ProductBL prod = ProductDL.readProduct(s);
                        cust.addinCartList(prod);
                    }
                }
                if (split1[5] != "-")
                {
                    readFeedback(split1[5], cust);
                }
                CustomerInfoDL.addintoList(cust);

            }
            filevar.Close();
        }

        internal static List<CustomerInfoBL> getCustomersList()
        {
            return customers;
        }

        private static void readFeedback(string unsplit, CustomerInfoBL cust)
        {
            List<string> splitted = unsplit.Split('*').ToList();
            foreach (string s in splitted)
            {
                cust.addinFeedbackList(s);
            }
        }

        internal static CustomerInfoBL assignCustomer(CustomerInfoBL cust)
        {
            int x = 0;
            foreach (CustomerInfoBL custom in customers)
            {
                if (custom.getCustID() == cust.getCustID() && custom.getName() == cust.getName())
                {
                    break;
                }
                x++;
            }
            return customers[x];
        }

        internal static void StoreIntoFile()
        {
           string path = "CustomerFile.txt";
            StreamWriter filevar = new StreamWriter(path);
            foreach (CustomerInfoBL cust in customers)
            {
                filevar.Write("{0}^{1}^{2}^", cust.getName(), cust.getCustID(),cust.getCustBill());
                List<ProductBL> productsList = cust.getProductsList();
                if (productsList.Count > 0)
                {
                    for (int x = 0; x < productsList.Count; x++)
                    {
                        ProductBL pr = productsList[x];
                        filevar.Write("{0},{1},{2},{3},{4}", pr.getProductname(), pr.getProductID(), pr.getCategory(), pr.getPrice(), pr.getStock());
                        if (x + 1 < productsList.Count)
                        {
                            filevar.Write(";");
                        }
                    }
                }
                else
                {
                    filevar.Write("-");
                }
                filevar.Write("^");
                productsList = cust.getProductsCartList();
                if (productsList.Count > 0)
                {
                    for (int x = 0; x < productsList.Count; x++)
                    {
                        ProductBL pr = productsList[x];
                        filevar.Write("{0},{1},{2},{3},{4}", pr.getProductname(), pr.getProductID(), pr.getCategory(), pr.getPrice(), pr.getStock());
                        if (x + 1 < productsList.Count)
                        {
                            filevar.Write(";");
                        }
                    }
                }
                else
                {
                    filevar.Write("-");
                }
                List<string> feedback = cust.getFeedback();
                filevar.Write("^");
                if (feedback.Count > 0)
                {
                    int x = 0;
                    foreach (string f in feedback)
                    {
                        filevar.Write("{0}", f);
                        if (x + 1 < feedback.Count)
                        {
                            filevar.Write("*");
                        }
                        x++;
                    }
                }
                else
                {
                    filevar.Write("-");
                }
                filevar.Write("\n");
            }
            filevar.Flush();
            filevar.Close();
        }
        internal static bool checkPurchasedCartProducts(CustomerInfoBL cust, string productName)
        {
            List<ProductBL> products = cust.getProductsCartList();
            foreach (ProductBL prod in products)
            {
                if (prod.getProductname() == productName)
                {
                    Console.WriteLine("\t\t\t\tTrue");
                    return true;
                }
            }
            return false;
        }

        internal static bool checkPurchasedProducts(ProductBL prod, CustomerInfoBL cust)
        {
            List<ProductBL> products = cust.getProductsList();
            foreach (ProductBL product in products)
            {
                if (product.getProductname() == prod.getProductname()&& product.getProductID() == prod.getProductID())
                {
                    return true;
                }
            }
            return false;
        }

        internal static void changePurchasedStock(ProductBL product, CustomerInfoBL cust)
        {
            int x = 0;
            int Stock = 0;
            List<ProductBL> products = cust.getProductsList();
            foreach (ProductBL prod in products)
            {
                if (prod.getProductname() == product.getProductname()&& prod.getProductID()==product.getProductID())
                {
                    Stock = prod.getStock();
                    break;
                }
                x++;
            }
            int stock = product.getStock();
            products[x].setStock(Stock + stock);
        }
        public static int findProductCustomer(List<ProductBL> products ,ProductBL product)
        {
            bool flag = false;
            int x = 0;
            foreach (ProductBL prod in products)
            {
                if (prod.getProductname() == product.getProductname()&&prod.getProductID()==product.getProductID())
                {
                    flag = true;
                    break;
                }
                x++;
            }
            if (flag == true)
            {
                return x;
            }
            else
            {
                return -1;
            }
        }
        internal static void changeCartedStock(int stock, string productName)
        {
            int x, y;
            y = 0;
            foreach (CustomerInfoBL cust in customers)
            {
                x = 0;
                List<ProductBL> products = cust.getProductsCartList();
                foreach (ProductBL prod in products)
                {
                    if (prod.getProductname() == productName)
                    {
                        int st = products[x].getStock();
                        products[x].setStock(st + stock);
                        customers[y].setProductsCartList(products);
                        return;
                    }
                    x++;
                }
                y++;
            }
        }
    }
}
