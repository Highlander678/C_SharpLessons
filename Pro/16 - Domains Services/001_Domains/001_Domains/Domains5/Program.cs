using System;
using System.Runtime.Remoting;
using System.Runtime.ExceptionServices;

using System.Reflection;

// Обработка исключений.

namespace Domains
{
    class MyClass : MarshalByRefObject
    {
        public void Operation1()
        {
            Console.WriteLine("MyClass.Operation1 {0}", this.GetHashCode());

            throw new Exception("Ошибка в методе Operation1");
        }

        public void Operation2()
        {
            Console.WriteLine("MyClass.Operation2 {0}", this.GetHashCode());
        }
    }

    class Program
    {
        static void Main()
        {
            AppDomain domain = AppDomain.CreateDomain("Second Domain");

            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            string typeName = typeof(MyClass).FullName;

            ObjectHandle handle = domain.CreateInstance(assemblyName, typeName);

            MyClass instance = handle.Unwrap() as MyClass;

            try
            {
                instance.Operation1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex.Message: {0}", ex.Message);
            }

            instance.Operation2();

            // Delay
            Console.ReadKey();
        }
    }
}
