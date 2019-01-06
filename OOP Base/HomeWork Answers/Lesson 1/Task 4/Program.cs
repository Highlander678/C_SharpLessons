using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            //Создание объекта класса Figure и передача конструктору трех объектов класса Point в качестве аргументов.  
            Figure figure = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4));

            //Отображение результата выполнения метода Type.
            Console.Write("{0}, P = ", figure.Type );

            //Вызов метода PerimeterCalculator для вычисления периметра фигуры.
            figure.PerimeterCalculator();

            // Delay.
            Console.ReadKey();

        }
    }
}
