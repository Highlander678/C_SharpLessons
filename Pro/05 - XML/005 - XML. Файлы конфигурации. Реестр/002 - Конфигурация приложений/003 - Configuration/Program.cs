using System;
using System.Collections;
using System.Configuration;
using System.Collections.Specialized;

namespace ConfigurationBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection allAppSettings = ConfigurationManager.AppSettings;
            Int32 counter = 0;
            IEnumerator settingEnumerator = allAppSettings.Keys.GetEnumerator();


            while (settingEnumerator.MoveNext())
            {
                Console.WriteLine("Key: {0}  Value: {1}", allAppSettings.Keys[counter], allAppSettings[counter]);
                counter++;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
