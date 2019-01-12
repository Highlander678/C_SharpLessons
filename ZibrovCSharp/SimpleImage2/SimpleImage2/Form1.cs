// Простейший вывод изображения в форму
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace SimpleImage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // В свойствах формы щелкнем значок молнии и в появившемся
            // списке всех событий для объекта Form1 выберем событие Paint.
            // Событие Paint - это событие рисования формы:
            this.Text = "Рисунок";
            // Создаем объект для работы с изображением:
            var Рисунок = Image.FromFile(@"D:\poryv.png");
            // или var Рисунок = new Bitmap(@"D:\poryv.png");
            // Вывод изображения в форму:
            e.Graphics.DrawImage(Рисунок, 5, 5);
        }
    }
}
