using System;
using System.IO;

// Работа с классом StreamReader. Различные способы получения информации из файла.

namespace StreamReaderDemo
{
	class Program
	{
		static void Main()
		{
			// Открываем файл для чтения.
			FileStream file = File.Open(@"D:\test.txt", FileMode.OpenOrCreate, FileAccess.Write);

			// Создаем поток для чтения данных из файла.
			StreamReader reader = new StreamReader(file);
			
			// Читаем до конца.
			Console.Write(reader.ReadToEnd());
			
			// Закрываем файл и удаляем поток.
			reader.Close();
			//file.Close(); // Закрывать не обязательно так как reader закроет сам.

			Console.WriteLine("\n");

			// Еще раз открываем файл, используя другой способ.
			reader = File.OpenText(@"D:\test.txt");
			
			// Читаем до конца и закрываем файл.
			Console.Write(reader.ReadToEnd());
			reader.Close();

			Console.WriteLine("\n");

			// Читаем весь текст, содержащийся в файле.
			Console.WriteLine(File.ReadAllText(@"D:\test.txt"));

			// Задержка.
			Console.ReadKey();
		}
	}
}
