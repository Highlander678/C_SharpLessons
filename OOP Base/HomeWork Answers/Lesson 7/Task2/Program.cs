using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            var train = new Train[2]; //Создание массива типа Train из двух элементов 

            MyClass.AddingAnArray(train); //Вызов метода для создания нового екземпляра класса Train
            Console.WriteLine(new string('-', 50)); //50 почеркиваний

            Console.WriteLine("Вы ввели такую информацию о поездах:");
            Console.WriteLine(new string('-', 50)); ; //50 почеркиваний

            MyClass.Sort(train);//Вызов метода сортировки массива
            MyClass.Show(train); //Вызов метода отображения содержимого массива

            Console.WriteLine(new string('-', 50));//50 почеркиваний

            Console.WriteLine("Введите номер поезда:");
            int poisk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 50));//50 почеркиваний
            MyClass.Search(train, poisk); //Поиск в массиве

            //Delay.
            Console.ReadKey();
        }
    }
}
