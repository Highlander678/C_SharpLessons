// Демонстрация использования таймера Timer. После запуска программы
// показываются форма и элемент управления список элементов ListBox.
// Через 2 секунды в списке элементов появляется запись "Прошло две
// секунды", и через каждые последующие 2 секунды в список добавляется
// аналогичная запись
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ПростоTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Timer";
            timer1.Interval = 2000; // - 2 секунды
            // Старт отчета времени
            timer1.Enabled = true;// - время пошло
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add("Прошло две секунды");
        }
    }
}
