using MyWharehouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWharehouse.Strategies
{
    internal class CommandLIneStrategyResolver : ICommandLineStrategyResolver
    {
        IEnumerable<ICommandLineStrategy> _strategies;
        public CommandLIneStrategyResolver(IEnumerable<ICommandLineStrategy> strategies)
        {
            _strategies = strategies;
        }

        public ICommandLineStrategy GetResolver(ConsoleKey consoleKey)
        {
            return _strategies.Single(s=>s.StrategyKey == consoleKey);
        }
    }
}
