using System;
using System.Diagnostics;
using System.Runtime;
using System.Threading;

// Серверный (параллельный) GC используется при наличии истинной многозадачности,
// для организации которой требуется многоядерный процессор.

// Параллельный GC является эффективным при работе с объектами у которых имеется деструктор, 
// для объектов без деструктора прироста в производительности не наблюдается.

namespace ParallelGC
{
    class MyClass
    { 
        // Для тестирования требуется закоментировать деструктор.
        ~MyClass()
        {
            Thread.Sleep(10000);
        }
    }
    class Program
    {
        static void Main()
        {
            // Для включения серверного (параллельного) GC
            // требуется в AppConfig добавить теги: 
            // <runtime><gcServer enabled="true"/></runtime>
            Console.WriteLine("Приложение обслуживает серверный (параллельный) GC = " 
                + GCSettings.IsServerGC);

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 10000000; i++)
            {
                new MyClass();
            }

            timer.Stop();

            Console.WriteLine(timer.ElapsedMilliseconds);
        }
    }
}
