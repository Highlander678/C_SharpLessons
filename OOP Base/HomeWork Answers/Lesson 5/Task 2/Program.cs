using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            MyArray ar = new MyArray(8); //Создание экземпляра класса

            ar.MinMax(); //Вызов метода нахождения минимального и максимального значения
            ar.Average();//Вызов метода нахождения среднего арифметического
            ar.Odd();    //Вызов метода отображения нечетных чисел

            // Delay.
            Console.ReadKey();
        }
    }
}
