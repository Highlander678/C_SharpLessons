using System;

// ���������� ���� �� CarLibrary.
using CarLibrary;

// ������������� ����������� ���������� ����.

namespace CSharpCarClient
{
    class Program
    {
        public static void Main()
        {
            // ������� ���������� ���������� ������.
            SportsCar sportcar = new SportsCar("Jaguar", 240, 40);
            sportcar.Acceleration();

            // ������� ����-���.
            MiniVan minivan = new MiniVan();
            minivan.Acceleration();

            // Delay.
            Console.ReadKey();            
        }
    }
}
