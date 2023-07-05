using MyWharehouse.Repositories;
using MyWharehouse.Repositories.Abstractions;
using MyWharehouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWharehouse.Strategies
{
    internal class DeleteProductStrategy : ICommandLineStrategy
    {
        IProductRepository _productRepository;

        public DeleteProductStrategy(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ConsoleKey StrategyKey => ConsoleKey.Delete;

        public void Execute()
        {
            Console.WriteLine("Sell Product:");
            Console.Write("Product Name: ");
            string productForDelete = Console.ReadLine();

            var product = _productRepository.ProductGetByName(productForDelete);
            if (product == null)
            {
                Console.WriteLine("Product does not exist");
            }
            else
            {
                _productRepository.Delete(productForDelete);
            }
        }
    }
}
