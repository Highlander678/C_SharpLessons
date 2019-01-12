// Проверка данных, вводимых пользователем, на достоверность.
// Программа осуществляют синтаксический разбор введенной пользователем
// текстовой строки на соответствие ее фамилии на русском языке
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ПроверкаФамилии
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Введите фамилию на русском языке:";
            button1.Text = "Проверка";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            if (System.Text.RegularExpressions.Regex.Match(
                textBox1.Text,
                "^[А-ИК-ЩЭ-Я][а-яА-Я]*$").Success == false)
                MessageBox.Show("Неверный ввод фамилии", "Ошибка");
        }
    }
}
