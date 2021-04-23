using DataExtractor.Interfaces;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace DataExtractor.Services
{
    public class XMLService : IXMLService, IUsersProvider
    {
        public Users GetUsers()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Users));
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Users\Adrianna\source\repos\DataExtracter\DataExtracter\SecondSet.xml");
            byte[] bytes = Encoding.UTF8.GetBytes(xmlDoc.OuterXml);
            return (Users)ser.Deserialize(new MemoryStream(bytes));
        }
    }
}

