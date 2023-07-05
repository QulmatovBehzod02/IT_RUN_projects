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
    internal class SellProductStrategy : ICommandLineStrategy
    {
        IProductRepository _productRepository;
        public SellProductStrategy(IProductRepository productRepository) 
        { 
            _productRepository = productRepository;
        }

        public ConsoleKey StrategyKey => ConsoleKey.C;

        public void Execute()
        {
            Console.WriteLine("Sell Product:");
            Console.Write("Product Name: ");
            string productForSell = Console.ReadLine();

            Console.Write("Product Quantity: ");
            int sellProductQuantity=int.Parse(Console.ReadLine());

            var product=_productRepository.ProductGetByName(productForSell);
            if (product==null)
            {
                Console.WriteLine("Product does not exist");
            }
            else
            {
                var newProductQuantity=product.Quantity-sellProductQuantity;
                if (newProductQuantity <= 0) 
                {
                    _productRepository.Delete(product.Name);
                }
                else
                {
                    _productRepository.UpdateQuantity(productForSell, newProductQuantity);
                }
            }
        }
    }
}
