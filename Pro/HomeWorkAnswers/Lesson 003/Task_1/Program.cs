using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            StreamWriter writer = File.CreateText("test.txt");
            writer.WriteLine("Hello world!!!");
            writer.Close();

            StreamReader reader = File.OpenText("test.txt");
            string text = reader.ReadToEnd();
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
