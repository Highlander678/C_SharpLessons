using System;
using System.Reflection;

// Глобальные атрибуты для всей сборки.
[assembly: AssemblyVersionAttribute("1.0.2000.0")]      // Версия сборки.
[assembly: AssemblyTitle("AssemblySmpl")]               // Имя сборки.
[assembly: AssemblyDescription("")]                     // Описание сборки.
[assembly: AssemblyConfiguration("")]                   // Конфигурация, например, Release или Debug.
[assembly: AssemblyCompany("CyberBionic Systematics")]  // Имя компании разработчика.
[assembly: AssemblyProduct("AssemblySmpl")]             // Имя продукта.
[assembly: AssemblyCopyright("Copyright 2009")]         // Копирайты.
[assembly: AssemblyTrademark("")]                       // Торговая марка.
[assembly: AssemblyCulture("")]                         // Какие культуры поддерживает сборка. 

namespace AssemblySmpl
{
    public class Program
    {
        public static void Main()
        {
            // Получение сборки (Assembly assembly) код которой выполняется в данный моемент.
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Полное имя сборки.
            Console.WriteLine("Assembly Full Name:\n{0}", assembly.FullName);

            // AssemblyName - позволяет разбить полное имя сборки на части.
            AssemblyName assemblyName = assembly.GetName();

            Console.WriteLine("\nИмя сборки: {0}", assemblyName.Name);
            Console.WriteLine("Версия сборки: {0}.{1}", assemblyName.Version.Major, assemblyName.Version.Minor);
            Console.WriteLine("\nМесто хранения сборки: \n{0}", assembly.CodeBase);

            // Точка входа сборки.
            Console.WriteLine("\nAssembly entry point:");

            Console.WriteLine(assembly.EntryPoint);

            // Delay.
            Console.ReadKey();
        }
    }
}
