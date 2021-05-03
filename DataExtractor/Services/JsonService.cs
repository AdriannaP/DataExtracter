using DataExtractor.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace DataExtractor.Services
{
    public class JsonService : IJsonService, IUsersProvider
    {
        public Users GetUsers()
        {
            var jsonObj = JsonConvert.DeserializeObject<Users>(File.ReadAllText(@"C:\Users\Adrianna\source\repos\DataExtracter\DataExtracter\FirstSet.json"));
            return jsonObj;
        }
    }
}
