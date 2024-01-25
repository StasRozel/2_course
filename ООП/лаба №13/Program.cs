using System.Xml;
using Newtonsoft.Json.Linq;

namespace лаба__13
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();

            invoice.Name = "Stas";
            invoice.Description = "ahhhahahaha";
            invoice.Address = "de";

            invoice.DatePrint(12, 12, 2012);


            User user1 = new User
            {
                Id = 1,
                Name = "John Smith",
                Email = "john@email.com"
            };

            User user2 = new User
            {
                Id = 2,
                Name = "Bob Smith",
                Email = "bob@email.com"
            };

            User[] users = { user1, user2 };

            Serializer.SerializationToXML(users);

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            XmlElement? xRoot = xDoc.DocumentElement;

            XmlNodeList? nameNodes = xRoot?.SelectNodes("//User/Name");
            if (nameNodes is not null)
            {
                foreach (XmlNode node in nameNodes)
                    Console.WriteLine(node.InnerText);
            }

            XmlNodeList? emailNodes = xRoot?.SelectNodes("//User/Email");
            if (emailNodes is not null)
            {
                foreach (XmlNode node in emailNodes)
                    Console.WriteLine(node.InnerText);
            }

            JObject o = JObject.Parse(@"{
              'CPU': 'Intel',
              'Drives': [
                'DVD read/writer',
                '500 gigabyte hard drive'
              ]
            }");

            string cpu = (string)o["CPU"];
            // Intel

            string firstDrive = (string)o["Drives"][0];
            // DVD read/writer

            IList<string> allDrives = o["Drives"].Select(t => (string)t).ToList();

            foreach (var item in allDrives)
            {
                Console.WriteLine(item);

            }

        }
    }
}