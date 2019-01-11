﻿using System;
using System.Xml;

// Загрузка содержимого XML по URL.

// Для выполнения данного примера, предварительно скопируйте xml файл в папку: C:\inetpub\wwwroot

namespace XML
{
	class Program
	{
		static void Main()
		{
			XmlTextReader xmlReader = new XmlTextReader("http://localhost/books.xml");

			while (xmlReader.Read())
			{
				Console.WriteLine("{0,-10} {1,-10} {2,-10}",
					xmlReader.NodeType.ToString(),
					xmlReader.Name,
					xmlReader.Value);
			}

			xmlReader.Close();
			
			// Delay.
			Console.ReadKey();
		}
	}
}
