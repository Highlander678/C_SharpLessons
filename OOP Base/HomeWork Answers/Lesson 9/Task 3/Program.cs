using System;

namespace ArrayOfDelegates
{
    class Program
    {
        static Random rand = new Random(); //Статическое поле rand класса Random
        //Создание вложенных классов делегатов
        delegate int MyDelegate(); 
        delegate double MyDel(MyDelegate[] a);

        static int GetRandom() //Статический метод получения случайного числа
        {
            return rand.Next(100); //Метод Next возвращает неотрицательное случайное число в пределах максимального значения указаного пользователем в качестве аргумента
        }

        static void Main()
        {
            Console.WriteLine("Введите число элементов массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 50)); //50 символов "-"

            var array = new MyDelegate[n]; //Создание массива делегатов

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom).Invoke(); /*Создаем массив экземпляров класса делегата MyDelegate
                                                                      * и каждый делегат в этом массиве сообщаем с лямбда-выражением 
                                                                      * которое будет возвращать результат вызова екземпляра делегата MyDelegate 
                                                                      * созданого по слабой ссылке и сообщенного с методом  GetRandom   */
            }

            MyDel d = delegate(MyDelegate[] c)
                                            {
                                                double sr = 0; //Создание локальной переменной
                                                for (int i = 0; i < c.Length; i++)
                                                {
                                                    sr += c[i].Invoke();
                                                   
                                                }
                                                return sr / array.Length;//Вычисление среднего арифметического возвращаемых значений экземпляров делегатов массива с
                                            }; //Лямбда-метод

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Invoke() + " "); //Вызов лямбда-выражения сообщенного с делегатом
            }

            Console.WriteLine("\nСреднее арифметическое элементов {0:##.###}", d(array)); //Отображение результата вычисления среднего арифметического

            //Delay
            Console.ReadKey();
        }
    }
}
