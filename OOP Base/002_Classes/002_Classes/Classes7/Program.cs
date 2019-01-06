using System;

// Использование техники фабричных методов.

namespace Classes
{
    class Product
    {
        public Product()
        {
            Console.WriteLine("Создан экземпляр класса Product");
        }
    }

    class Factory : Product
    {
        public Product Factory()
        {
            return new Product();
        }
    }

    class Program
    {
        static void Main()
        {
            Factory factory = new Factory();

            Product product = factory.Factory();

            // Delay.
            Console.ReadKey();
        }
    }
}
