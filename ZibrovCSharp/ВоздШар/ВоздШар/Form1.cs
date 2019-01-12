// Программа пишет в метку Label некоторый текст, а пользователь
// с помощью командной кнопки делает этот текст либо видимым, либо
// невидимым. Здесь использовано свойство Visible. При зависании мыши
// над кнопкой появляется подсказка "Нажми меня" в стиле Balloon
using System;
//using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВоздШар
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Обработка события "загрузка формы":
            this.Text = "Житейская мудрость";
            label1.Text = 
                   "Сколько ребенка не учи хорошим манерам," + "\n" +
                   "он будет поступать так, как папа с мамой";
           // label1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Text = "Кнопка";
            toolTip1.SetToolTip(
                     button1, "Переключатель" + "\n" + "видимости");
            // Должна ли всплывающая подсказка использовать всплывающее окно:
            toolTip1.IsBalloon = true;
            // Если IsBalloon = false, то используется стандартное
            // прямоугольное окно
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Обработка события "щелчок на кнопке":
            // Можно программировать исчезновение/появление текста на
            // метке так:
            // if (label1.Visible == true) label1.Visible = false;
            // else label1.Visible = true;
            // или так:
            // label1.Visible = label1.Visible ^ true;
            // здесь ^ (Xor) - логическое исключающее ИЛИ,
            // или совсем просто:
            label1.Visible = ! label1.Visible;
        }
    }
}
