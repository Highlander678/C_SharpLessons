using System;

namespace Lessons_7
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine(Calculator.Add(9, 71.5)); //Вызов статического метода сложения чисел
            Console.WriteLine(Calculator.Subtraction(90, 4.5));
            Console.WriteLine(Calculator.Multiply(10, 20));

            if (Calculator.Division(11, 5) != 0) //Проверка возможности деления, метод вернет нуль если в качестве делителя указан нуль
            {
                Console.WriteLine(Calculator.Division(11, 5));
            }
            else
            {
                Console.WriteLine("На нуль делить нельзя");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
