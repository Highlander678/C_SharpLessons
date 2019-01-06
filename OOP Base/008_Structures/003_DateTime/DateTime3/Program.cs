using System;

// Форматированный вывод даты и времени 

namespace DateTime3
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Дата месяц(прописью) год : {0:D}", now);
            Console.WriteLine("Дата.месяц.год : {0:d}", now);
            Console.WriteLine("Дата месяц(прописью) год время(чч:мм:сс) : {0:F}", now);
            Console.WriteLine("Дата месяц(прописью) год время(чч:мм) : {0:f}", now);
            Console.WriteLine("Дата.месяц.год время(чч:мм:cc) : {0:G}", now);
            Console.WriteLine("Дата.месяц.год время(чч:мм) : {0:g}", now);
            Console.WriteLine("Текущий месяц и дата : {0:M}", now);
            Console.WriteLine("Текущий месяц и год : {0:Y}", now);
            Console.WriteLine("Время(чч:мм:cc) : {0:T}", now);
            Console.WriteLine("Время(чч:мм) : {0:t}", now);

            // Delay.
            Console.ReadKey();
        }
    }
}
