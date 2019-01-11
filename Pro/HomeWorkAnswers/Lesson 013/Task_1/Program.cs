using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            var myDelegate = new Action(Method);

            var callback = new AsyncCallback(HandleCompletion);

            myDelegate.BeginInvoke(callback, "Hello world");

            Console.ReadKey();
        }

        static void Method()
        {
            Console.WriteLine("Асинхронный метод запущен.");
            Console.WriteLine("Асинхронная операция завершена.\n");
        }

        static void HandleCompletion(IAsyncResult asyncResult)
        {
            Console.WriteLine("Информация связанная с асинхронной операцией - " + asyncResult.AsyncState);
        }
    }
}
