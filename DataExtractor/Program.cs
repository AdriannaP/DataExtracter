using DataExtractor.Interfaces;
using DataExtractor.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace DataExtractor
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

            var usersProviders = new List<(IUsersProvider, string)>();

            var jsonService = serviceProvider.GetService<IJsonService>();
            usersProviders.Add((jsonService, @"C:\Users\Adrianna\source\repos\DataExtractor\DataExtractor\FirstSet.json"));

            var xmlService = serviceProvider.GetService<IXMLService>();
            usersProviders.Add((xmlService, @"C:\Users\Adrianna\source\repos\DataExtractor\DataExtractor\SecondSet.xml"));

            var csvService = serviceProvider.GetService<ICSVService>();
            usersProviders.Add((csvService, @"C:\Users\Adrianna\source\repos\DataExtractor\DataExtractor\ThirdSet.csv"));

            var printerService = serviceProvider.GetService<IPrinterService>();
            printerService.WriteToConsole(usersProviders);
            Console.ReadKey();
        }
    }
}
