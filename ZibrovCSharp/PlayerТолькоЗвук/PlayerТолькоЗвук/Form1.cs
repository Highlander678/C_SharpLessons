// Программа предназначена для воспроизведения только звуковых файлов
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~
// Добавляем ссылку на объектную библиотеку. Для этого выбираем
// пункты меню Project | Add Reference и щелкнув на кнопке
// Browse (Обзор) найдем файл C:\Windows\system32\wmp.dll
namespace PlayerТолькоЗвук
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer Плеер;
        OpenFileDialog ОткрытьФайл;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Плеер = new WMPLib.WindowsMediaPlayer();
            ОткрытьФайл = new OpenFileDialog();
            // ВЕРСИЯ ПЛЕЕРА
            this.Text = "Windows Media Player " + Плеер.versionInfo;
            button1.Text = "Файл";
            button2.Text = "Увеличить громкость";
            button3.Text = "Уменьшить громкость";
            // Задаем путь к фалу:
            // Плеер.URL = @"D:\VenSalvrme.wma"
            Плеер.URL = @"C:\WINDOWS\Media\town.mid";
            // Плеер.URL = @"D:\juliana-best_of_best.mp3";
            Плеер.settings.volume = 10;
            // Команда на проигрывание файла
            Плеер.controls.play();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Кнопка Файл:
            // Пользователь выбирает файл:
            ОткрытьФайл.ShowDialog();
            // Передача плееру имени файла
            Плеер.URL = ОткрытьФайл.FileName;
            // Команда на проигрывание файла
            Плеер.controls.play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Увеличиваем громкость с каждым щелчком:
            Плеер.settings.volume = Плеер.settings.volume + 10;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Уменьшаем громкость с каждым щелчком:
            Плеер.settings.volume = Плеер.settings.volume - 10;
        }
    }
}
