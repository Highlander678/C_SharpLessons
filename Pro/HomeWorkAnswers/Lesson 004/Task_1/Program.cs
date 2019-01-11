using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите адресс сайта для проверки: ");
            string url = Console.ReadLine();

            // Create a request for the URL. 
            WebRequest request = WebRequest.Create(url);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();

            StreamWriter writer = File.CreateText("Log.txt");

            var regex = new Regex(@"href='(?<link>\S+)'>");

            foreach (Match m in regex.Matches(responseFromServer))
            {
                writer.WriteLine("ССЫЛКА: {0,-25}", m.Groups["link"]);
            }

            regex = new Regex(@"(?<phone>[+3(0-90-90-9)\s]{2,}[0-9]{3}[\s\-][0-9]{2}[\s\-][0-9]{2})");

            foreach (Match m in regex.Matches(responseFromServer))
            {
                writer.WriteLine("Тел. номер: {0,-25}", m.Groups["phone"]);
            }

            regex = new Regex(@"(?<email>[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4})");

            foreach (Match m in regex.Matches(responseFromServer))
            {
                writer.WriteLine("E-Mail: {0,-25}", m.Groups["email"]);
            }

            writer.Close();
            Console.ReadKey();
        }
    }
}

