using System;
using System.Threading;
using System.Collections.Generic;

namespace APM
{
    class FibonacciCalculator // Task (LongTask)
    {
        int count;
        List<int> fibonacciSequence = new List<int>();

        // Синхронная версия.
        public List<int> Invoke(int count)
        {
            this.count = count;
            Fibonacci(null);
            return fibonacciSequence;
        }

        // Асинхронная версия.
        public IAsyncResult BeginInvoke(int count, AsyncCallback callback, object @object)
        {
            this.count = count;
            Message message = new Message(new WaitCallback(Fibonacci), callback, @object);
            AsyncResult asyncResult = new AsyncResult();
            asyncResult.SyncProcessMessage(message);

            return asyncResult;
        }

        public List<int> EndInvoke(IAsyncResult result)
        {
            if (!(result as AsyncResult).isInvokeAsyncCallback)
                result.AsyncWaitHandle.WaitOne();

            return fibonacciSequence;
        }

        void Fibonacci(object arg)
        {
            Func<int, int> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;

            for (int i = 0; i < count; ++i)
                fibonacciSequence.Add(fib.Invoke(i));
        }
    }
}