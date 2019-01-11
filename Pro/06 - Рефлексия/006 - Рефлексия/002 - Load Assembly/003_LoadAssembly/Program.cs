using System;
using System.IO;
using System.Reflection;

// Для тестирования данного примера, необходимо,
// скопировать библиотеку CarLibrary.dll из примера 001_CarLibrary, в папку с *.ехе файлом

namespace LoadAssembly
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 50);

            // При помощи класса Assembly - можно динамически загружать сборки, 
            // обращаться к членам класса в процессе выполнения (ПОЗДНЕЕ СВЯЗЫВАНИЕ),
            // а так же получать информацию о самой сборке.
            Assembly assembly = null;

            try
            {
                // Assembly.Load() - метод для загрузки сборки.
                assembly = Assembly.Load("CarLibrary"); // LoadFrom(...)
                Console.WriteLine("Сборка CarLibrary - успешно загружена.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Выводим информацию о всех типах в сборке.
            ListAllTypes(assembly);
            // Выводим информацию о всех членах в классе.
            ListAllMembers(assembly);
            // Выводим информацию о всех параметрах метода.
            GetParams(assembly);

            // Delay.
            Console.ReadKey();
        }

        // Метод для получения информации о всех типах в сборке.
        private static void ListAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));
            Console.WriteLine("\nТипы в: {0} \n", assembly.FullName);

            Type[] types = assembly.GetTypes();

            foreach (Type t in types)
                Console.WriteLine("Тип: {0}", t);
        }

        // Метод для получения информации о членах класса.
        private static void ListAllMembers(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));

            Type type = assembly.GetType("CarLibrary.MiniVan");

            Console.WriteLine("\nЧлены класса: {0} \n", type);

            MemberInfo[] members = type.GetMembers();

            foreach (MemberInfo element in members)
                Console.WriteLine("{0,-15}:  {1}", element.MemberType, element);
        }

        // Получаем информацию о параметрах для метода TurboBoost() 
        private static void GetParams(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));

            Type type = assembly.GetType("CarLibrary.MiniVan");
            MethodInfo method = type.GetMethod("Driver"); // Equals , Acceleration, Driver

            // Вывод информации о количестве параметров.
            Console.WriteLine("\nИнформация о параметрах для метода {0}", method.Name);
            ParameterInfo[] parameters = method.GetParameters();
            Console.WriteLine("Метод имеет " + parameters.Length + " параметров");

            // Выводим некоторые характеристики каждого из параметров. 
            foreach (ParameterInfo parameter in parameters)
            {
                Console.WriteLine("Имя параметра: {0}", parameter.Name);
                Console.WriteLine("Позиция в методе: {0}", parameter.Position);
                Console.WriteLine("Тип параметра: {0}", parameter.ParameterType);
            }
        }
    }
}
