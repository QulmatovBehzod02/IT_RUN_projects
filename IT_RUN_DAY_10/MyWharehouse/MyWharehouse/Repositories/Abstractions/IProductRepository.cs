using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWharehouse.Repositories.Abstractions
{
    public interface IProductRepository
    {
        void Add(string productName, int quantity);
        void UpdateQuantity(string productName, int quantity);
        void Delete(string productName);
        IEnumerable<Product> GetAll();
        Product ProductGetByName(string productName);
        void Exit(); 
    }
}
