using System;
using System.Text.RegularExpressions;

namespace AdditionTask
{
    class Program
    {
        static void Main()
        {
            string petternLogin = @"^[A-Za-z]+$";
            string petternPassword = @"^[A-Za-z0-9\S]+$";

            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            if (!Regex.IsMatch(login, petternLogin))
            {
                Console.WriteLine("Вы ввели логин который не соответствует шаблону!");
                return;
            }

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            if (!Regex.IsMatch(password, petternPassword))
            {
                Console.WriteLine("Вы ввели пароль который не соответствует шаблону!");
                return;
            }

            Console.WriteLine("Вы зарегестрированы!");
            Console.ReadKey();
        }
    }
}
