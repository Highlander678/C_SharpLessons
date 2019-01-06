using System;

namespace Additiontask
{
    class Program
    {
        static void Main()
        {
            //Запрос слова для перевода у пользователя
            Console.WriteLine("Введите слово про погоду на русском языке:");
            //Считывание слова
            string word = Console.ReadLine();

            switch (word) //word — выражение-селектор. 
            {
                case "температура": Console.Write("temperature"); // "температура" — постоянное выражение 
                    break;
                case "фаренгейт": Console.Write("Fahrenheit");
                    break;
                case "цельсий": Console.Write("Celsius");
                    break;
                case "облачно": Console.Write("cloudy");
                    break;
                case "солнечно": Console.Write("sunny");
                    break;
                case "дождь": Console.Write("rain");
                    break;
                case "ветренно": Console.Write("windy");
                    break;
                case "тепло": Console.Write("warmly");
                    break;
                case "холодно": Console.Write("coldly");
                    break;
                //Выполняется в случае, когда нету подходящего постоянного выражения.
                default:
                    Console.WriteLine("Такого слова нет в словаре!");
                    break;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
