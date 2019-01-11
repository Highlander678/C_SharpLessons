using System;
using Microsoft.Win32;

// Навигация по реестру.

namespace RegistryBasics
{
    class Program
    {
        static void Main()
        {
            // Процесс получения ссылки на объект RegistryKey называется открытием ключа.
            RegistryKey myKey = Registry.LocalMachine;
            RegistryKey software = myKey.OpenSubKey("Software");
            RegistryKey microsoft = software.OpenSubKey("Microsoft");
            
            Console.WriteLine("{0} - имеет {1} элементов.", microsoft.Name, microsoft.SubKeyCount);

            software.Close();
            microsoft.Close();

            // Попытка открыть несуществующий ключ. Переменной software будет присвоено значение NULL.
            software = myKey.OpenSubKey("NonExistName");
                        
            try
            {
                // Попытка обратится к переменной, значение которой не присвоено.
                Console.WriteLine("Открыли узел: {0}.", software.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}\n{1}", e.Message, e.GetType());
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
