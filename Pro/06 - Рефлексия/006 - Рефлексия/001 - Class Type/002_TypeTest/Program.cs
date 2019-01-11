using System;
using System.Reflection;

// РЕФЛЕКСИЯ - это процесс обнаружения типов во время работы программы.

namespace Type_test
{
    static class Program
    {
        // Получаем разную информацию о Class1.
        static void ListVariosStats(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " Информация о Class1" + "\n");
            Type t = cl.GetType();

            Console.WriteLine("Полное Имя:             {0}", t.FullName);
            Console.WriteLine("Базовый класс:          {0}", t.BaseType);
            Console.WriteLine("Абстрактный:            {0}", t.IsAbstract);
            Console.WriteLine("Это COM объект:         {0}", t.IsCOMObject);
            Console.WriteLine("Запрещено наследование: {0}", t.IsSealed);
            Console.WriteLine("Это class:              {0}", t.IsClass);
        }

        // Получаем информацию об Именах всех методов Class1.
        static void ListMethods(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " Методы класса Class1" + "\n");

            Type t = cl.GetType();
            MethodInfo[] mi = t.GetMethods(BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

            foreach (MethodInfo m in mi)
                Console.WriteLine("Method: {0}", m.Name);
        }

        // Получаем информацию об Именах полей Class1.
        static void ListFields(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " Поля класса Class1" + "\n");

            Type t = cl.GetType();
            FieldInfo[] fi =
                t.GetFields(BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic);

            foreach (FieldInfo f in fi)
                Console.WriteLine("Field: {0}", f.Name);
        }

        // Получаем список всех Свойств Class1.
        static void ListProps(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " Свойства класса Class1" + "\n");

            Type t = cl.GetType();
            PropertyInfo[] pi = t.GetProperties();

            foreach (PropertyInfo p in pi)
                Console.WriteLine("Свойство: {0}", p.Name);
        }

        // Получаем список всех Интерфейсов, поддерживаемых Class1.
        static void ListInterfaces(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " Интерфейсы класса Class1" + "\n");

            Type t = cl.GetType();

            Type[] it = t.GetInterfaces();

            foreach (Type i in it)
                Console.WriteLine("Интерфейс: {0}", i.Name);
        }

        // Получаем информацию обо всех конструкторах Class1.
        static void ListConstructors(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " Конструкторы класса Class1" + "\n");

            Type t = cl.GetType();
            ConstructorInfo[] ci = t.GetConstructors();

            foreach (ConstructorInfo m in ci)
                Console.WriteLine("Constructor: {0}", m.Name);
        }

        static void Main()
        {
            Console.SetWindowSize(80, 45);

            Class1 instance = new Class1();

            #region Вывод информации о типе

            ListVariosStats(instance);  // Получаем разную информацию о Class1.
            ListMethods(instance);      // Получаем информацию об Именах всех методов Class1.
            ListFields(instance);       // Получаем информацию об Именах всех полей Class1.
            ListProps(instance);        // Получаем список всех Свойств Class1.
            ListInterfaces(instance);   // Получаем список всех Интерфейсов, поддерживаемых Class1.
            ListConstructors(instance); // Получаем информацию об Именах всех конструкторов Class1.

            #endregion

            #region Обращение к закрытым членам.

            Console.WriteLine(new string('-', 60));

            Type type = instance.GetType();

            // Вызов private метода
            MethodInfo methodC = type.GetMethod("MethodC", BindingFlags.Instance | BindingFlags.NonPublic);
            methodC.Invoke(instance, new object[] { "Hello", " world!" });
            
            // Запись значения в private поле
            FieldInfo mystring = type.GetField("mystring", BindingFlags.Instance | BindingFlags.NonPublic);
            mystring.SetValue(instance, "Привет Мир!");

            Console.WriteLine(instance.MyString);

            #endregion

            // Delay.
            Console.ReadKey();
        }
    }
}
