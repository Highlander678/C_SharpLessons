// Программа анализирует каждый символ, вводимый пользователем в текстовое
// поле формы. Если символ не является цифрой или Backspace, то текстовое
// поле получает запрет на ввод такого символа
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ТолькоЦифры
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Введите число"; textBox1.Clear();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только десятичных цифр и Backspace:
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            // Запрет на ввод других вводимых символов:
            e.Handled = true;
        }
    }
}
