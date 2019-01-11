using System;
using System.Collections;

namespace AdditionTask
{
    class Program
    {
        static IEnumerable GetCollection(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    yield return array[i] * array[i];
                }

            }
        }

        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in GetCollection(array))
            {
                Console.Write(item + ", ");
            }

            Console.ReadKey();
        }
    }
}
