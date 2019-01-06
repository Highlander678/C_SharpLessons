using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество элементов массива: ");

            //Создание целочисленного массива и инициализация значениями из стандартного входного потока приведенными в int
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];

            int min = 0, max = 0, sa = 0;

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            //В переменные min и max записывается значение array[0].
            min = array[0];
            max = array[0];

            //Оператор for
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) != 0)
                {
                    Console.WriteLine("Число не четное {0}", array[i]);
                }
                /* проверка значения min, является ли оно минимальным в массиве,
                   если нет то в значение переменной min записывается значение меньшего числа с масива array */
                if (min > array[i])
                {
                    min = array[i];
                }
                /* проверка значения max, является ли оно максимальным в массиве,
                   если нет то в значение переменной max записывается значение большего числа с масива array*/
                if (max < array[i])
                {
                    max = array[i];
                }
                //Сумирование елементов масива
                sa += array[i];
            }

            Console.WriteLine("Наибольший елемент {0}", max);
            Console.WriteLine("Наименьший елемент {0}", min);
            Console.WriteLine("Сумма елементов массива {0}", sa);
            Console.WriteLine("Среднее арифметическое {0}", sa / array.Length);

            // Delay.
            Console.ReadKey();
        }
    }
}
