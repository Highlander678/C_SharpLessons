using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new House(new Street("Марины Расковой"), "Киев");

            House clone;
            //clone = house.Clone();
            clone = house.DeepClone();

            Console.WriteLine("Original: {0}, {1}", house.City, house.Street.Str);
            Console.WriteLine("Clone   : {0}, {1}", clone.City, clone.Street.Str);
            Console.WriteLine(new string('-', 50));

            clone.City = "Одесса";
            clone.Street = new Street("Дерибасовская");

            Console.WriteLine("Original: {0}, {1}", house.City, house.Street.Str);
            Console.WriteLine("Clone   : {0}, {1}", clone.City, clone.Street.Str);

            // Delay.
            Console.ReadKey();
        }
    }
}
