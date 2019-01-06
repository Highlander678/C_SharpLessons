using System;

// Анонимные (лямбда) методы.

namespace Delegates
{
    // Создаем класс делегата.
    public delegate void MyDelegate(ref int a, ref int b, out int c);
    public delegate int Mydelegate_1(ref int a);
    class Program
    {
        static void Main()
        {
            int summand1 = 1, summand2 = 2, sum;

            MyDelegate myDelegate = delegate(ref int a, ref int b, out int c) { a++; b++; c = a + b; };
            //int My1(int x) => x++;
            Mydelegate_1 My1 = null;
            My1 = (ref int x) => ++x;

            sum = My1(ref summand1);
            Console.WriteLine("summand1 ={0} ",summand1);

            //MyDelegate testDelegate = (ref int a, ref int b, out int c)=> { a++; b++; c = a + b; };
            //testDelegate(ref summand1, ref summand2, out sum);
            //Console.WriteLine("{0}+{1}={2}", summand1,summand2,sum);

            //myDelegate(ref summand1, ref summand2, out sum);

            //Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Delay.
            Console.ReadKey();
        }
    }
}
