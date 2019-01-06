using System;

namespace Task_2
{
    class MyArray
    {
        int[] array; //Создание одномерного массива

        public MyArray(int n) //Пользовательский конструктор
        {
            array = new int[Math.Abs(n)]; //метод Math.Abs возвращает абсолютное значение заданого числа
            Random random = new Random(); //Класс Random предоставляет генератор псевдослучайных чисел
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 40);//random.Next возвращает случайное целое число в указаном диапазоне
                Console.Write("{0}, ", array[i]);
            }
        }

        public void MinMax() //Метод класса позволяющий найти минимальное и максимальное значение из массива
        {
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);//Метод возвращает максимальное из принятых значений
                min = Math.Min(min, array[i]);//Метод возвращает минимальное из принятых значений
            }
            Console.WriteLine("\nMax = {0}; Min = {1}", max, min); //Отображение результата нахождения
        }

        public int Sum() //Метод суммирование элементов
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; //Суммирование
            }
            Console.Write("Sum = {0}, ", sum); //Отобрадение результата суммирования
            return sum; 
        }

        public void Average() //Метод для вычисления среднего арифметического всех элементов массива
        {
            Console.WriteLine("Average = {0}, ", Sum() / array.Length); //Сумму всех элементов делим на количество
        }

        public void Odd() //Метод отображения нечетных значений
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) //Если при делении числа на два с остачей будет 0, тогда это число нечетное
                {
                    Console.Write("{0} ", array[i]);
                }
            }
        }

    }
}
