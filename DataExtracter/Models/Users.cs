using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataExtractor
{
    [XmlRoot(ElementName = "user")]
    public class User
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "LastName")]
        public string LastName { get; set; }

        [JsonProperty("e-mail")]
        [XmlElement(ElementName = "e-mail")]
        public string EMail { get; set; }
    }

    [XmlRoot(ElementName = "users")]
    public class Users
    {
        [XmlElement(ElementName = "user")]
        public List<User> Persons { get; set; }
        
    }
}
