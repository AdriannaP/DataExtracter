using DataExtractor.Interfaces;
using DataExtractor.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace DataExtracter
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IJsonService, JsonService>()
            .AddSingleton<ICSVService, CSVService>()
            .AddSingleton<IXMLService, XMLService>()
            .AddSingleton<IPrinterService, PrinterService>()
            .BuildServiceProvider();

            var usersProviders = new List<IUsersProvider>();
            
            var jsonService = serviceProvider.GetService<IJsonService>();
            usersProviders.Add(jsonService);
            
            var xmlService = serviceProvider.GetService<IXMLService>();
            usersProviders.Add(xmlService);
            
           var csvService = serviceProvider.GetService<ICSVService>();
           usersProviders.Add(csvService);
            
            var printerService = serviceProvider.GetService<IPrinterService>();
            printerService.WriteToConsole(usersProviders);
            Console.ReadKey();
        }
    }
}
