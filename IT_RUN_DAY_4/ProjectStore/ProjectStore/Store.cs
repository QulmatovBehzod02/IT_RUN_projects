using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Product
{
    public class StoreClass
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public StoreClass() { }

        public StoreClass(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public void SaveToFile( string name, int count)
        { 
            
            using (StreamWriter sw = new StreamWriter("Store.txt", true))
             {
                sw.WriteLine($"{name} {count}");
                sw.Flush();
             }

             Console.WriteLine("Successfully added");
            
        }

        public static string[] GetProducts(string path)
        {
            string[] products = File.ReadAllLines(path, Encoding.UTF8) ;
            return products ;
        }

        public static bool ProductExists(string name, string path)
        {
            bool exists = false ;
            string[] products = File.ReadAllLines(path, Encoding.UTF8);
            for (int i = 0; i < products.Length; i++)
            {
                string product = products[i];
                var splitted = product.Split(' ');

                string productName = splitted[0];
                int countOfProduct = int.Parse(splitted[1]);
                if (productName == name)
                {
                    exists= true;
                }
            }
            return exists ;
        }

    }
    public class StoreClass2:StoreClass
    {
        StoreClass storeClasss = new StoreClass();
     
    }
}

