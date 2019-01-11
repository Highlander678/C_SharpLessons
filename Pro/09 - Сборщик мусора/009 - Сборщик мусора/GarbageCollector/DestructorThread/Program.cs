using System;
using System.Threading;

namespace DestructorThread
{
    class MyClass
    {
        ~ MyClass()
        {
            Console.WriteLine("Destructor thread ID: {0}", 
                Thread.CurrentThread.ManagedThreadId);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Main thread ID: {0}", 
                Thread.CurrentThread.ManagedThreadId);

            MyClass my = new MyClass();
        }
    }
}
