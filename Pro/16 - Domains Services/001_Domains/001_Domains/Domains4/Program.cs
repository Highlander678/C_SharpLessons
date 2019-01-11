using System;
using System.Threading;
using System.Runtime.Remoting;

// Протекание потока через домены.

// Данная программа показывает, что на протяжении жизни приложения, 
// два домена работают в контексте одного потока. При этом не использовалось 
// никаких специальных средств для координирования взаимодействия потоков и доменов.
// Соответственно, связи между доменами и потоками нет.

namespace Domains
{
    class MyClass : MarshalByRefObject
    {
        public void Operation()
        {
            Console.WriteLine("Operation DomainId : {0}", AppDomain.CurrentDomain.Id);
            Console.WriteLine("Operation ThreadId : {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }

    class Program
    {
        static void Main()
        {
            AppDomain domain = AppDomain.CreateDomain("Second Domain");

            ObjectHandle handle = domain.CreateInstance("Domains", "Domains.MyClass");

            // Создание прозрачного прокси-переходника для взаимодействия с объектом из другого домена.
            MyClass instance = handle.Unwrap() as MyClass;

            Console.WriteLine("Main DomainId      : {0}", AppDomain.CurrentDomain.Id);
            Console.WriteLine("Main ThreadId      : {0}", Thread.CurrentThread.ManagedThreadId);

            // Вызов метода объекта, находящегося во втором домене.
            instance.Operation();

            // Delay
            Console.ReadKey();
        }
    }
}
