// Получаем прогноз рынка Forex на текущий день. Клиентское
// Windows-приложение, потребляющее сервис веб-службы предыдущего
// примера ВебСлужбаForex
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВебКлиентForex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаем клиентское приложение веб-службы:
            // http://localhost:1648/WebService1.asmx
            // Создаем экземпляр удаленного класса:
            var Forex = new localhost.WebService1();
            this.Text = "Рынок Forex";
            label1.Text = Forex.Рекомендация();
        }
    }
}
