using System;

namespace Task_4
{
    class Program
    {
        static void IncreaseArray(ref int[] array)
        {
            //Создание и инициализация массива целых чисел.
            int[] tempArray = new int[array.Length + 1];

            //Заполнение массива tempArray.
            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i <= array.Length - 1)
                {
                    tempArray[i] = array[i];
                }
                else
                {
                    tempArray[i] = 0;
                }
            }

            //Присвоение входящему массиву array массив tempArray.
            array = tempArray;
        }

        static int[] ChangeArray(int[] array, int value)
        {
            //Создание массива с длиной массива array увеличенной на единицу.
            int[] tempArray = new int[(array.Length + 1)];

            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i == 0)
                {
                    //В первый элемент массива записывается значение переменной value переданной в метод в качестве аргумента.
                    tempArray[i] = value;
                }
                if ((i > 0) && (i <= array.Length))
                {
                    //Запись элементов массива array в конец массива temp Array с сохранением последовательности элементов.
                    tempArray[i] = array[i - 1];
                }
            }

            return tempArray;
        }

        static void PrintArray(int[] array)
        {
            //Отображение массива
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Введите количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            //Заполнение массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            PrintArray(array);
            IncreaseArray(ref array);
            PrintArray(array);

            int[] array2 = ChangeArray(array, 99);
            PrintArray(array2);

            // Delay.
            Console.ReadKey();
        }
    }
}
