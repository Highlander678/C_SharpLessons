// Вывод таблицы в Internet Explorer. Здесь реализован несколько необычный
// подход к выводу таблицы для ее просмотра и печати на принтере.
// Программа записывает таблицу в текстовый файл в формате HTML.
// Теперь у пользователя появляется возможность прочитать эту таблицу с
// помощью обозревателя веб-страниц Internet Explorer или другого браузера
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Табл_HTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Таблица в формате HTML";
            String[] Имена = {"Андрей - раб", "Света-X", "ЖЭК",
                     "Справка по тел", "Александр Степанович", "Мама - дом",
                     "Карапузова Таня", "Погода сегодня", "Театр Браво"};
            String[] Тлф = {"274-88-17", "+38(067)7030356",
                     "22-345-72", "009", "223-67-67 доп 32-67", "570-38-76",
                     "201-72-23-прямой моб", "001", "216-40-22"};
            var text = "<title>Пример таблицы</title>" +
                       "<table border><caption>" +
                       "Таблица телефонов</caption>" + "\r\n";
            for (int i = 0; i <= 8; i++)
                text += String.Format("<tr><td>{0}<td>{1}",
                                               Имена[i], Тлф[i]) + "\r\n";
            text = text + "</table>";
            // Запись таблицы в текстовый файл D:\Tabl_tel.htm.
            // Создание экземпляра StreamWriter для записи в файл
            var Писатель = new 
                  System.IO.StreamWriter(@"D:\Tabl_tel.htm", false,
                  System.Text.Encoding.GetEncoding(1251));
            // - здесь заказ кодовой страницы Win1251 для русских букв
            Писатель.Write(text); Писатель.Close();
            try
            {
                System.Diagnostics.Process.Start(
                                        "Iexplore", @"D:\Tabl_tel.htm");
                // Файл HTM можно открывать также с пом MS_WORD:
                // System.Diagnostics.Process.Start(
                //                       "WinWord", @"D:\Tabl_tel.htm");
            }
            catch (Exception Ситуация)
            {
                // Отчет об ошибках
                MessageBox.Show(Ситуация.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
