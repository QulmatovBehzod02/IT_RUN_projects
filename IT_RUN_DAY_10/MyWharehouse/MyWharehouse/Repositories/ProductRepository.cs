using MyWharehouse.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWharehouse.Repositories
{
    public class ProductRepository:IProductRepository
    {
        const string filePath = "store.txt";
        
        public void Add(string productName, int quantity)
        {
            var products = GetAll().ToList();  
            products.Add(new Product(productName, quantity));
            SaveAllProducts(products);
        }

        public IEnumerable<Product> GetAll()
        {
            string[] products = File.ReadAllLines(filePath, Encoding.UTF8);
            Product[] AllProducts= new Product[products.Length];

            for (int i = 0; i < products.Length; i++)
            {
                string[] splited = products[i].Split(' ');
                string productName = splited[0];
                int productQuantity = int.Parse(splited[1]);
                AllProducts[i]=new Product(productName, productQuantity);
            }

            return AllProducts;
        }

        public Product ProductGetByName(string name)
        {
            var products=GetAll();
            return products.SingleOrDefault(s=>s.Name==name);
        }
        public void UpdateQuantity(string productName, int quantity)
        {
            var products= GetAll();
            var product=products.SingleOrDefault(s=>s.Name==productName);
            product.Quantity=quantity;
            SaveAllProducts(products);
        }

        public void SaveAllProducts( IEnumerable<Product> products)
        {
            File.WriteAllLines(filePath, products.Select(p => $"{p.Name} {p.Quantity}"));
        }

        public void Delete(string productName)
        {
            var products = GetAll().ToList();
            var product = products.Single(s=>s.Name == productName);
            products.Remove(product);
            SaveAllProducts(products);
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
