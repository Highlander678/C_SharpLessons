// Программа в полупрозрачной экранной форме отображает текущее время
// по Гринвичу. Таким образом, программа демонстрирует текущее время
// по Гринвичу и при этом не закрывает собой другие приложения
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Гринвич
{
    public partial class Form1 : Form
    {
        // Булева переменная t каждую секунду меняет свое значение на
        // противоположное:
        Boolean t = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ВРЕМЯ ПО ГРИНВИЧУ:";
            this.Opacity = 0.75; // Уровень непрозрачности формы
            label1.Font = new Font("Courier New", 18.0F);
            label1.Text = String.Empty;
            timer1.Interval = 1000; // 1000 миллисекунд = 1 секунда
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Обработка события, когда прошел заданный интервал
            // времени: 1000 миллисекунд = 1 секунда
            label1.Text = "ВРЕМЯ ПО ГРИНВИЧУ ";
            t = !t; // То же, что и t = true ^ t;
            String Время;
            if (t == true)
                Время = String.Format("{0:t}", DateTime.UtcNow);
            else // Через одну секунду выводим GMT-время без ":"
                Время = String.Format("{0} {1:00}", DateTime.UtcNow.Hour,
                                                    DateTime.UtcNow.Minute);
            label1.Text = label1.Text + Время;
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            // Указатель мыши входит в область метки
            this.Opacity = 1;
        }
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            // Указатель мыши выходит за пределы формы
            this.Opacity = 0.75;
        }
    }
}
