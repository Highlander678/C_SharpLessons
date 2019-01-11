using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginAndEndInvoke
{
    public static class Program
    {
        static FibonacciCalculator calculator = new FibonacciCalculator();
        static List<int> fibonacciSequence;

        public static void Main()
        {
            #region 1. Синхронный вызов.

            //fibonacciSequence = calculator.Invoke(40);

            //foreach (int item in fibonacciSequence)
            //{
            //    Console.Write("{0}, ", item);
            //}

            #endregion

            #region 2. Асинхронный вызов.

            //IAsyncResult asyncResult = calculator.BeginInvoke(40, null, null);
            //fibonacciSequence = calculator.EndInvoke(asyncResult);

            //foreach (int item in fibonacciSequence)
            //{
            //    Console.Write("{0}, ", item);
            //}

            #endregion

            #region 3. Асинхронный вызов с использованием Callback метода.

            //IAsyncResult asyncResult = calculator.BeginInvoke(40, CallBack, calculator);

            #endregion

            Console.WriteLine("\nПервичный поток завершил работу.");

            // Delay
            Console.ReadKey();
        }

        // Метод обработки завершения асинхронной операции.
        static void CallBack(IAsyncResult asyncResult)
        {
            // Получение экземпляра, с котором была связана асинхронная операция.
            FibonacciCalculator calculator = (FibonacciCalculator)asyncResult.AsyncState;

            // Получение результатов асинхронной операции.
            List<int> fibonacciSequence = calculator.EndInvoke(asyncResult);

            foreach (int item in fibonacciSequence)
            {
                Console.Write("{0}, ", item);
            }
        }
    }
}
