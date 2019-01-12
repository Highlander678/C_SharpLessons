// Программа реализует функции проигрывателя Windows Media Player 12
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Player
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            // ВЕРСИЯ ПЛЕЕРА
            this.Text = "Windows Media Player, версия = " +
                axWindowsMediaPlayer1.versionInfo;
        }
        private void открытьToolStripMenuItem_Click(
                                 object sender, EventArgs e)
        {
            // ПУНКТ МЕНЮ Открыть.
            // Пользователь выбирает файл:
            openFileDialog1.ShowDialog();
            // Передача плееру имени файла
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            // axWindowsMediaPlayer1.URL = @"C:\WINDOWS\Media\tada.wav";
            // Команда на проигрывание файла
            axWindowsMediaPlayer1.Ctlcontrols.play();
            // ИЛИ ТАК: передача имени файла и сразу PLAY
            // axWindowsMediaPlayer1.openPlayer(openFileDialog1.FileName);
        }
        private void выходToolStripMenuItem_Click(
                                              object sender, EventArgs e)
        {
            // ПУНКТ МЕНЮ Выход
            Application.Exit();
        }
        private void полныйЭкранToolStripMenuItem_Click(
                                              object sender, EventArgs e)
        {
            // ПУНКТ МЕНЮ Полный экран.
            // Если плеер пребывает в состоянии PLAY, то можно
            // перейти в режим полного экрана:
            if (axWindowsMediaPlayer1.playState ==
                                     WMPLib.WMPPlayState.wmppsPlaying)
                axWindowsMediaPlayer1.fullScreen = true;
        }
        private void паузаToolStripMenuItem_Click(
                                              object sender, EventArgs e)
        {
            // ПУНКТ МЕНЮ Пауза
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void playToolStripMenuItem_Click(
                                              object sender, EventArgs e)
        {
            // ПУНКТ МЕНЮ Play
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void выклЗвукToolStripMenuItem_Click(
                                              object sender, EventArgs e)
        {
            // ПУНКТ МЕНЮ Выкл звук
            axWindowsMediaPlayer1.settings.mute = true;
        }
        private void вклЗвукToolStripMenuItem_Click(
                                              object sender, EventArgs e)
        {
            // ПУНКТ МЕНЮ Вкл звук
            axWindowsMediaPlayer1.settings.mute = false;
        }
        private void свойстваToolStripMenuItem_Click(
                                              object sender, EventArgs e)
        {
            // ПУНКТ МЕНЮ Свойства
            axWindowsMediaPlayer1.ShowPropertyPages();
        }
    }
}
