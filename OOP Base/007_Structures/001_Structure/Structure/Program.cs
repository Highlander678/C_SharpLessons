using System;

// Структуры.

// В структурах нельзя инициализировать поля непосредственно в месте создания.

namespace Structure
{
    struct MyStruct
    {
        public static int field;
        public int inner;

    class Program
    {
        static void Main()
        {
            MyStruct.field = 1;
            Console.WriteLine("Значение поля field = " + MyStruct.field);
            // Создание экземпляра структурного типа, без вызова конструктора.
            MyStruct instance;

            instance.inner = 1; // Закомментировать.

            // Попытка вывода значения неинициализированного поля приведет к ошибке.
            //Console.WriteLine(instance.field);

            // Delay.
            Console.ReadKey();
        }
    }
}
