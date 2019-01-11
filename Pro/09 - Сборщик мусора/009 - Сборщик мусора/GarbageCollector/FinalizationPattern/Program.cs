using System;

// Шаблон Microsoft для освобождения ресурсов.
// Данный паттерн гарантирует, что пользователь, 
// сможет многократно вызывать метод Dispose().

namespace FinalizationPattern
{
    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            for (int i = 0; i < 10; i++)
                my.Dispose();
        }
    }
}
