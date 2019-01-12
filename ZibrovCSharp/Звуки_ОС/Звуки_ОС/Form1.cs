// Программа воспроизводит некоторые звуки операционной системы Windows
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Звуки_ОС
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer Плеер;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Звуковые сигналы ОС";
            Плеер = new System.Media.SoundPlayer();
            // Задаем названия командных кнопок:
            button1.Text = "Звук торжества \"та-да\"";
            button2.Text = "Звук завершения процесса";
            button3.Text = "Звук ошибки";
            button4.Text = "Частота звука = 1000 гц";
            button5.Text = "Загрузка Windows";
            button6.Text = "Выход из Windows";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Воспроизведение звукового WAV-файла
            Плеер.SoundLocation = @"c:\windows\media\tada.wav";
            Плеер.Play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Класс SystemSounds получает звуки, связанные с набором
            // типов звуковых событий операционной системы Windows:
            System.Media.SystemSounds.Asterisk.Play();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Звуковой сигнал частотой 1000 Гц и длительностью 0.5 секунд:
            Console.Beep(1000, 500);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Плеер.SoundLocation =
                            @"c:\windows\media\Windows Logon Sound.wav";
            Плеер.Play();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Плеер.SoundLocation =
                            @"c:\windows\media\Windows Shutdown.wav";
            Плеер.Play();
        }
    }
}
