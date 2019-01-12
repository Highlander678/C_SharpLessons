// Программа управляет стилем шрифта текста, выведенного на метку Label,
// посредством двумя флажками CheckBox. Программа использует побитовый
// оператор Xor - исключающее ИЛИ
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Флажок2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Флажок CheckBox";
            checkBox1.Text = "Полужирный"; checkBox1.Focus();
            checkBox2.Text = "Наклонный";
            label1.Text = "Выбери стиль шрифта";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new Font("Courier New", 14.0F);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Courier New", 14.0F,
                          label1.Font.Style ^ FontStyle.Bold);
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Courier New", 14.0F,
                              label1.Font.Style ^ FontStyle.Italic);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
