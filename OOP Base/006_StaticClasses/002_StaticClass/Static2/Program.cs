using System;

// Паттерн проектирования - Singleton.

namespace Static
{
    class Program
    {
        static void Main()
        {
            // Конструктор "protected" - невозможно использовать - new Singleton() 
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            if (instance1 == instance2)
                Console.WriteLine("Ссылки указывают на один экземпляр объекта.");            
            
            // Delay.
            Console.ReadKey();
        }
    }
}
