using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Block block1 = new Block(15, 12, 5, 7); //Создание экземпляра класса Block
            Block block2 = new Block(7, 12, 5, 15);

            Console.WriteLine(block1.ToString()); //Вызов метода ToString на экземпляре block1
            Console.WriteLine(block2.ToString());

            Console.WriteLine(new string(' ', 30));

            Console.WriteLine("Блок1 равно блок2 = {0} ", block1.Equals(block2)); //Сравнение экземпляров с помощью метода Equals

            if (block1.GetHashCode() == block2.GetHashCode()) //Сравнение двух экземпляров по значению которое вернет метод GetHashCode
            {
                Console.WriteLine("Периметры двух блоков равны");
            }
            else
            {
                Console.WriteLine("Периметры блоков не равны");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
