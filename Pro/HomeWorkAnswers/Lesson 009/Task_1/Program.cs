#define v2

using System;
using System.Threading;

namespace Task_1
{
    class MonitorMemory
    {
        readonly int memoryLimit;

        public MonitorMemory(int memoryLimit)
        {
            this.memoryLimit = memoryLimit;
        }

        bool IsMemoryLimitExceeded()
        {
            return this.memoryLimit < GC.GetTotalMemory(false);
        }

        public void WarnIfMemoryLimitExceeded(object errorMessage)
        {
            if (IsMemoryLimitExceeded())
            {
                Console.WriteLine("{0}", errorMessage);
            }
        }

    }

    class LargeObject
    {
        int[] array = new int[100000000]; // 100 000 000 Б * 4 = 400 000 000 Б = 390 625 КБ = 381 МБ

        public void Method(int i)
        {
            Console.WriteLine(i);
        }
    }

    class Program
    {
        static void Main()
        {

            Timer timer = new Timer(new MonitorMemory(100000000).WarnIfMemoryLimitExceeded, "Warning memory out", 0, 200);

            LargeObject[] array = new LargeObject[1000];

            for (int i = 0; i < array.Length; i++)
            {
                new LargeObject().Method(i);
            }

            Console.ReadKey();
        }
    }
}

