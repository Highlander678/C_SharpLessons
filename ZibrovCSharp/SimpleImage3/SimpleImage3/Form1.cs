// Простейший вывод изображения в форму
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace SimpleImage3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Событие загрузки формы:
            this.Text = "Рисунок";
            button1.Text = "Показать рисунок";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Событие "щелчок на кнопке"
            var Рисунок = new Bitmap(@"D:\poryv.png");
            // Создание графического объекта:
            var Графика = this.CreateGraphics();
            // или var Графика = CreateGraphics();
            Графика.DrawImage(Рисунок, 5, 5);
        }
    }
}
