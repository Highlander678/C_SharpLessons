// Программа, информирующая пользователя о тех клавишах и
// комбинациях клавиш, которые тот нажал
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace СобытияКлавиатуры
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Устанавливаем шрифт с фиксированной шириной (моноширный):
            this.Font = new Font(FontFamily.GenericMonospace, 14.0F);
            // Поскольку мы задали этот шрифт увеличинным (от 8 по умолчанию
            // до 14), форма окажется пропорционально увеличенной
            this.Text = "Какие клавиши нажаты сейчас:";
            label1.Text = String.Empty; label2.Text = String.Empty;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Здесь обрабатываем событие нажатия клавиши. При удержании
            // клавиши событие генерируется непрерывно.
            label1.Text = "Нажатая клавиша: " + e.KeyChar;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Здесь обрабатываем мгновенное событие первоначального
            // нажатия клавиши
            label2.Text = String.Empty;
            // Если нажата клавиша <Alt>
            if (e.Alt == true) label2.Text += "Alt: Yes\n";
            else label2.Text += "Alt: No\n";
            // Если нажата клавиша <Shift>
            if (e.Shift == true) label2.Text += "Shift: Yes\n";
            else label2.Text += "Shift: No\n";
            // Если нажата клавиша <Ctrl>
            if (e.Control == true) label2.Text += "Ctrl: Yes\n";
            else label2.Text += "Ctrl: No\n";
            label2.Text += String.Format(
                "Код клавиши: {0} \nKeyData: {1} \nKeyValue: {2}",
                                       e.KeyCode, e.KeyData, e.KeyValue);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Очистка меток при освобождении клавиши
            label1.Text = String.Empty; label2.Text = String.Empty;
        }
    }
}
