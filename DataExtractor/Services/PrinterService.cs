using DataExtractor.Interfaces;
using System;
using System.Collections.Generic;

namespace DataExtractor.Services
{
    public class PrinterService : IPrinterService
    {
        public void WriteToConsole(IEnumerable<IUsersProvider> usersProviders)
        {
            var users = new List<User>();

            foreach(var userProvider in usersProviders)
            {
                users.AddRange(userProvider.GetUsers().Persons);
            }

            foreach (var item in users)
            {
                Console.WriteLine(item.Name + "  " + item.LastName + "  " + item.EMail);
            }
        }
    }
}
