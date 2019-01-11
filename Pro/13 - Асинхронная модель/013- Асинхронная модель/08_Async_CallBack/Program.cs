using System;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            Func<int, int, int> func = new Func<int, int, int>(Sum);

            func.BeginInvoke(1, 2, CallBack, "a + b = {0}");

            Console.WriteLine("Первичный поток завершил работу.");

            // Delay
            Console.ReadKey();
        }

        // Метод для выполнения в отдельном потоке.
        static int Sum(int a, int b)
        {
            // Thread.CurrentThread.IsBackground = false;

            Console.WriteLine("Вторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            return a + b;
        }

        // Метод обработки завершения асинхронной операции.
        static void CallBack(IAsyncResult asyncResult)
        {
            // Получение экземпляра делегата, на котором была вызвана асинхронная операция.
            AsyncResult ar = asyncResult as AsyncResult;
            Func<int, int, int> caller = (Func<int, int, int>)ar.AsyncDelegate;

            // Получение результатов асинхронной операции.
            int sum = caller.EndInvoke(asyncResult);

            string result = string.Format(asyncResult.AsyncState.ToString(), sum);
            Console.WriteLine("Результат асинхронной операции: " + result);
        }
    }
}
