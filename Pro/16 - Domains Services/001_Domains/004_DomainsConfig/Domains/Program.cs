using System;
using System.Security;
using System.Security.Policy;

// Конфигурирование доменов приложений.
// Запуск сборок с ограниченными привилегиями.

namespace Domains
{
    class Program
    {
        static void Main()
        {
            AppDomain domain = AppDomain.CreateDomain("Second Domain");

            Zone [] hostEvidence = { new Zone(SecurityZone.Internet) }; // Заменить Internet на MyComputer

            Evidence evidence = new Evidence(hostEvidence, null);

            try
            {
                domain.ExecuteAssembly("SecondAssembly.exe", evidence);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Delay
            Console.ReadKey();
        }
    }
}
