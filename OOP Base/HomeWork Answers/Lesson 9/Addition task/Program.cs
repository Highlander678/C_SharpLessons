using System;

namespace Lambda
{
    class Program
    {
        private delegate double Mydelegate(int a, int b, int c); // Создание класса делегата

        static void Main()
        {
            Console.WriteLine("Введите первое число");
            int i = Convert.ToInt32(Console.ReadLine()); //Запись полученных данных от пользователя конвертирование в int

            Console.WriteLine("Введите второе число");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            int k = Convert.ToInt32(Console.ReadLine());

            Mydelegate del = (a, b, c) => (double)(a + b + c) / 3; //Лямбда-выражение
            Console.WriteLine("Среднее арифметическое введенных числел {0:##.###}", del(i, j, k)); //Отображение результата вызова метода связаного с делегатом

            // Delay.
            Console.ReadKey();
        }
    }
}
