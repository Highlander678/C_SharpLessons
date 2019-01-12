// В данном консольном приложении Visual C# используем функции Visual Basic.
// Приложение приглашает пользователя ввести два числа, анализирует числа
// ли ввел пользователь и выводит результат суммирования на экран. При этом
// используем три функции Visual Basic: InputBox, IsNumeric (для контроля,
// число ли ввел пользователь и MsgBox
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе.
// Добавим ссылку на библиотеку Microsoft.VisualBasic.dll:
// Project | Add Reference | Framework | Microsoft.VisualBasic
namespace СсылкаНаVisualBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            String Строка;
            // Бесконечный цикл, пока пользователь не введет именно число:
            for (; ; )
            {
                Строка = Microsoft.VisualBasic.Interaction.
                           InputBox("Введите первое число:", "Складываю два числа");
                if (Microsoft.VisualBasic.Information.
                                     IsNumeric(Строка) == true) break;
            }
            // - преобразование строковой переменной в число:
            Single X = Single.Parse(Строка);
            // Ввод второго числа:
            for (; ; )
            {
                Строка = Microsoft.VisualBasic.Interaction.
                          InputBox("Введите второе число:", "Складываю два числа");
                if (Microsoft.VisualBasic.Information.
                                     IsNumeric(Строка) == true) break;
            }
            Single Y = Single.Parse(Строка);
            Single Z = X + Y;
            Строка = string.Format("Сумма = {0} + {1} = {2}", X, Y, Z);
            // Вывод результата вычислений на экран:
            Microsoft.VisualBasic.Interaction.MsgBox(Строка);
        }
    }
}
