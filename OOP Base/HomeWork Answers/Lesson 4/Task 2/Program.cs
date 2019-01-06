using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Redactor redactor = new Redactor();
            redactor.ChooseDocument("file.txt");

            redactor.Open();
            redactor.Change();
            redactor.Save();

            // Delay.
            Console.ReadKey();
        }
    }
}
