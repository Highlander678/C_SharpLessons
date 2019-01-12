// Программа для ввода пароля в текстовое поле, причем при вводе вместо
// вводимых символов некто, "находящийся за спиной пользователя", увидит
// только звездочки
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной программе
namespace Паспорт
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Обработка события загрузки формы:
            this.Text = "Введи пароль";
            textBox1.Text = null; textBox1.TabIndex = 0;
            textBox1.PasswordChar = '*';
            textBox1.Font = new Font("Courier New", 10.0F);
            // или textBox1.Font = new Font(
            //        FontFamily.GenericMonospace, 10.0F);
            label1.Text = String.Empty;
            label1.Font = new Font("Courier New", 10.0F);
            button1.Text = "Покажи паспорт";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Обработка события "щелчок на кнопке":
            label1.Text = textBox1.Text;
        }
    }
}
