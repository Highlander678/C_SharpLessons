// Клиентское Windows-приложение, потребляющее сервис веб-службы
// предыдущего примера WebСлужбаСумма
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Чтобы добавить веб-службу к обычному Windows-приложению:
// Project | Add Service Reference | Advanced | Add Web Reference,
// затем в поле URL пишем виртуальный адрес веб-службы
// http://localhost:3002/WebService1.asmx
namespace ВебКлиентСумма
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Пуск";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр удаленного класса:
            var Удаленный = new localhost.WebService1();
            var Sum = Удаленный.Сумма("23,5", "11,4");
            MessageBox.Show(Sum);
        }
    }
}
