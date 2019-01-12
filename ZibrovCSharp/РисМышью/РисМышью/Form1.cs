// Программа позволяет при нажатой левой или правой кнопке мыши
// рисовать в форме
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace РисМышью
{
    public partial class Form1 : Form
    {
        // Булева переменная Рисовать_ли дает разрешение на рисование:
        Boolean Рисовать_ли;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Рисую мышью в форме";
            button1.Text = "Стереть";
            Рисовать_ли = false; // в начале - не рисовать
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Если нажата кнопка мыши - MouseDown, то рисовать
            Рисовать_ли = true;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Если кнопку мыши отпустили, то НЕ рисовать
            Рисовать_ли = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Рисование прямоугольника, если нажата кнопка мыши
            if (Рисовать_ли == true)
            {
                // Рисовать прямоугольник в точке (e.X, e.Y)
                var Графика = CreateGraphics();
                Графика.FillRectangle(new SolidBrush(Color.Red),
                                                e.X, e.Y, 10, 10);
                // 10x10 пикселов — размер сплошного прямоугольника
                // e.X, e.Y — координаты указателя мыши
                Графика.Dispose(); // Эквиваент C++: delete Графика
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Методы очистки формы:
            var Графика = CreateGraphics();
            Графика.Clear(this.BackColor);
            // Графика.Clear(SystemColors.Control);
            // Графика.Clear(Color.FromName("Control"));
            // Графика.Clear(Color.FromKnownColor(KnownColor.Control));
            // Графика.Clear(ColorTranslator.FromHtml("#F0F0F0"));
            // this.Refresh(); // Этот метод также перерисовывает форму
        }
    }
}
