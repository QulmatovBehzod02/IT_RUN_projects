using Applicatoin.Repositories;
using Applicatoin.Services;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
             services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
             services.AddSingleton<IEmailSenderService, EmailSenderService>();
             services.AddSingleton<IEmployeeService, EmployeeService>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IProductService, ProductService>();
             return services;
        }
    }
}
