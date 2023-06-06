using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace StoreDay1
{
    public class Store
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public Store() 
        {
            //emty constructor
        }

        public Store(string name, int count) 
        { 
            Name = name;
            Count = count;
        }

        public static void SaveToFile(string path,  Store store)
        {
            using (StreamWriter writer = new StreamWriter(path)) 
            {
                writer.WriteLine(store.Name);
                writer.WriteLine(store.Count);
            }
            Console.WriteLine("Сохранение в файл успешно выполнено.");
        }

       /* public static Product[] GetProducts(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                int count = int.Parse(reader.ReadLine());

                Product[] products = new Product[count];
                for (int i = 0; i < count; i++)
                {
                    products[i] = new Product(name);
                }
                Console.WriteLine("Чтение из файла успешно выполнено.");
                return products;
            }
        }*/

        public static bool ProductExists(string name, string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                int count = int.Parse(reader.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    string productName = reader.ReadLine();
                    if (productName == name)
                    {
                        Console.WriteLine("Продукт существует.");
                        return true;
                    }
                }

                Console.WriteLine("Продукт не найден.");
                return false;
            }
        }
    }
    public class Product
    {
        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}
