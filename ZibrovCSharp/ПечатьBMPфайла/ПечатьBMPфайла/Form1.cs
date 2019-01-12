// Эта программа выводит на печать файл с расширением bmp
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ПечатьBMPфайла
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = @"Печать файла d:\pic.bmp";
            button1.Text = "Печать";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Пользователь щелкнул на кнопке
            try
            {
                printDocument1.Print();
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show("Ошибка печати на принтере\n",
                                                     Ситуация.Message);
            }
        }
        private void printDocument1_PrintPage(object sender, System.
                                  Drawing.Printing.PrintPageEventArgs e)
        {
            // Это событие возникает, когда вызывают метод Print().
            // Рисование содержимого BMP-файла
            e.Graphics.DrawImage(Image.FromFile(@"D:\pic.bmp"),
                                       e.Graphics.VisibleClipBounds);
            // Следует ли распечатывать следующую страницу?
            e.HasMorePages = false;
        }
    }
}
