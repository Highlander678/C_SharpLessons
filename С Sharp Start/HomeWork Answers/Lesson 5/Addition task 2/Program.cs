using System;

namespace Addition_task_2
{
    class Program
    {
        static void Main()
        {
            //Создание и инициализация переменной логического типа
            bool A = true, B = false;

            //Отображение результата логической операции ИЛИ для переменных A и B
            Console.WriteLine("{0} || {1} = {2}", A, B, A || B);

            //Отображение результата логической операции ОТРИЦАНИЯ для переменных A и B
            Console.WriteLine("!(!{0} && !{1}) = {2}", A, B, !(!A & !B));

            // Delay.
            Console.ReadKey();
        }
    }
}
