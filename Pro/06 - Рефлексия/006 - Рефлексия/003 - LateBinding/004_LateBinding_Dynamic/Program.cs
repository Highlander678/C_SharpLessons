using System;
using System.IO;
using System.Reflection;

namespace _004_LateBinding_Dynamic
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("CarLibrary");
                Type type = assembly.GetType("CarLibrary.MiniVan");

                dynamic carInstance = Activator.CreateInstance(type);
                carInstance.Acceleration();
                carInstance.Driver("Shumaher", 26);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
