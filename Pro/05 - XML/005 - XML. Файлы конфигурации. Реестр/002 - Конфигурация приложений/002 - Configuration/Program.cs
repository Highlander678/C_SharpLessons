using System;
using System.Configuration;
using System.Collections.Specialized;

namespace ConfigurationBasic
{
    class Program
    {
        static void Main()
        {
            // 1 (Устарел)
            string value = ConfigurationSettings.AppSettings["Foo"];
            Console.WriteLine(value);
            Console.WriteLine(new string('-', 12));


            // 2
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            Console.WriteLine(appSettings["Foo"]);
            Console.WriteLine(appSettings[0]);

            Console.WriteLine(new string('-', 12));

            // 3
            for (int i = 0; i < appSettings.Count; i++)
            {
                Console.WriteLine(appSettings[i]);
            }

            Console.WriteLine(new string('-', 12));

            // 4
            foreach (string item in appSettings)
            {
                Console.WriteLine(appSettings[item]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
