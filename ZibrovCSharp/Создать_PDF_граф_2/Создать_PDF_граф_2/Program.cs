// Программа формирует изображение методами класса Graphics. Рисуем
// текстовую строку с использованием линейного градиента. Чтобы
// подчеркнуть, что мы создаем именно рисунок, а не просто текст,
// текстовую строку разворачиваем на некоторый угол к горизонту.
// Далее выводим сформированное изображение из оперативной памяти
// в PDF-файл
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Следует добавить эти три директивы:
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;
// Здесь добавлены ссылки на две объектные библиотеки:
// System.Drawing.dll и itextsharp.dll
namespace Создать_PDF_граф_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем точечное изображение размером 415 x 45 точек
            // с глубиной цвета 24
            var Рисунок = new Bitmap(415, 45,
                          System.Drawing.Imaging.
                          PixelFormat.Format24bppRgb);
            // Создаем новый объект класса Graphics из изображения Рисунок:
            var Графика = Graphics.FromImage(Рисунок);
            var Точка1 = new PointF(20.0F, 20.0F);
            var Точка2 = new PointF(415.0F, 20.0F);
            var Градиент = new System.Drawing.Drawing2D.
                               LinearGradientBrush(Точка1, Точка2,
                               Color.Yellow, Color.Red);
            var Шрифт = new System.Drawing.Font("Times new Roman", 14.0F);
            Графика.Clear(Color.White);
            // Разворачиваем мир на 356 градусов по часовой стрелке:
            Графика.RotateTransform(356.0F);
            // 20.0f, 20.0f - это координаты левого нижнего угла строки:
            Графика.DrawString("Записываем графику в PDF-документ",
                                           Шрифт, Градиент, 20.0F, 20.0F);
            // Освобождение ресурсов:
            Графика.Dispose();
            // Создаем PDF-документ:
            var Документ = new Document();
            var Писатель = PdfWriter.GetInstance(Документ, new System.IO.
                           FileStream("ТаблГраф.pdf", 
                           System.IO.FileMode.Create));
            Документ.Open();
            var Изо = iTextSharp.text.Image.
                                    GetInstance(Рисунок, BaseColor.WHITE);
            Документ.Add(Изо);
            Документ.Close();
            Рисунок.Dispose();
            System.Diagnostics.Process.Start("ТаблГраф.pdf");
        }
    }
}
