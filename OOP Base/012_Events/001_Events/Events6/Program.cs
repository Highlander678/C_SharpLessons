﻿using System;

// События.

namespace Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    class Program
    {
        // Методы обработчики события.

        static private void Handler1()
        {
            Console.WriteLine("Обработчик события 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }

        static void Main()
        {
            MyClass instance = new MyClass();

            // Присоединение обработчиков событий.
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += new EventDelegate(Handler2);
            instance.MyEvent += delegate { Console.WriteLine("Анонимный метод 1."); };

            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Открепляем Handler2().
            instance.MyEvent -= new EventDelegate(Handler2);
            
            // Невозможно открепить ранее присоединенный анонимный метод.
            instance.MyEvent -= delegate { Console.WriteLine("Анонимный метод 1."); };

            instance.InvokeEvent();

            // Delay.
            Console.ReadKey();
        }
    }
}
