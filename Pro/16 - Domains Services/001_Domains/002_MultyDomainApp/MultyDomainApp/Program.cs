using System;

// Загрузка исполняемых файлов в домен.

// Для выполнения этого проекта требуется скопировать исполняемые файлы App1.exe и App2.exe 
// в папку с исполняемым файлом MultyDomainApp.exe

namespace MultyDomainApp
{
    class Program
    {
        static void Main()
        {
            // Создание доменов.
            AppDomain domain1 = AppDomain.CreateDomain("Domain 1");
            AppDomain domain2 = AppDomain.CreateDomain("Domain 2");

            try
            {
                // Запуск приложений в контексте вторичных доменов.
                domain1.ExecuteAssembly("App1.exe");
                domain2.ExecuteAssembly("App2.exe");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nГлавный домен {0} продолжает работать.", 
                AppDomain.CurrentDomain.FriendlyName);

            // Delay
            Console.ReadKey();
        }
    }
}
