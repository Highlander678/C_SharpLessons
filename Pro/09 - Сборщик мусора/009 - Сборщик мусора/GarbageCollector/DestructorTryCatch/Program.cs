using System;

// Необработанное исключение в деструкторе,
// приводит к остановке его работы.

namespace DestructorTryCatch
{
    class MyClass
    {
        ~ MyClass()
        {
            try
            {
                throw new Exception("Some Exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Succeeded!");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
        }
    }
}
