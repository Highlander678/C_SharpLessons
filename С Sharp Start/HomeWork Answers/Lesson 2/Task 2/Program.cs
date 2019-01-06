using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            //Создание и инициализация переменных строкового типа.
            //Управляющий символ \n перемещает курсор на одну строку вниз.
            string a = "\nмоя строка 1";
            //Управляющий символ \t перемещает курсор к следуйщей позиции горизонтальной таболяции.
            string b = "\tмоя строка 2 \aмоя строка 3";
            //Управляющий символ \a ничего не напечатает, но издаст звуковой сигнал.
            string c = "\aмоя строка 3";

            //Отображение значений переменных a,b,c на консоль.
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.Beep();

            // Delay.
            Console.ReadKey();
        }
    }
}
