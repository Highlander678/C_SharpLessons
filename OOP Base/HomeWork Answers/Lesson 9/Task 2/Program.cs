using System;

namespace DelegateCalculate
{
    class Program
    {
        delegate double MyDelegate(int a, int b); //Создание класса делегата

        static void Main()
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите оператор(+,-,*,/)");
            string z = Convert.ToString(Console.ReadLine());

            MyDelegate op = null; //создаем переменную op типа MyDelegate

            switch (z) //В соответствии с указанным знаком, производится математическая операция
            {
                case "+":
                    op = (x, y) => { return x + y; }; //лямбда-оператор
                    break;
                case "-":
                    op = (x, y) => { return x - y; };
                    break;
                case "*":
                    op = (x, y) => { return x * y; };
                    break;
                case "/":
                    op = (x, y) =>
                    {
                        if (y != 0)
                        {
                            return x / (double)y;
                        }
                        else
                        {
                            Console.WriteLine("На нуль делить нельзя!");
                            return 0;
                        }
                    };
                    break;
                default:
                    Console.WriteLine("Вы неправильно ввели знак операции!");
                    break;
            }
            Console.WriteLine(new string('-', 30)); //30 символов "-"
            if (op != null) //если делегат указывает на лямбда-оператор, отобразить результат
                Console.WriteLine("{0:##.###}", op(a, b)); //вызов метода сообщенного с делегатом op
            // Delay.
            Console.ReadKey();
        }
    }
}
