using Microsoft.Extensions.DependencyInjection;
using MyWharehouse;
using MyWharehouse.Strategies;
using MyWharehouse.Repositories;
using MyWharehouse.Repositories.Abstractions;
using MyWharehouse.Strategies.Abstractions;
using System.Security.Authentication.ExtendedProtection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IProductRepository, ProductRepository>();
serviceCollection.AddSingleton<ICommandLineStrategyResolver, CommandLIneStrategyResolver>();

serviceCollection.AddSingleton<ICommandLineStrategy, GetProductStrategy>();
serviceCollection.AddSingleton<ICommandLineStrategy, AddProductStrategy>();
serviceCollection.AddSingleton<ICommandLineStrategy, SellProductStrategy>();
serviceCollection.AddSingleton<ICommandLineStrategy, DeleteProductStrategy>();
serviceCollection.AddSingleton<ICommandLineStrategy, CloseApplicationStrategy>();

serviceCollection.AddSingleton<Application>();
var provider = serviceCollection.BuildServiceProvider();
Application application = provider.GetRequiredService<Application>();
application.Start();
