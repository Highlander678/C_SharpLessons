using System;

namespace Lessons_3
{
    class Program
    {
        static void Main()
        {
            //Создание нового екземпляра класса print класса ColorPrinter
            ColorPrinter print = new ColorPrinter(ConsoleColor.Yellow);
            print.Print("Hello"); //Вызов метода print

            Printer printUp = print;  //приведение экземпляра производного класса к базовому типу (UpCast).
            printUp.Print("Hello");

            ColorPrinter print1 = new ColorPrinter(ConsoleColor.Red);
            print1.Print("Hello");
           
            // Delay.
            Console.ReadKey();
        }
    }
}
