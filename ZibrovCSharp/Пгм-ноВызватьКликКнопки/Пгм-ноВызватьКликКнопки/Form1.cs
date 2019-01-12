// На экранной форме имеем две кнопки. Щелчок на первой кнопке вызывает
// появление окна с сообщением о произошедшем событии нажатия первой
// кнопки. Щелкая на второй кнопке, мы имитируем нажатие первой кнопки
// путем программного вызова события нажатия первой кнопки
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Пгм_ноВызватьКликКнопки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Произошло событие \"щелчок на первой кнопке\"");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Здесь программно вызываем событие "щелчок на первой
            // кнопке", хотя щелкнули на второй кнопке:
            button1.PerformClick();
            // Тоже самое можно сделать так:
            // button1_Click(null, null);
            // или так:
            // button1_Click(button1, EventArgs.Empty);
        }
    }
}
