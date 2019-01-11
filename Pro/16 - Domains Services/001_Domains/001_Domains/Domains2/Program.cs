using System;

// Выгрузка домена приложения.

namespace Domains
{
    class Program
    {
        static void Main()
        {
            AppDomain domain = AppDomain.CreateDomain("Second Domain");

            Console.WriteLine("Host domain  : " + AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("Child domain : " + domain.FriendlyName);

            AppDomain.Unload(domain); // Выгрузка домена приложения.

            try
            {
                Console.WriteLine("Host domain  : " + AppDomain.CurrentDomain.FriendlyName);
                Console.WriteLine("Child domain : " + domain.FriendlyName); // Исключение.
            }
            catch (AppDomainUnloadedException e)
            {
                Console.WriteLine(e.Message);
            }

            // Delay
            Console.ReadKey();
        }
    }
}
