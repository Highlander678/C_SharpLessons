using System;
using System.Threading;
using System.Threading.Tasks;

namespace monitor
{
    class Program
    {
        static private int counter = 0;

        static private object block = new object();

        static private void Function()
        {
            lock (block)
            {
                for (int i = 0; i < 10; ++i)
                {
                    Console.WriteLine("{0} из потока {1}", ++counter, Thread.CurrentThread.GetHashCode());
                }
            }
        }

        

        static void Main()
        {
            Thread[] threads = { new Thread(Function), new Thread(Function), new Thread(Function) };

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }

            Console.ReadKey();
        }
    }
}
