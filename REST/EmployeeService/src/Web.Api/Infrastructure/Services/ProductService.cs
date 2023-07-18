using Applicatoin.Repositories;
using Applicatoin.Services;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) 
        {
            _productRepository= productRepository;
        }

        public void Create(string productName, string discription, string manufacturer, decimal price, int ram, string cpu, int hardDrive)
        {
            Product product = new Product
            {
                Name = productName,
                Description = discription,
                Manufacturer = manufacturer,
                Price = price,
                Ram = ram,
                CPU = cpu,
                HardDrive = hardDrive
            };
            _productRepository.AddProduct(product);
        }

        public void Delete(string productName)
        {
            var productForDelete= _productRepository.GetAll().FirstOrDefault(s => s.Name == productName);
            _productRepository.RemoveProduct(productForDelete);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Product> GetByCPU(string cpu)
        {
            return _productRepository.GetAll().Where(s => s.CPU == cpu);
        }

        public IEnumerable<Product> GetByDescription(string description)
        {
            return _productRepository.GetAll().Where(s => s.Description == description);
        }

        public IEnumerable<Product> GetByHardDrive(int hardDrive)
        {
            return _productRepository.GetAll().Where(s => s.HardDrive== hardDrive);
        }

        public IEnumerable<Product> GetByManufacturer(string manufacturer)
        {
            return _productRepository.GetAll().Where(s => s.Manufacturer == manufacturer);
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return _productRepository.GetAll().Where(s => s.Name == name);
        }

        public IEnumerable<Product> GetByPrice(decimal price)
        {
            return _productRepository.GetAll().Where(s => s.Price== price);
        }

        public IEnumerable<Product> GetByRam(int ram)
        {
            return _productRepository.GetAll().Where(s => s.Ram == ram);
        }

        public void Update(string productName, string discription, string manufacturer, decimal price, int ram, string CPU, int hardDrive)
        {
            Product productNewForUpdate = new Product
            {
                Name = productName,
                Description = discription,
                Manufacturer = manufacturer,
                Price = price,
                CPU = CPU,
                Ram = ram,
                HardDrive = hardDrive
            };
            _productRepository.UpdateProduct(productName, productNewForUpdate);
        }
    }
}
