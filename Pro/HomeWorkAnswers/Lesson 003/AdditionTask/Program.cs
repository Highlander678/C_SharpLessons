using System;
using System.IO;

namespace AdditionTask
{
    class Program
    {
        static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\");

            dir.CreateSubdirectory("TestDir");

            for (int i = 0; i < 100; i++)
            {
                dir.CreateSubdirectory(string.Format(@"TestDir\Folder_{0}", i));
            }

            Console.ReadKey();

            for (int i = 0; i < 100; i++)
            {
                Directory.Delete(string.Format(@"D:\TestDir\Folder_{0}", i));
            }

            Console.ReadKey();

            Directory.Delete(@"D:\TestDir");

            Console.ReadKey();
        }
    }
}
