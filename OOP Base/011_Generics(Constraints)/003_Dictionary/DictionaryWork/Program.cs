using System;
using System.Collections.Generic;

// ������� (����/��������)

namespace DictionaryWork
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(0, "����");
            dictionary.Add(1, "����");
            dictionary.Add(2, "���");
            dictionary.Add(3, "���");

            Console.WriteLine(dictionary.ContainsValue("����")); 
            
            for (int i = 0; i < dictionary.Count; i++)
                Console.WriteLine(dictionary[i]);
            
            // Delay.
            Console.ReadKey();
        }
    }
}
