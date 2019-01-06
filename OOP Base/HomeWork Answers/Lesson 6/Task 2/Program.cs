using System;


namespace Task_2
{
    internal class Book //Класс Book
    {
        public void FindNext(string str) //Метод поиска
        {
            Console.WriteLine("Поиск строки : " + str); //Отобразит строку с указанным ключом для поиска
        }
    }

    internal static class FindAndReplaceManager //Статический класс
    {
        public static void FindNext(string str) //Все методы статического класса должны быть статическими
        {
            Book a = new Book(); //Создание екземпляра класса Book
            a.FindNext(str); //Вызов метода объекта класса Book
        }

        private class Program
        {
            private static void Main()
            {
                FindAndReplaceManager.FindNext("Hello"); //Вызов статического метода FindNext

                // Delay.
                Console.ReadKey();
            }
        }
    }
}
