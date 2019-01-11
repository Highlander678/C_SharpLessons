using System;
using System.Threading;

namespace Task_2
{
    class Program
    {
        private static readonly Mutex Mutex1 = new Mutex(false, "MutexSample:AAED7056-380D-412E-9608-763495211EA8");

        static void Main()
        {
            Mutex1.WaitOne();

            Console.WriteLine("Поток {0} зашел в защищенную область.", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0}  покинул защищенную область.\n", Thread.CurrentThread.Name);

            Console.ReadKey();
            Mutex1.ReleaseMutex();
        }
    }
}
