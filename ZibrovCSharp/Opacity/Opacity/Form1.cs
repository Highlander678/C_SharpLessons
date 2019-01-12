// Программа демонстрирует стандартную форму. Щелчок мышью в пределах
// этой формы начинает постепенный процесс исчезновения формы: форма
// становится все более прозрачной, а затем исчезает вовсе. Далее она
// постепенно проявляется снова, и т. д. Еще один щелчок в пределах
// формы останавливает этот процесс, а следующий щелчок процесс
// возобновляет и т. д.
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Opacity
{
    public partial class Form1 : Form
    {
        Double s; // - шаг изменения прозрачности
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            s = 0.1;
            this.Text = "Щелкните на форме";
            // timer1.Interval() = 400;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Если непрозрачность выходит за рамки интервала
            // 0 < Opacity < 1, то меняем знак шага на противоположный:
            if (this.Opacity <= 0 || this.Opacity >= 1) s = -s;
            // Каждую десятую долю секунды изменяем уровень прозрачности
            // формы на s = 0.1:
            this.Opacity = this.Opacity + s;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            // Включаем или выключаем таймер:
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
