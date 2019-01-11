using System;
using System.Threading;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            Action myDelegate = new Action(Method);

            IAsyncResult asyncResult = myDelegate.BeginInvoke(null, null);

            // Ожидание завершения асинхронной операции (вторичного потока).
            myDelegate.EndInvoke(asyncResult); // Join() 

            Console.WriteLine("Первичный поток завершил работу.");

            // Delay
            Console.ReadKey();
        }

        // Метод для выполнения в отдельном потоке.
        static void Method()
        {
            Console.WriteLine("Вторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(100);
                Console.Write("2 ");
            }
        }
    }
}
