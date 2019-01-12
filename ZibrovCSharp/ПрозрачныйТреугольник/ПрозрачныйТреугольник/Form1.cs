// Программирование экранной формы, в которой размещен
// прозрачный треугольник
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ПрозрачныйТреугольник
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Событие перерисовки экранной формы:
            this.ClientSize = new Size(240, 200);
            // Устанавливаем вершины треугольника:
            var p1 = new Point(20, 20);
            var p2 = new Point(225, 66);
            var p3 = new Point(80, 185);
            // Инициализируем массив точек:
            Point[] Точки = { p1, p2, p3 };
            // Закрашиваем этот треугольник цветом ControlDark:
            e.Graphics.FillPolygon(new SolidBrush(
                                SystemColors.ControlDark), Точки);
            // Цвет ControlDark задаем прозрачным:
            this.TransparencyKey = SystemColors.ControlDark;
        }
    }
}
