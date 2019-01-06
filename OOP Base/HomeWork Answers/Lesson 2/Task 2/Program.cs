using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            //Создание екземпляра класса Converter
            Converter converter = new Converter(8.56, 10.14, 0.12);

            //Вызов метода конвертирования из Гривны в Доллар
            converter.ToUsd(120);

            //Вызов метода конвертирования из Доллара в Гривну
            converter.FromUsd(120);

            //Delay
            Console.ReadKey();
        }
    }
}
