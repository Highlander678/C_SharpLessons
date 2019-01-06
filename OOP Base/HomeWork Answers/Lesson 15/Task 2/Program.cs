using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Company comp = new Company(); //Создание экземпляра класса Company
            Console.WriteLine(comp[5]); //Отображение результата вызова индексатора

            // Delay.
            Console.ReadKey();
        }
    }
}
