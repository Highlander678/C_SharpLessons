using System;
using System.Windows.Forms;

// В свойствах проекта, установите тип приложения - Windows Application.

namespace App1
{
    public class Program
    {
        public static void Main() 
        {
            MessageBox.Show("App1", AppDomain.CurrentDomain.FriendlyName);

            throw new Exception("Исключение в App1");

            MessageBox.Show("App1", "Продолжение");
        }
    }
}
