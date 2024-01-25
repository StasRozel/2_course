using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace лаба__13
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    static class Serializer
    {

        static public void SerializationToJSON<T>(T[] obj)
        {
            string jsonData = JsonSerializer.Serialize(obj);

            File.WriteAllText("serialized_data.json", jsonData);
            string jsonFromFile = File.ReadAllText("serialized_data.json");

            T[] deserializedPeople = JsonSerializer.Deserialize<T[]>(jsonFromFile);

            foreach (var person in deserializedPeople)
            {
                Console.WriteLine($"Deserialized: {person}");
            }
        }

        static public void SerializationToBinary<T>(T[] obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("people.bin", FileMode.OpenOrCreate))
            {
                foreach (var item in obj)
                    formatter.Serialize(fs, item);
                
                Console.WriteLine("Объект сериализован");
            }

            using (Stream stream = File.Open("people.bin", FileMode.Open))
            {
             
                while (stream.Position < stream.Length)
                {
                    T user = (T)formatter.Deserialize(stream);
                    Console.WriteLine(user.ToString());
                }
            }
        }

        static public void SerializationToSOAP<T>(T[] obj)
        {
            IFormatter formatter = new SoapFormatter();

            using (FileStream fileStream = new FileStream("serialized_data.soap", FileMode.Create))
            {
                formatter.Serialize(fileStream, obj);
            }

            using (FileStream fileStream = new FileStream("serialized_data.soap", FileMode.Open))
            {
                T[] deserializedPeople = (T[])formatter.Deserialize(fileStream);

                foreach (var person in deserializedPeople)
                {
                    Console.WriteLine($"Deserialized: {person}");
                }
            }

        }

        static public void SerializationToXML<T>(T[] obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T[]));

            using (FileStream fs = new FileStream("users.xml", FileMode.Create))
            {
                serializer.Serialize(fs, obj);
            }

            using (FileStream fs = new FileStream("users.xml", FileMode.OpenOrCreate))
            {
                User[] users = (User[])serializer.Deserialize(fs);

                foreach (var item in users)
                {
                    Console.WriteLine(item.Email);
                }
            }
        }
    }
}
