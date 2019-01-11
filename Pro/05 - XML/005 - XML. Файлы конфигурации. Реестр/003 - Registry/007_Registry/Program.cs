using System;
using Microsoft.Win32;

namespace RegistryBasics
{
	class Program
	{
		static void Main()
		{
			// Совершаем навигацию по реестру и открываем ключ для чтения,
			// можно сразу указать весь путь, а не совершать навигацию поэтапно.
			RegistryKey key = Registry.CurrentUser;
			RegistryKey subKey = key.OpenSubKey(@"Software\CyberBionicSystematics"); 

			// Читаем данные и конвертируем в нужный формат.
			string value1 = subKey.GetValue("TheStringName") as string;
			int value2 = Convert.ToInt32(subKey.GetValue("TheInt32Name"));
			int value3 = Convert.ToInt32(subKey.GetValue("AnotherName"));

			subKey.Close();

			// Покажем содержимое, чтобы убедиться в том, что чтение прошло успешно.
			Console.WriteLine("String: {0}\nInt32: {1}\nAnother: {2}", value1, value2, value3);

			// Задержка.
			Console.ReadKey();
		}
	}
}
