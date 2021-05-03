using DataExtractor.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace DataExtractor.Services
{
    public class JsonService : IJsonService, IUsersProvider
    {
        public Users GetUsers(string path)
        {
            var jsonObj = JsonConvert.DeserializeObject<Users>(File.ReadAllText(path));
            return jsonObj;
        }
    }
}
