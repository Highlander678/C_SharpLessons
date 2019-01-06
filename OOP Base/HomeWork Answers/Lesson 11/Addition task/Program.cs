using System;
using System.Collections;

namespace Lessons_11
{
    class MyClass //Создание класса
    {
        public int MyIntProperty { get; set; } //Автоматическое свойство
        public string MyStringProperty { get; set; }
    }

    class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList(); //Коллекция может хранить в себе разнотипные значения (гетерогенная коллекция)
            arrayList.Add(0); //Добавление нового элемента в коллекцию
            arrayList.Add(0.67);
            arrayList.Add('a');
            arrayList.Add("elem");
            arrayList.Add(new MyClass()); //Добаление в коллекцию нового элемента - экземпляра класса MyClass

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]); //Отображение элементов коллекции
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
