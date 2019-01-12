// Программа формирует таблицу из двух строковых массивов в текстовом
// поле, используя функцию String.Format. Кроме того, в программе
// участвует элемент управления MenuStrip для организации
// раскрывающегося меню, с помощью которого пользователь выводит
// сформированную таблицу в Блокнот с целью последующего редактирования
// и вывода на печать
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ТаблTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Escape-последовательность для переходя на новую строку:
            const String НС = "\r\n"; // Новая строка
            this.textBox1.Multiline = true;
            this.ClientSize = new Size(438, 272);
            this.textBox1.Size = new Size(415, 229);
            this.Text = "Формирование таблицы";
            String[] Имена = {"Андрей - раб", "Света-X", "ЖЭК",
                                  "Справка по тел", "Александр Степанович",
                                           "Мама - дом", "Карапузова Таня",
                                           "Погода сегодня", "Театр Браво"};
            String[] Тлф = {"274-88-17", "+38(067)7030356",
                            "22-345-72", "009", "223-67-67 доп 32-67",
                                  "570-38-76", "201-72-23-прямой моб",
                                                   "001", "216-40-22"};
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Font = new Font("Courier New", 9.0F);
            textBox1.Text = "ТАБЛИЦА ТЕЛЕФОНОВ" + НС + НС;
            var i = 0;
            // Считают, что цикл foreach/Next - смотрится читабельнее
            // чем обычный цикл:
            foreach (var Имя in Имена)
            {
                textBox1.Text += String.Format(
                              "{0, -21} {1, -21}" + НС, Имя, Тлф[i]);
                i = i + 1;
            }
            // Или формирование таблицы с помощью обычного пошагового цикла:
            // for (i = 0; i <= 8; i++)
            //    textBox1.Text += String.Format(
            //            "{0, -21} {1, -21}", Имена[i], Тлф[i]) + НС;
            textBox1.Text += НС + "ПРИМЕЧАНИЕ:" +
               НС + "для корректного отображения таблицы" +
               НС + "в Блокноте укажите шрифт Courier New";
            // Запись таблицы в текстовый файл D:\Table.txt.
            // Создание экземпляра StreamWriter для записи в файл
            var Писатель = new System.IO.
            StreamWriter(@"D:\Table.txt", false,
                System.Text.Encoding.GetEncoding(1251));
            // - здесь заказ кодовой страницы Win1251 для русских букв
            Писатель.Write(textBox1.Text);
            Писатель.Close();
        }
        private void показатьТаблицуВБлокнотеToolStripMenuItem_Click(
                                            object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(
                                   "Notepad", @"D:\Table.txt");
            }
            catch (Exception Ситуация)
            {
                // Отчет об ошибках
                MessageBox.Show(Ситуация.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void выходToolStripMenuItem_Click(
                                            Object sender, EventArgs e)
        {
            // Выход из программы:
            this.Close();
        }
    }
}
