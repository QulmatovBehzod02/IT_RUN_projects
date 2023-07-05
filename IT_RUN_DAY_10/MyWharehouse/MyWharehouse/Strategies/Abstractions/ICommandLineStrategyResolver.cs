﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWharehouse.Strategies.Abstractions
{
    public interface ICommandLineStrategyResolver
    {
        ICommandLineStrategy GetResolver(ConsoleKey consoleKey);
    }
}
