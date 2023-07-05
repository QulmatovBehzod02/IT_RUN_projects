using MyWharehouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWharehouse
{
    public class Application
    {
        ICommandLineStrategyResolver _resolver;
        public Application(ICommandLineStrategyResolver commandLineStrategyResolver)
        {
            _resolver = commandLineStrategyResolver;
        }

        public void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            bool isContinue = true;

            while (isContinue)
            {
                Console.Clear();
                ShowMenu();

                ConsoleKeyInfo userInput = Console.ReadKey(true);
                var strategy = _resolver.GetResolver(userInput.Key);
                strategy.Execute();

                Console.WriteLine("Нажмите для продолжения.");
                Console.ReadKey();
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine("Выберите действие: \n" +
                "а) Product List\n" +
                "b) Add New Product\n" +
                "c) Sell Product\n" +
                "Delete) Delete Product\n" +
                "ESC) Exit\n");
        }
    }
}
