
extern alias T2; //С помощью  alias подключаем пространство имен Task_2_1


namespace Namespaces
{
    class Program
    {
        static void Main()
        {
            T2.Task_2_1.MyClass my = new T2.Task_2_1.MyClass(); //Создание экземпляра класса описаного в пространстве имен T2.Task_2_1

            my.Method(); //Вызов метода Method класса MyClass

            // Delay.
            System.Console.ReadKey();
        }
    }
}
