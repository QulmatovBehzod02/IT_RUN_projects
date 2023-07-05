using MyWharehouse.Repositories.Abstractions;
using MyWharehouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWharehouse.Strategies
{
    internal class GetProductStrategy:ICommandLineStrategy
    {
        IProductRepository _productRepository;

        public GetProductStrategy(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ConsoleKey StrategyKey => ConsoleKey.A;

        public void Execute()
        {
            Console.WriteLine("Product List:");
            var products = _productRepository.GetAll();
            foreach ( var product in products ) 
            {
                Console.WriteLine(product);
            }
        }
    }
}
