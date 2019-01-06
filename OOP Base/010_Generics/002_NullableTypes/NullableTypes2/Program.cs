using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            // a - �������� ����������� ��������.
            int? a = null;
            int? b = -5; // b = -5

            // ��� ��������� ��������� ���� �� ������� = null - ����������� ��������� ������ ����� - false.
            // �������������, ������ ����������� �� ���������� (������������) ����������.       
            if (a >= b)
            {
                Console.WriteLine("a >= b");
            }
            else
            {
                Console.WriteLine("a < b");
            }

            // ���������� �������� (Nullable) ���� ����� ������ ��� �������� - ��� �� �������� null?
            // � ���� ��� �������� �������� null, �� ����������� ��������� ����� - true.

            b = null;

            if (a == b)
            {
                Console.WriteLine("a == b");
            }
            else
            {
                Console.WriteLine("a != b");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
