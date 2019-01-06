using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите превую сторону прямоугольника");
            //Считывание значений из стандартного входного потока в переменную side
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону прямоугольника");
            //Считывание значений из стандартного входного потока в переменную side2
            double side2 = Convert.ToDouble(Console.ReadLine());

            //Создание экземпляра класса и передача в пользовательский конструктор двух аргументов
            Rectangle rectangle = new Rectangle(side1, side2);
            //Отображение периметра и площади прямоугольника
            Console.WriteLine("Perimeter = {0}, Area= {1}", rectangle.Perimeter, rectangle.Area);

            // Delay.
            Console.ReadKey();
        }
    }
}
