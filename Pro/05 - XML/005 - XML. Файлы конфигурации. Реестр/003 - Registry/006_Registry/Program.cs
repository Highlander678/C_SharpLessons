using System;
using Microsoft.Win32;

// Редактирование реестра.

namespace RegistryBasics
{
	class Program
	{
		static void Main()
		{
			// Совершаем навигацию в нужное место и открываем его для записи.
			RegistryKey key = Registry.CurrentUser;
			RegistryKey subKey = key.OpenSubKey("Software", true);
			RegistryKey subSubKey = subKey.CreateSubKey("CyberBionicSystematics");

			// Совершаем запись в реестр.
			subSubKey.SetValue("TheStringName", "I contain string value.");
			subSubKey.SetValue("TheInt32Name", 1234567890);
             
			// Тип можно указать явно.
			subSubKey.SetValue("AnotherName", 1234567890, RegistryValueKind.String);

			subKey.Close();
			subSubKey.Close();

			// Задержка на экране.
			 Console.ReadKey();
		}
	}
}
