using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace КлиентWCFСлужбы
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
            // Чтобы добавить веб-службу к обычному Windows-приложению:
            // Project | Add Service Reference | Advanced | Add Web Reference,
            // затем в поле URL пишем виртуальный адрес веб-службы
            // http://localhost:1299/Service1.svc
            // Создаем экземпляр удаленного класса:
            var Удаленный = new localhost.Service1();
            var Ответ = Удаленный.ВводИмени("Виктор");
            MessageBox.Show(Ответ);
        }
    }
}
