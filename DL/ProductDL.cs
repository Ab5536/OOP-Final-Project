using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Project_GUI.DL;
using Business_Project_GUI.BL;
using System.Windows.Forms;

namespace Business_Project_GUI.DL
{
    class ProductDL
    {
        private static List<ProductBL> products = new List<ProductBL>();
        public static List<ProductBL> getList()
        {
            return products;
        }
        public static void addintoList(ProductBL prod)
        {
                products.Add(prod);
        }

        public static bool productExist(ProductBL prod)
        {
            foreach (ProductBL produ in products)
            {
                if (produ.getProductID() == prod.getProductID() && produ.getProductname() == prod.getProductname())
                {
                    return true;
                }
            }
            return false;
        }

       
        public static int countSameProduct(string productName)
        {
            int x = 0;
            foreach (ProductBL prod in products)
            {

                if (prod.getProductname() == productName)
                {
                    x++;
                }
            }
            return x;
        }
        public static void storeintoFile(ProductBL prod, string path)
        {
            StreamWriter filevar = new StreamWriter(path, true);
            filevar.Write("{0},{1},{2},{3},{4}\n", prod.getProductname(), prod.getProductID(), prod.getCategory(), prod.getPrice(), prod.getStock());
            filevar.Flush();
            filevar.Close();
        }

        internal static bool IsInt(string check)
        {
            if (int.TryParse(check, out _))
            {
                    return true;
            }
            else
            {
                return false;
            }
        }
        internal static ProductBL returnProduct(string productName)
        {
            ProductBL produc = new ProductBL();
            bool flag = false;
            int x = 0;
            foreach (ProductBL prod in products)
            {
                if (prod.getProductname() == productName)
                {
                    produc = prod;
                    flag = true;
                    break;
                }
                x++;
            }
            if (flag == true)
            {
                return produc;
            }
            else
            {
                return null;
            }
        }
       
        internal static int indexofProduct(string productName)
        {
            bool flag = false;
            int x = 0;
            foreach (ProductBL prod in products)
            {
                if (prod.getProductname() == productName)
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
        public static ProductBL returnbyIndex(int x)
        {
            return products[x];
        }

        public static void StoreintoFile()
        {
            string path= "Product.txt";
            StreamWriter filevar = new StreamWriter(path);
            foreach (ProductBL prod in products)
            {
                filevar.Write("{0},{1},{2},{3},{4}\n", prod.getProductname(), prod.getProductID(), prod.getCategory(), prod.getPrice(), prod.getStock());
            }
            filevar.Flush();
            filevar.Close();
        }

        public static void readfromFile(string path)
        {
            StreamReader filevar = new StreamReader(path, true);
            string text;
            while ((text = filevar.ReadLine()) != null)
            {
                ProductBL prod = readProduct(text);
                if (!productExist(prod))
                {
                   addintoList(prod);
                }
            }
            filevar.Close();
        }
        public static bool IsFloat(string check)
        {

            if (float.TryParse(check, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static bool ReduceStock(ProductBL prod)
        {
            bool flag = false;
            int x = 0;
            foreach (ProductBL produc in products)
            {
                if (prod.getProductname() == produc.getProductname()&& prod.getProductID()==produc.getProductID())
                {
                    if (prod.getStock() <= produc.getStock())
                    {
                        flag = true;
                        break;
                    }
                    MessageBox.Show("Kindly Enter available amount Less than "+ produc.getStock());
                    return false;
                }
                x++;
            }
            if (flag == true)
            {
                int num = products[x].getStock() - prod.getStock();
                if (num > 0)
                {
                    products[x].setStock(num);
                }
                else
                {
                    products.RemoveAt(x);
                }
                return true;
            }
            else
            {
                MessageBox.Show("Out of Stock ");
                return false;
            }
        }

        internal static bool CheckStock(ProductBL prod)
        {
            foreach (ProductBL produc in products)
            {
                if (prod.getProductID() == produc.getProductID())
                {
                    if (prod.getStock() <= produc.getStock())
                    {
                        return true;
                    }
                    MessageBox.Show("Kindly Enter the Available Amount");
                    return false;
                }
            }
            MessageBox.Show("Out of Stock");
            return false;
        }

        public static bool checkProduct(string productName,string ProductID)
        {
            foreach (ProductBL p in products)
            {
                if (p.getProductname() == productName&& p.getProductID() == ProductID)
                {
                    return true;
                }
            }
            return false;
        }
        public static ProductBL readProduct(string unsplitted)
        {
            List<string> texted = unsplitted.Split(',').ToList();
            Console.WriteLine(texted[0]);
            string productName = texted[0];
            Console.WriteLine(texted[1]);
            string productID = texted[1];
            Console.WriteLine(texted[2]);
            string category = texted[2];
            Console.WriteLine(texted[3]);
            float price = float.Parse(texted[3]);
            Console.WriteLine(texted[4]);
            int stock = int.Parse(texted[4]);
            ProductBL prod = new ProductBL(productName, productID, category, price, stock);
            //Console.WriteLine("one product");
            return prod;
        }

        internal static ProductBL assignnewProduct(string productName,string productID)
        {
            int x = 0;
            ProductBL prod = null;
            foreach (ProductBL p in products)
            {
                
                if (p.getProductname() == productName && p.getProductID()==productID)
                {
                    break;
                }
                x++;
            }           
            prod = new ProductBL(products[x]);
            return prod;
        }
    }
}
