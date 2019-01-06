using System;

namespace Lessons_10
{
    class MyClass<T> where T : new()    /*where T : new() - ограничение параметра типа Т, 
                                         * означает что в качестве типа Т можно поставить 
                                         * только тот тип у которого есть открытый конструктор 
                                         * по умолчанию */
    {
        public static T FacrotyMethod() //Обобщенный метод возвращающий значение типа указателя места заполнения типом 
        {
            return new T();
        }
    }

    class Program
    {
        static void Main()
        {
            int i = MyClass<int>.FacrotyMethod(); //Закрываем экземпляр класса MyClass типом int и записываем результат выполнения метода FacrotyMethod в локальную переменную i

            Console.WriteLine(i.GetType().Name); //Метод отображает имя типа переменной i

            Program p = MyClass<Program>.FacrotyMethod(); //Создаем переменную типа Program

            Console.WriteLine(p.GetType().Name); //Метод отображает имя типа переменной p

            Console.ReadKey();
        }
    }
}
