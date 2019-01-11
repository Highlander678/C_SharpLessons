using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace BeginAndEndInvoke
{
    class FibonacciCalculator // Task (LongTask)
    {
        int count;
        List<int> fibonacciSequence = new List<int>();

        // Синхронная версия.
        public List<int> Invoke(int count)
        {
            fibonacciSequence = Fibonacci(count);
            return fibonacciSequence;
        }

        // Асинхронная версия.
        public IAsyncResult BeginInvoke(int count, AsyncCallback callback, object @object)
        {            
            Func<int, List<int>> fibonacci = new Func<int, List<int>>(Fibonacci);
            IAsyncResult asyncResult = fibonacci.BeginInvoke(count, callback, @object);
            return asyncResult;
        }

        public List<int> EndInvoke(IAsyncResult result)
        {
            AsyncResult asyncResult = result as AsyncResult;
            Func<int, List<int>> fibonacci = asyncResult.AsyncDelegate as Func<int, List<int>>;
            fibonacciSequence = fibonacci.EndInvoke(result);

            return fibonacciSequence;
        }

        List<int> Fibonacci(int count)
        {
            Func<int, int> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;

            for (int i = 0; i < count; ++i)
                fibonacciSequence.Add(fib.Invoke(i));

            return fibonacciSequence;
        }
    }
}
