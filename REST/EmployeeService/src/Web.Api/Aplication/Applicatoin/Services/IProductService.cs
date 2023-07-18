using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatoin.Services
{
    public interface IProductService
    {
        void Create(string  productName, string discription, string manufacturer, decimal price, int ram, string CPU, int hardDrive);
        void Update(string productName, string discription, string manufacturer, decimal price, int ram, string CPU, int hardDrive);
        void Delete(string productName);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetByName(string name);
        IEnumerable<Product> GetByDescription(string description);
        IEnumerable<Product> GetByManufacturer(string manufacturer);
        IEnumerable<Product> GetByPrice(decimal price);
        IEnumerable<Product> GetByRam(int ram);
        IEnumerable<Product> GetByCPU(string CPU);
        IEnumerable<Product> GetByHardDrive(int hardDrive);
    }
}
