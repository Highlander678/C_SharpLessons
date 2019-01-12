// Программная имитация нажатия клавиш <Alt>+<PrintScreen>
// методом Send класса SendKeys
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace AltPrintScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Имитируем нажатие <Alt>+<PrintScreen>";
            button1.Text = "методом Send класса SendKeys";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Метод SendKeys.Send посылает сообщение активному приложению
            // о нажатии клавиш <Alt>+<PrintScreen>
            SendKeys.Send("%{PRTSC}");
            // Так можно получить символьное представление клавиши:
            // var S = Keys.PrintScreen.ToString();
        }
    }
}
