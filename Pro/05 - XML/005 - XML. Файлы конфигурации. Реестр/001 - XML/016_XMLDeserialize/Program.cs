using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace _016_XMLDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new XmlSerializer(typeof(ListOfBooks));
            var moduleMetaData = (ListOfBooks)serializer.Deserialize(new XmlTextReader("books.xml"));

            foreach (var book in moduleMetaData.Items)
            {
                Console.WriteLine(book.Title.First().Value);
                Console.WriteLine(book.Price);
                book.Price +="0";

                Console.WriteLine(book.Title.First().FontSize);
                Console.WriteLine(new string('-',20));
            }
            var newxml = File.Create("newbooks.xml");
            serializer.Serialize(newxml, moduleMetaData);
            newxml.Close();
            Console.ReadKey();

        }
    }
}
