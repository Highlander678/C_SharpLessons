// Программа выводит в форму растровое изображение из графического файла
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace SimpleImage1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.Text = "Рисунок";
            // Размеры формы
            this.Width = 240; this.Height = 240;
            // Создаем объект для работы с изображением
            Image Рисунок = (Image) new Bitmap(@"D:\poryv.png");
            // Вывод изображения в форму
            e.Graphics.DrawImage(Рисунок, 5, 5);
            // x=5, y=5 - это координаты левого верхнего угла рисунка в
            // системе координат формы: ось x - вниз, ось y - вправо
        }

    }
}
