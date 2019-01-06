using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            MyMatrix m = new MyMatrix(4, 5); //Создание екземпляра класса MyMatrix
            m.Show(); //Вызов метода отображения созданой матрицы

            Console.WriteLine(new string('-', 30)); //Отрисовка 30 символов "-"
            Console.WriteLine("[1][2] = {0}", m[1, 2]); //Отображение элемента за указаными координатами
            Console.WriteLine("[6][2] = {0}", m[6, 2]);
            m[0, 0] = 11; //Присвоение полю с координатами (0,0) значения 11

            Console.WriteLine(new string('-', 30));
            m.ChangeSize(7, 6); //Вызов метода изменения размерности матрицы
            m.Show(); //Вызов метода отображения матрицы

            Console.WriteLine(new string('-', 30));
            m.ShowPartly(1, 0, 4, 4); //Вызов метода частичного отображения матрицы

            //Delay
            Console.ReadKey();
        }
    }
}
