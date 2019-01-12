// Проверка данных, вводимых пользователем, на достоверность. Программа
// осуществляет синтаксический разбор введенной пользователем текстовой
// строки на соответствие ее положительному рациональному числу
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ПроверкаЧисла
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Введите положительное" +
                          "\r\n" + "рациональное число:";
            button1.Text = "Проверка";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            if (System.Text.RegularExpressions.Regex.Match(
                textBox1.Text,
                "^(([0-9]+.[0-9]*)|([0-9]*.[0-9]+)|([0-9]+))$"
               ).Success == false)
                MessageBox.Show("Некорректный ввод", "Ошибка");
        }
    }
}
