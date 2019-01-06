using System;

namespace ICloneableWork
{
    class Program
    {
        static void Main()
        {
            Point original = new Point(100, 100);
            Point clone = original.Clone() as Point;

            Console.WriteLine("������ ��������");

            Console.WriteLine(original);
            Console.WriteLine(clone);

            // �������� clone.x (��� ���� original.x �� ���������)
            clone.x = 0;

            // ��������.
            Console.WriteLine("������ �������� ����� ���������");
            Console.WriteLine(original);
            Console.WriteLine(clone);

            // Delay.
            Console.ReadKey();
        }
    }
}
