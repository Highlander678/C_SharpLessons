// Программа формирует таблицу на основании двух массивов переменных 
// с двойной точностью. Данную таблицу программа демонстрирует
// пользователю в текстовом поле TextBox. Есть возможность распечатать
// таблицу на принтере
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ТаблTxtPrint
{
    public partial class Form1 : Form
    {
        System.IO.StringReader Читатель; // - внешняя переменная
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Escape-последовательность для переходя на новую строку:
            const String НС = "\r\n"; // Новая строка
            this.Text = "Формирование таблицы";
            Double[] X = {5342736.17653, 2345.3333, 234683.853749,
                   2438454.825368, 3425.72564, 5243.25,
                   537407.6236, 6354328.9876, 5342.243};
            Double[] Y = {27488.17, 3806703.356, 22345.72,
                   54285.34, 2236767.3267, 57038.76,
                   201722.3, 26434.001, 2164.022};
            // ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ 
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Font = new Font("Courier New", 9.0F);
            textBox1.Text = "КАТАЛОГ КООРДИНАТ" + НС;
            textBox1.Text += "---------------------------------" + НС;
            textBox1.Text += "|Пункт|      X     |     Y      |" + НС;
            textBox1.Text += "---------------------------------" + НС;
            // ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ 
            for (int i = 0; i <= 8; i++)
                textBox1.Text +=
                   String.Format("| {0,3:D} | {1,10:F2} | {2,10:F2} |",
                                                 i, X[i], Y[i]) + НС;
            textBox1.Text += "---------------------------------" + НС;
        }
        private void печатьToolStripMenuItem_Click(
                                           Object sender, EventArgs e)
        {
            // Пункт меню "Печать"
            try
            {
                // Создание потока Читатель для чтения из строки:
                Читатель = new System.IO.StringReader(textBox1.Text);
                try
                {
                    printDocument1.Print();
                }
                finally
                {
                    Читатель.Close();
                }
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message);
            }
        }
        private void выходToolStripMenuItem_Click(
                                       Object sender, EventArgs e)
        {
                    // Выход из программы
            this.Close();
        }
    }
}
