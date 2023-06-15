using System;
using System.Collections.Generic;
using System.IO;

class Program
{       

    static void Main()
    {
        List <Product> products = new List<Product>();
        products.Add(new Product { Name = "apple", Count = 10 });
        products.Add(new Product { Count = 10 , Name="Nok"});
        using (StreamWriter sw = new StreamWriter("products.txt"))
        {
            foreach (var item in products)
            {
                sw.WriteLine($"{item.Name}, {item.Count}");
            }
        }



        string filePath = "products.txt"; // Path to the file

        List<Product> productList = new List<Product>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 2)
                {
                    string productName = parts[0].Trim();
                    int productCount;

                    if (int.TryParse(parts[1].Trim(), out productCount))
                    {
                        Product product = new Product(productName, productCount);
                        productList.Add(product);
                    }
                    else
                    {
                        Console.WriteLine("Invalid count for product: {0}", productName);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid line format: {0}", line);
                }
            }

            // Print the products in the list
            foreach (Product product in productList)
            {
                Console.WriteLine("Product: {0}, Count: {1}", product.Name, product.Count);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found: {0}", filePath);
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading the file: {0}", filePath);
        }
    }
}

class Product
{
    public string Name { get; set; }
    public int Count { get; set; }

    public Product() { }
    public Product(string name, int count)
    {
        Name = name;
        Count = count;
    }
}
