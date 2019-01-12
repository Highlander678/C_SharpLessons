// Программа, реализующая функции калькулятора. Здесь для отображения
// вариантов выбора арифметических действий используется комбинированный
// список ComboBox
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Комби
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Суперкалькулятор"; label1.Text = "Равно: ";
            button1.Text = "Выбери операцию";
            comboBox1.Text = "Выбери операцию";
            // Заполение (инициализация) раскрывающегося списка:
            String[] Операции = {"Прибавить", "Отнять",
                          "Умножить", "Разделить", "Очистить"};
            comboBox1.Items.AddRange(Операции);
            comboBox1.TabIndex = 2;
            textBox1.Clear(); textBox1.TabIndex = 0;
            textBox2.Clear(); textBox2.TabIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(
                                           object sender, EventArgs e)
        {
            // Обработка события изменения индекса выбранного элемента
            label1.Text = "Равно: ";
            // Преобразование из строковой переменной в Single:
            Single X, Y, Z; Z = 0;
            var Число_ли1 = Single.TryParse(textBox1.Text,
                      System.Globalization.NumberStyles.Number,
                      System.Globalization.NumberFormatInfo.CurrentInfo, 
                      out X);
            var Число_ли2 = Single.TryParse(textBox2.Text,
                      System.Globalization.NumberStyles.Number,
                      System.Globalization.NumberFormatInfo.CurrentInfo,
                      out Y);
            if (Число_ли1 == false || Число_ли2 == false)
            {
                MessageBox.Show("Следует вводить числа!", "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // - если ошибка, то выход из процедуры
            }
            // Оператор множественного выбора:
            switch (comboBox1.SelectedIndex)
            {   // Выбор арифметической операции:
                case 0:  // Выбрали "Прибавить":
                    Z = X + Y; break;
                case 1:  // Выбрали "Отнять":
                    Z = X - Y; break;
                case 2:  // Выбрали "Умножить":
                    Z = X * Y; break;
                case 3:  // Выбрали "Разделить":
                    Z = X / Y; break;
                case 4:  // Выбрали "Очистить":
                    textBox1.Clear(); textBox2.Clear();
                    label1.Text = "Равно: "; return;
            }
            label1.Text = String.Format("Равно: {0:F5}", Z);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Обработка события "щелчок на кнопке":
            // "Принудительно" раскрываем список:
            comboBox1.DroppedDown = true;
        }
    }
}
