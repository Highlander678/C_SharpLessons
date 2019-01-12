// Нестандартная форма. Программа позволяет перемещать форму мышью,
// "зацепив" ее не только за заголовок, а в любом месте формы
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ПеремещениеФормы
{
    public partial class Form1 : Form
    {
        Boolean Перемещение;
        // Перемещаем форму только тогда, когда Перемещение == true
        int MouseDownX;
        int MouseDownY;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Перемещение = false;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Здесь обрабатываем событие "щелчок любой кнопкой мыши".
            // Во время щелчка левой копкой мыши запоминаем текущее
            // положение мыши
            if (e.Button == MouseButtons.Left)
            {
                Перемещение = true;
                MouseDownX = e.X;
                MouseDownY = e.Y;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Здесь обрабатываем событие, когда
            // пользователь отпустил кнопку мыши
            if (e.Button == MouseButtons.Left)
                Перемещение = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Здесь обрабатываем событие, когда указатель
            // мыши перемещается в пределах формы.
            // Перемещаем форму только тогда, когда Перемещение = true
            if (Перемещение == true)
            {
                var Точка = new System.Drawing.Point();
                Точка.X = this.Location.X + (e.X - MouseDownX);
                Точка.Y = this.Location.Y + (e.Y - MouseDownY);
                this.Location = Точка;
            }
        }
    }
}
