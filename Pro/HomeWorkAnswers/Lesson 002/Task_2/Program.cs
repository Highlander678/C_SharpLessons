using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            // Первый способ
            var dict = new Dictionary<int, double>();

            // Второй способ
            var sortedDict = new SortedDictionary<int, double>();

            sortedDict.Add(11122233, 1000.5);
            sortedDict.Add(11120033, 10800.5);
            sortedDict.Add(19119931, 10800.41);
        }
    }
}
