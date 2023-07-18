using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatoin.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void UpdateProduct(string name, Product product);

    }
}
