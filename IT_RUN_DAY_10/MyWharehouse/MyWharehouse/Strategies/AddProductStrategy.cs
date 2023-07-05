using MyWharehouse.Repositories.Abstractions;
using MyWharehouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWharehouse.Strategies
{
    internal class AddProductStrategy : ICommandLineStrategy
    {
        IProductRepository _productRepository;
        
        public AddProductStrategy(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ConsoleKey StrategyKey => ConsoleKey.B;


        public void Execute()
        {
            Console.WriteLine("Insert Product:");
            Console.Write("Add Pruduct Name: ");
            string newProductName=Console.ReadLine();

            Console.Write("Add Pruduct Quantity: ");
            int newProductQuantity=int.Parse(Console.ReadLine());

            var existingProduct=_productRepository.ProductGetByName(newProductName);
            if(existingProduct == null) 
            { 
                _productRepository.Add(newProductName, newProductQuantity);
            }
            else
            {
                int newQuantity=existingProduct.Quantity+newProductQuantity;
                _productRepository.UpdateQuantity(newProductName, newQuantity);
            }
        }
       
    }
}
