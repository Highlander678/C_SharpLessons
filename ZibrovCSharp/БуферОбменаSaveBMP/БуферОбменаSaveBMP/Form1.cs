// Программа читает буфер обмена, и если данные в нем представлены
// в формате растровой графики, то записывает их в BMP-файл
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace БуферОбменаSaveBMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Сохраняю копию БО в BMP-файл";
            button1.Text = "Сохранить";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Объявление объекта-получателя из буфера обмена
            var Получатель = Clipboard.GetDataObject();
            Bitmap Растр;
            // Если данные в буфере обмена представлены в формате Bitmap...
            if (Получатель.GetDataPresent(DataFormats.Bitmap) == true)
            {
                // то записать их из БО в переменную Растр в формате Bitmap
                var Объект = Получатель.GetData(DataFormats.Bitmap);
                Растр = (Bitmap)Объект;
                // Сохранить изображение в файле Clip.bmp
                Растр.Save(@"D:\Clip.BMP");
                // this.Text = "Сохранено в файле D:\Clip.BMP":
                // button1.Text = "Еще записать?";
                MessageBox.Show(
                @"Изображение из БО записано в файл D:\Clip.BMP", "Успех");
            }
            else
                // В БО нет данных в формате изображений
                MessageBox.Show(
                    "В буфере обмена нет данных в формате Bitmap",
                    "Запишите какое-либо изображение в БО");
        }
    }
}
