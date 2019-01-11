using System;
using System.Threading;

namespace Task_1
{
        class Work
        {
            readonly AutoResetEvent auto;
            readonly Thread thread;

            public Work(string name, AutoResetEvent auto)
            {
                this.thread = new Thread(this.Run) { Name = name };
                this.auto = auto;
                this.thread.Start();
            }

            void Run()
            {
                Console.WriteLine("Запущен поток " + thread.Name);

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(200);
                }

                Console.WriteLine("\nПоток " + thread.Name + " завершен");

                auto.Set();
            }
        }

        class ManualEventDemo
        {
            static void Main()
            {
                var auto = new AutoResetEvent(false);

                var thread = new Work("1", auto);
                Console.WriteLine("Основной поток ожидает событие.\n");

                auto.WaitOne();  
                Console.WriteLine("\nОсновной поток получил уведомление о событии от первого потока.\n");

                thread = new Work("2", auto);
                Console.WriteLine("Основной поток ожидает событие.\n");

                auto.WaitOne(); 
                Console.WriteLine("\nОсновной поток получил уведомление о событии от второго потока.");

                // Delay.
                Console.ReadKey();
            }
        }
    }
