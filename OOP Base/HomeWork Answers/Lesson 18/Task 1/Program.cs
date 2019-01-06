using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Dictionary; //Подключение пространства имен Dictionary который содержит класс MyDictionary

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            MyDictionary<char, string> dictionary = new MyDictionary<char, string>(); //Создание экземпляра класса MyDictionary
            dictionary.Add('a', "Эй"); //Добавление значений в словарь
            dictionary.Add('b', "Би");
            dictionary.Add('c', "Си");
            dictionary.Add('d', "Ди");

            Console.WriteLine(dictionary['b']); //Отображение результата поиска в словаре с помощью индексатора

            foreach (string pair in dictionary)
                Console.WriteLine(pair); //Отображение содержимого словаря

            Console.ReadKey();
        }
    }
}
