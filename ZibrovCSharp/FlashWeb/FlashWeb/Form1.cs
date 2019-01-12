// Программа использует элемент управления WebBrowser для отображения
// Flash-файлов
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace FlashWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Никакие края (из четырех) не привязаны к экранной форме:
            webBrowser1.Dock = DockStyle.None;
            // Так можно вывести веб-страницу в поле элемента WebBrowser:
            // webBrowser1.Navigate("www.mail.ru");
            // return;
            var ИмяФайла = System.IO.Directory.
                           GetCurrentDirectory() + @"\Shar.swf";
            // Если такого файла нет
            if (System.IO.File.Exists(ИмяФайла) == false)
            {
                MessageBox.Show(
                    "Файл " + ИмяФайла + " не найден", "Ошибка");
                return;
            }
            webBrowser1.Navigate(ИмяФайла);
        }
    }
}
