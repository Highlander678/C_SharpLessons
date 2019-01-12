// Программа выводит на печать (на принтер) изображение эллипса. Понятно, что
// таким же образом можно распечатывать и другие графические примитивы:
// прямоугольники, отрезки, дуги и т.д. (см. методы объекта Graphics)
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ПечатьЭллипса
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.
                                    Drawing.Printing.PrintPageEventArgs e)
        {
        // Выводится на печать эллипс красного цвета внутри
        // ограничивающего прямоугольника с вершиной в точке (200, 250),
        // шириной 300 и высотой 200
        var Перо = new Pen(Color.Red);
        e.Graphics.DrawEllipse(Перо, new Rectangle(200, 250, 300, 200));
        // или e.Graphics.DrawEllipse(Перо, 50, 50, 150, 150);
        }
    }
}
