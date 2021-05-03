using CsvHelper;
using DataExtractor.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace DataExtractor.Services
{
    public class CSVService : ICSVService, IUsersProvider
    {
        List<User> lst = new List<User>();

        public Users GetUsers(string path)
        {
            string[] lines = File.ReadAllLines(path);


            foreach (string line in lines)
            {
                string[] temp = line.Split(',');

                if (!line.StartsWith("#"))
                {
                    User coding = new User();
                    coding.Name = temp[0];
                    coding.LastName = temp[1];
                    coding.EMail = temp[2];
                    lst.Add(coding);
                }
            }
            return new Users
            {
                Persons = lst 
            };
        }
    }
}


