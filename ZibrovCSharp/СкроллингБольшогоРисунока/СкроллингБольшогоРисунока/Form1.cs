// Программа выводит изображение из растрового файла в PictureBox,
// размещенный на элементе управления Panel, с возможностью прокрутки
// изображения
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace СкроллингБольшогоРисунока
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Cкроллинг";
            // Назначаем размеры панели:
            // panel1.Size = new Size(200, 151);
            // Назначаем имя файла рисунка: 
            pictureBox1.Image = Image.FromFile(@"D:\Ris.JPG");
            // или pictureBox1.Image = new Bitmap(@"D:\Ris.JPG");
            // Размеры PictureBox в точности соответствуют изображению:
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            // Разрешаем прокрутку изображения:
            panel1.AutoScroll = true;
        }
    }
}
