using System;
using System.Collections;

namespace Lessons_14
{
    class Program
    {
        static IEnumerable FindEven(int[] arr) //Статический метод принимающий в качестве параметра массив целых чисел и возвращающий значения типа IEnumerable
        {
            if (arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] % 2 == 0)
                        yield return arr[i]; //Оператор yield - это оператор генерации программых кодов коллекции
            }
            else
            {
                yield break;
            }

        }

        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; //Массив целочисленных элементов
            IEnumerable res = FindEven(array); //В переменную res типа IEnumerable записывем результат выполнения метода FindEven который принимает массив array
            foreach (int elem in res)
                Console.Write("{0}  ", elem); //Отображаем элементы коллекции
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
