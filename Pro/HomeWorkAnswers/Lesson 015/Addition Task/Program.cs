using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Addition_Task
{
    class Program
    {
        static private int counter = 0;

        static private object block = new object();

        static private async Task Function()
        {
            await Task.Run(() =>
            {
                lock (block)
                {
                    for (int i = 0; i < 10; ++i)
                    {
                        Console.WriteLine("{0} из потока {1}", ++counter, Thread.CurrentThread.GetHashCode());
                    }
                }
            });
        }



        static void Main()
        {
            Task t1 = Function();
            Task t2 = Function();
            Task t3 = Function();

            Task.WaitAll(t1, t2, t3);

            Console.ReadKey();
        }
    }
}
