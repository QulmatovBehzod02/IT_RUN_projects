using MyWharehouse.Repositories.Abstractions;
using MyWharehouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWharehouse.Strategies
{
    public class CloseApplicationStrategy:ICommandLineStrategy
    {
        IProductRepository _repository;
        public CloseApplicationStrategy(IProductRepository productRepository) 
        {
            _repository = productRepository;
        }

        public ConsoleKey StrategyKey => ConsoleKey.Escape;

        public void Execute()
        {
            _repository.Exit();
        }
    }
}
