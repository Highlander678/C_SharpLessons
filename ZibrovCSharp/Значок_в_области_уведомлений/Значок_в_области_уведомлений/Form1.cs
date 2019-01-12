// Эта программа сообщает пользователю время, прошедшее с момента
// старта операционной системы на данном компьютере. Доступ к этой
// информации реализован через контекстное меню значка в области
// уведомлений панели задач
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Значок_в_области_уведомлений
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Создаю значок в области уведомлений";
            // Задаем размер метки
            label1.Size = new Size(364, 107);
            // Разрешаем продолжение текста в метке с новой строки
            label1.AutoSize = false;
            label1.Text =
                "При щелчке на командной кнопке данная программа " +
                "размещает значок в область уведомлений. Щелкните " +
                "правой кнопкой мыши на этом значке для доступа к " +
                "контекстному меню с пунктами \"Время " +
                "работы ОС\" и \"Выход\"" +
                ". Двойной щелчок на значке возвращает " +
                "на экран данную форму.";
            button1.Text = "Разместить значок в область уведомлений";
            //             SystemIcons - это стандартные значки Windows
            notifyIcon1.Icon = SystemIcons.Shield; // значок щита
            //             SystemIcons.Information - значок сведений
            notifyIcon1.Text = "Время работы ОС";
            notifyIcon1.Visible = false;
            // "Привязываем" контекстное меню к значку notifyIcon1
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Скрыть экранную форму и сделать видимым значок
            // в области уведомлений
            this.Hide(); notifyIcon1.Visible = true;
        }
        private void notifyIcon1_MouseDoubleClick(
                              object sender, MouseEventArgs e)
        {
            // Чтобы получить пустой обработчик этого события, можно,
            // например, в конструкторе формы дважды щелкнуть на
            // значке NotifyIcon1
            notifyIcon1.Visible = false; this.Show();
        }
        private void времяСтартаОСToolStripMenuItem_Click(
                                   object sender, EventArgs e)
        {
            var Время_работы_ОС_в_минутах =
                Environment.TickCount / 1000 / 60;
            // Формат "{0:F0}" округляет Double до целого значения:
            var ss = String.Format("ОС стартовала {0:F0} минут назад",
                                               Время_работы_ОС_в_минутах);
            MessageBox.Show(ss);
        }
        private void выходToolStripMenuItem_Click(
                                        object sender, EventArgs e)
        {
            notifyIcon1.Dispose(); // Синтаксис C++: delete NotifyIcon1
            Application.Exit();
        }
    }
}
