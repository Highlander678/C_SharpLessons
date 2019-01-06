using System;

namespace Task_3
{
    class Program
    {
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //Отображение массива
                Console.Write(array[i]+ " ");
            }
            
        }
        static int[] MyReverse(int[] array)
        {
            int buf = 0;
            //С помощью Length получаем целое число, представляющее общее число элементов в массиве Array
            int n = array.Length;
            int j = n - 1;

            //Ниже представлен алгоритм инвертирования массива
            for (int k = 0; k < j; k++)
            {
                buf = array[k];
                array[k] = array[j];
                array[j] = buf;
                j--;
            }

            return array;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            //Объявление массива целых чисел
            int[] tempArray = new int[count];
            //Переменная, которая будет индексом, для нового массива (tempArray)
            int k = 0;

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (array.Length > index)
                {
                    tempArray[k] = array[index];
                }
                else
                {
                    tempArray[k] = 1;
                }

                index++;
                k++;
            }
            return tempArray;
        }

        static void Main()
        {
            int[] array = new int[10];

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }


            Console.Write("Введите индекс массива:");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество елементов:");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Начальный масив:");
            //Вызов метода для отображения массива
            PrintArray(array);
            Console.WriteLine("\n ");
            //Запись в массив array массив возвращенный матодом SubArray
            array = SubArray(array, index, count);
            //Вызов метода для отображения массива
            PrintArray(array);
            Console.WriteLine(" ");
            array = new int[10];

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

            array = MyReverse(array);

            Console.Write(new string('-', 30) + "\n");

            //Вызов метода для отображения массива
            PrintArray(array);

            // Delay.
            Console.ReadKey();
        }
    }
}
