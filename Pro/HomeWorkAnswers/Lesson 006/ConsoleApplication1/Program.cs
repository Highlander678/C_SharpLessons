using System;
using System.Reflection;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = Assembly.Load("Task_1");

            dynamic instance = Activator.CreateInstance(assembly.GetType("Task_1.Temperature"));

            Console.WriteLine("15 °C по °F равно " + instance.Fahrenheit(15m));

            Console.ReadKey();
        }
    }
}
