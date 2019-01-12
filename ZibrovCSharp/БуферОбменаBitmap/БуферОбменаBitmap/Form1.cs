// Программа оперирует буфером обмена, когда тот содержит изображение
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace БуферОбменаBitmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Содержимое БО:";
            button1.Text = "Извлечь из БО";
            // Размеры графического окна:
            pictureBox1.Size = new Size(184, 142);
            // Записать в PictureBox изображение из файла:
            try
            {
                pictureBox1.Image = Image.FromFile(
                      System.IO.Directory.
                      GetCurrentDirectory() + @"\poryv.png");
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {  // Обработка исключительной ситуации:
                MessageBox.Show(
                    "Нет такого файла\n" + Ситуация.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                button1.Enabled = false;
                return;
            }
            // Записать в БО изображение из графического окна формы
            Clipboard.SetDataObject(pictureBox1.Image);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Объявление объекта-получателя из буфера обмена
            var Получатель = Clipboard.GetDataObject();
            Bitmap Растр;
            // Если данные в БО представлены в формате Bitmap...
            if (Получатель.GetDataPresent(DataFormats.Bitmap) == true)
            {
                // то записать эти данные из БО в переменную
                // Растр в формате Bitmap:
                Растр = (Bitmap)Получатель.GetData(DataFormats.Bitmap);
                pictureBox1.Image = Растр;
            }
        }
    }
}
