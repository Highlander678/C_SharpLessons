using System;
using System.IO;
using System.Xml;

namespace AdditionTask
{
    class Program
    {
        static void Main()
        {
            var xmlWriter = new XmlTextWriter("TelephoneBook.xml", null);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("(093)*******");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Alex Alexeev");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            Console.SetWindowSize(100, 25);

            FileStream stream = new FileStream("TelephoneBook.xml", FileMode.Open);

            XmlTextReader xmlReader = new XmlTextReader(stream);

            while (xmlReader.Read())
            {
                Console.WriteLine("NodeType: {0,-15}| Name: {1,-15}| Value: {2,-15}",
                                xmlReader.NodeType,
                                xmlReader.Name,
                                xmlReader.Value);
            }

            xmlReader.Close();
            stream.Close();

            // Delay.
            Console.ReadKey();
        }
    }
}
