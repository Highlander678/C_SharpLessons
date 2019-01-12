// Программа разрешает ввод в текстовое поле только цифровых символов,
// а также разделитель целой и дробной частей числа (т. е. точки или запятой)
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Разделитель целой и дробной частей числа может быть
// точкой "." или запятой "," в зависимости от
// установок в пункте Язык и региональные стандарты
// Панели управления ОС Windows
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ТолькоЦифры_ТчкOrЗпт
{
    public partial class Form1 : Form
    {
        String ТчкИлиЗпт;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Введите число";
            // Выясняем, что установлено на данном ПК в качестве
            // разделителя целой и дробной частей: точка или запятая
            ТчкИлиЗпт = System.Globalization.
                NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ТчкИлиЗптНАЙДЕНА = false;
            // Разрешаю ввод десятичных цифр:
            if (Char.IsDigit(e.KeyChar) == true) return;
            // Разрешаю ввод <Backspace>:
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            // Поиск ТчкИлиЗпт в textBox. 
            // Если IndexOf() == -1, то не найдена:
            if (textBox1.Text.IndexOf(ТчкИлиЗпт) != -1)
                                       ТчкИлиЗптНАЙДЕНА = true;
            // Если ТчкИлиЗпт уже есть в textBox, то запрещаем вводить и ее,
            // и любые другие символы:
            if (ТчкИлиЗптНАЙДЕНА == true) { e.Handled = true; return; }
            // Если ТчкИлиЗпт еще нет в TextBox, то разрешаем ее ввод:
            if (e.KeyChar.ToString() == ТчкИлиЗпт) return;
            // В других случаях - запрет на ввод:
            e.Handled = true;
        }
    }
}
