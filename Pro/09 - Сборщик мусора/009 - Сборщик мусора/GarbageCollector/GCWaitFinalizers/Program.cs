using System;

// Для успешной работы метода GC.WaitForPendingFinalizers() - 
// требуется включить оптимизацию:  
// В свойствах проекта, вкладка Build -> группа General -> установить флаг Optimize Code.

namespace GCWaitFinalizers
{
    class MyClass
    {
        ~ MyClass()
        {
            for (int i = 0; i < 80; i++)            
                Console.Write("|");
        }
    }

    class Program
    {       
        static void Main()
        {
            MyClass my = new MyClass();

            GC.Collect();
            GC.WaitForPendingFinalizers(); // Установить комментарий.

            for (int i = 0; i < 80; i++)            
                Console.Write(".");          
        }
    }
}
