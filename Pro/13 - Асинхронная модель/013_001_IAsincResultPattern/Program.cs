using System;
using System.Collections.Generic;
using System.Threading;

// APM

namespace APM
{
    public static class Program
    {
        static FibonacciCalculator calculator = new FibonacciCalculator();
        static List<int> fibonacciSequence;

        public static void Main()
        {
            #region 1. ���������� �����.

            //fibonacciSequence = calculator.Invoke(40);

            //foreach (int item in fibonacciSequence)
            //{
            //    Console.Write("{0}, ", item);
            //}

            #endregion

            #region 2. ����������� �����.

            //IAsyncResult asyncResult = calculator.BeginInvoke(40, null, null);
            //Console.WriteLine("My work!!!");
            //fibonacciSequence = calculator.EndInvoke(asyncResult);

            //foreach (int item in fibonacciSequence)
            //{
            //    Console.Write("{0}, ", item);
            //}

            #endregion

            #region 3. ����������� ����� � �������������� Callback ������.

            IAsyncResult asyncResult = calculator.BeginInvoke(40, CallBack, calculator);

            #endregion

            Console.WriteLine("\n��������� ����� �������� ������.");

            // Delay
            Console.ReadKey();
        }

        // ����� ��������� ���������� ����������� ��������.
        static void CallBack(IAsyncResult asyncResult)
        {
            // ��������� ����������, � ������� ���� ������� ����������� ��������.
            FibonacciCalculator calculator = (FibonacciCalculator)asyncResult.AsyncState;

            // ��������� ����������� ����������� ��������.
            List<int> fibonacciSequence = calculator.EndInvoke(asyncResult);

            foreach (int item in fibonacciSequence)
            {
                Console.Write("{0}, ", item);
            }
        }
    }
}