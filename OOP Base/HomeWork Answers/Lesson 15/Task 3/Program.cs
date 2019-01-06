using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            PriceTable priceTable = new PriceTable(); //Создание экземпляра класса PriceTable и инициализация конструктором по умолчанию

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(priceTable[i]); //Отображение содержимого priceTable
            }

            Console.WriteLine("Введите номер товара для поиска:");
            string product = Console.ReadLine();

            Console.WriteLine(priceTable[product]); //Отображение результата поиска

            // Delay.
            Console.ReadKey();
        }
    }
}
