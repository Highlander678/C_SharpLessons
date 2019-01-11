using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            CitizenCollection citizens = new CitizenCollection();
            int index;

            Console.WriteLine("Добавление элементов в коллекцию");
            citizens.Add(new Student("Alex", "Po", "IM000111"));
            citizens.Add(new Pensioner("Bob", "Snob", "EK 333444"));
            citizens.Add(new Worker("Pol", "Dupol", "EK000222"));
            citizens.Add(new Pensioner("Bob2", "Snob2", "ek333444")); // Добавления не произойдет, т.к. уже есть элемент с таким номером паспорта
            Pensioner p3 = new Pensioner("Bob3", "Snob3", "em222777");
            citizens.Add(p3);

            foreach (Citizen item in citizens)
            {
                Console.WriteLine(item.FullName);
            }
            Console.WriteLine(new string('*', 30));

            Pensioner p4 = new Pensioner("Bob4", "Snob4", "em444111"); // В коллекцию не добавляем
            Console.WriteLine("В коллекции есть {0} - {1}, его позиция {2} ", p3.FullName, citizens.Contains(p3, out index), index);
            Console.WriteLine("В коллекции есть {0} - {1}, его позиция {2} ", p4.FullName, citizens.Contains(p4, out index), index);
            Console.WriteLine(new string('*', 30));

            Console.WriteLine("Кто последний? - {0}, позиция {1}", citizens.ReturnLast(out index).FullName, index);
            Console.WriteLine(new string('*', 30));

            Console.WriteLine("Удаление элементов из коллекции");
            citizens.Remove(p3);
            citizens.Remove(p4);
            citizens.Remove();
            foreach (Citizen item in citizens)
            {
                Console.WriteLine(item.FullName);
            }
            Console.WriteLine(new string('*', 30));

            citizens.Clear();
            if (citizens.Count == 0)
            {
                Console.WriteLine("Коллекция очищена");
            }

            Console.ReadKey();
        }
    }
}

