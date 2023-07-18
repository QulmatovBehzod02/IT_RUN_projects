using Applicatoin.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        List<Product> _products = new();
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
              return _products;
        }

        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }

        public void UpdateProduct(string name, Product product)
        {
            var index = _products.FindIndex(s => s.Name==name);
            _products[index]= product;
        }
    }
}
