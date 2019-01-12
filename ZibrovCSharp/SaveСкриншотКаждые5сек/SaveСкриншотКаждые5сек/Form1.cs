// Программа после запуска каждые пять секунд делает снимок текущего
// состояния экрана и записывает эти снимки в файлы Pic1.BMP, Pic2.BMP
// и т. д. Количество таких записей в файл — пять
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace SaveСкриншотКаждые5сек
{
    public partial class Form1 : Form
    {
        int i; // счет секунд
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            i = 0; // счет секунд
            this.Text = "Запись каждые 5 секунд в файл";
            button1.Text = "Пуск";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1;
            this.Text = String.Format("Прошло {0} секунд", i);
            if (i >= 28) { timer1.Enabled = false; this.Close(); }
            Single Остаток = i % 5;
            // В VB целочисленный остаток от деления вычисляет опрератор Mod
            if (Остаток != 0) return;
            // Имитируем нажатие клавиш <Alt>+<PrintScreen>
            SendKeys.Send("%{PRTSC}");
            // Объявление объекта-получателя из буфера обмена
            var Получатель = Clipboard.GetDataObject();
            // Если данные в буфере обмена представлены в формате Bitmap,
            // то записать
            if (Получатель.GetDataPresent(DataFormats.Bitmap) == true)
            {
                // эти данные из буфера обмена в переменную Растр в
                // формате Bitmap
                var Объект = Получатель.GetData(DataFormats.Bitmap);
                var Растр = (Bitmap)Объект;
                // Сохранить изображение из переменной Растр
                // в файл D:\Pic1, D:\Pic2, D:\Pic3, ...
                var ИмяФайла = String.Format(@"D:\Pic{0}.BMP", i / 5);
                Растр.Save(ИмяФайла);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = String.Format("Прошло 0 секунд");
            timer1.Interval = 1000; // равно 1 секунде
            timer1.Enabled = true;  // время пошло
        }
    }
}
