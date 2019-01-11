using System;
using System.Reflection;
using System.Runtime.Remoting;

// Создание доменов.

namespace Domains
{
    // MarshalByRefObject - разрешает доступ к объектам через границы доменов приложения 
    // в приложениях, поддерживающих удаленное взаимодействие (MSDN).

    //[Serializable] // Снять комментарий с аттрибута и закомментировать наследование от MarshalByRefObject
    class MyClass : MarshalByRefObject
    {
        public void Operation()
        {
            Console.WriteLine("Метод Operation выполняется в домене : {0}",
                AppDomain.CurrentDomain.Id);
            
            Console.WriteLine("instance {0}", this.GetHashCode());
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Метод Main выполняется в домене      : {0}",
                AppDomain.CurrentDomain.Id);

            // Создание второго домена приложения.
            AppDomain domain = AppDomain.CreateDomain("Second Domain");

            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            string typeName = typeof(MyClass).FullName;

            // Создание объекта во втором домене.
            ObjectHandle handle = domain.CreateInstance(assemblyName, typeName);

            // Создание прозрачного прокси-переходника для взаимодействия с объектом во втором домене.
            MyClass instance = handle.Unwrap() as MyClass;

            Console.WriteLine("instance {0}", instance.GetHashCode());

            // Проверка: Действительно ли прозрачный переходник предоставлен?
            Console.WriteLine("IsTransparentProxy(instance) : {0}",
                RemotingServices.IsTransparentProxy(instance));

            // Вызов метода объекта, находящегося во втором домене.
            instance.Operation();

            // Delay
            Console.ReadKey();
        }
    }
}
