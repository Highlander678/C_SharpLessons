using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Метод инициализации всех елементов на форме
        public Form1()
        {
            InitializeComponent();
        }
        //Обработчик события нажатия по кнопке "byte" 
        private void button1_Click(object sender, EventArgs e)
        {
            //Отображение сообщения с диапазоном значений для переменной byte
            MessageBox.Show("Диапазон byte - от 0 до 255");
        }
        //Обработчик события нажатия по кнопке "sbyte" 
        private void button2_Click(object sender, EventArgs e)
        {
            //Отображение сообщения с диапазоном значений для переменной sbyte
            MessageBox.Show("Диапазон sbyte - от -128 до +127");
        }
        //Обработчик события нажатия по кнопке "ushort" 
        private void button3_Click(object sender, EventArgs e)
        {
            //Отображение сообщения с диапазоном значений для переменной ushort
            MessageBox.Show("Диапазон ushort - от 0 до 65535");
        }
        //Обработчик события нажатия по кнопке "short" 
        private void button4_Click(object sender, EventArgs e)
        {
            //Отображение сообщения с диапазоном значений для переменной short
            MessageBox.Show("Диапазон short - от -32768 до +32767");
        }
        //Обработчик события нажатия по кнопке "uint" 
        private void button5_Click(object sender, EventArgs e)
        {
            //Отображение сообщения с диапазоном значений для переменной uint
            MessageBox.Show("Диапазон uint - от 0 до 4294967295");
        }
        //Обработчик события нажатия по кнопке "int" 
        private void button6_Click(object sender, EventArgs e)
        {
            //Отображение сообщения с диапазоном значений для переменной int
            MessageBox.Show("Диапазон int - от -2147483648 до +2147483647");
        }
        //Обработчик события нажатия по кнопке "ulong" 
        private void button7_Click(object sender, EventArgs e)
        {
            //Отображение сообщения с диапазоном значений для переменной ulong
            MessageBox.Show("Диапазон ulong - от 0 до 18446744073709551615");
        }
        //Обработчик события нажатия по кнопке "long" 
        private void button8_Click(object sender, EventArgs e)
        {
            //Отображение сообщения с диапазоном значений для переменной long
            MessageBox.Show("Диапазон long - от -9223372036854775808 до +9223372036854775807");
        }
    }
}
