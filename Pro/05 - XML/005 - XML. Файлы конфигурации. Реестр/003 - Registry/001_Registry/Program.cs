using System;
using Microsoft.Win32; // В этом namespace хранятся классы для работы с реестром.

// Структура реестра.

namespace RegistryBasics
{
	class Program
	{
		static void Main()
		{
			// Registry - это класс, предоставляющий эксклюзивный доступ к ключам реестра для простых операций.
			// RegistryKey - класс реализует методы для просмотра дочерних ключей, создания новых или чтения и модификации существующих,
			//				 включая установку уровней безопасности для них.

			RegistryKey[] keys = new RegistryKey[] { Registry.ClassesRoot,
													 Registry.CurrentUser,
													 Registry.LocalMachine,
													 Registry.Users,
													 Registry.CurrentConfig,
													 Registry.PerformanceData
													 //Registry.DynData // Устарел.
												   };

			foreach (RegistryKey key in keys)
				Console.WriteLine("{0} - всего элементов: {1}.", key.Name, key.SubKeyCount);

			// Delay.
			Console.ReadKey();
		}
	}
}
