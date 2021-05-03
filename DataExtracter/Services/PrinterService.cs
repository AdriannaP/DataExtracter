using DataExtractor.Interfaces;
using System;
using System.Collections.Generic;

namespace DataExtractor.Services
{
    public class PrinterService : IPrinterService
    {
        public void WriteToConsole(IEnumerable<(IUsersProvider, string)> providerAndPaths)
        {
            var users = new List<User>();

            foreach(var providerAndPath in providerAndPaths)
            {
                users.AddRange(providerAndPath.Item1.GetUsers(providerAndPath.Item2).Persons);
            }

            foreach (var item in users)
            {
                Console.WriteLine(item.Name + "  " + item.LastName + "  " + item.EMail);
            }
        }
    }
}
