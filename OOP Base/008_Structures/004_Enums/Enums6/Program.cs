using System;

// Перечисления. Значение по умолчанию для перечислений.

namespace Enums
{
    enum EnumType : byte 
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Five = 5,
        Six = 10,
        Nine = 4
    }

    class Program
    {
        static void Main()
        {
            // Переменной five типа EnumType может быть назначено любое значение, входящее в диапазон
            // базового типа, значения не ограничены именованными константами.

            EnumType five = (EnumType)15;

            Console.WriteLine(five);
            Console.WriteLine(""+(byte)EnumType.Five);
            Console.WriteLine((byte)EnumType.Nine);
            
            // Delay.
            Console.ReadKey();
        }
    }
}
