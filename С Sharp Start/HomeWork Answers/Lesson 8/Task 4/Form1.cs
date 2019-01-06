using System;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        //Инициализация елементов управленя на форме
        public Form1()
        {
            InitializeComponent();
        }

        //Обработчик события нажатия по кнопке 1
        private void button1_Click(object sender, EventArgs e)
        {
            //Проверка свойства Checked объекта radioButton1
            if (radioButton1.Checked == true)
            {
                //В свойство Text объекта textBox3 происходит запись  остатка от дления приведенного к типу String
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text));
            }
            //Проверка свойства Checked объекта radioButton2
            if (radioButton2.Checked == true)
            {
                //В свойство Text объекта textBox3 происходит запись  результата приведения числа в степень приведенного к типу String
                textBox3.Text = Convert.ToString(Math.Pow(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            }
            //Проверка свойства Checked объекта radioButton3
            if (radioButton3.Checked == true)
            {
                //В свойство Text объекта textBox3 происходит запись результата конкатенации строк
                textBox3.Text = textBox1.Text + textBox2.Text;
            }
            //Проверка свойства Checked объекта radioButton4
            if (radioButton4.Checked == true)
            {
                //В свойство Text объекта textBox3 происходит запись дления приведенного к типу String
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
            }
        }
    }
}
