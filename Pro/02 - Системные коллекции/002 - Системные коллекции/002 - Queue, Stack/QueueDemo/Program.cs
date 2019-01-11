using System;
using System.Collections;

namespace QueueDemo
{
    class Program
    {
        static void Main()
        {
            var queue = new Queue();
            queue.Enqueue("An item");           // Enqueue() - добавляет элемент в конец очереди.
            Console.WriteLine(queue.Dequeue()); // Dequeue() - возвращает первый элемент очереди, удаляя его.

            // Delay.
            Console.ReadKey();
        }
    }
}