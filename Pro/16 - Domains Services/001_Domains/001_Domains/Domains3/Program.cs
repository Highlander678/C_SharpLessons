using System;
using System.Runtime.Remoting;
using System.Runtime.ExceptionServices;

using System.Reflection;

// Обработка исключений.

namespace Domains
{
    class MyClass : MarshalByRefObject
    {
        public void Operation()
        {
            throw new Exception("Ошибка в методе Operation!");
        }
    }

    class Program
    {
        static void Main()
        {
            AppDomain domain = AppDomain.CreateDomain("Second Domain");
            domain.FirstChanceException += Domain_FirstChanceException;
            
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            string typeName = typeof(MyClass).FullName;

            ObjectHandle handle = domain.CreateInstance(assemblyName, typeName);

            MyClass instance = handle.Unwrap() as MyClass;

            try
            {
                instance.Operation();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nОбработчик исключения try-catch");
                Console.WriteLine("Исключение возникло в домене : {0}", domain.FriendlyName);
                Console.WriteLine("ex.Message                   : {0}", ex.Message);
            }

            Console.WriteLine("\nДомен {0} работоспособен.", AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("Домен {0} работоспособен.", domain.FriendlyName);

            // Delay
            Console.ReadKey();
        }

        static void Domain_FirstChanceException(object sender, FirstChanceExceptionEventArgs e)
        {
            AppDomain domain = sender as AppDomain;

            Console.WriteLine("Обработчик события FirstChanceException");
            Console.WriteLine("Исключение возникло в домене : {0}", domain.FriendlyName);
            Console.WriteLine("e.Exception.Message          : {0}", e.Exception.Message);
        }
    }
}
