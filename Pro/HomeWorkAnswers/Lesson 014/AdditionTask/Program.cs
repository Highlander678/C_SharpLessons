using System;
using System.Linq;

namespace AdditionTask
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int[] array =new int[1000000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            var query = array.AsParallel().Where((i) => i % 2 != 0).Select((i) => i);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
