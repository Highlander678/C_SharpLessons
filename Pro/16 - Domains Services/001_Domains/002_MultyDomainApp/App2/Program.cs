using System;
using System.Windows.Forms;

// В свойствах проекта, установите тип приложения - Windows Application.

namespace App2
{
    public class Program 
    {
        public static void Main()
        {
            MessageBox.Show("App2", AppDomain.CurrentDomain.FriendlyName);

            throw new Exception("Исключение в App2"); 

            MessageBox.Show("App2", "Продолжение");
        }
    }
}
