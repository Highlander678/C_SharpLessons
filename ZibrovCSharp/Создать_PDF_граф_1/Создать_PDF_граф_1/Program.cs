// Программа выводит в PDF-документ два изображения. Чтобы оптимальным
// образом их компоновать, эти два изображения выводим в ячейки некоторой
// таблицы, состоящей из двух колонок и трех строк. Ячейки в первой
// строке объединены в одну ячейку и в нее мы выводим текст "Как же нам
// найти гармонию между Ж и М ?". В две ячейки второй строки мы выводим
// два изображения. Ячейки в третьей строке мы также объединили в одну
// ячейку и также вывели здесь текст. Границы первой строки и последней
// мы не показываем
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~
// Следует добавить эти две директивы:
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Создать_PDF_граф_1
{
    class Program
    {
        static void Main(string[] args)
        {
                    // В текущем каталоге создаем PDF-документ:
        var Документ = new Document();
        var Писатель = PdfWriter.GetInstance(Документ, new System.
             IO.FileStream("ТаблГраф.pdf", System.IO.FileMode.Create));
        // System.IO.FileMode.Create - если такой файл уже есть, то он
        // будет удален, а новый создан
        Документ.Open();
        // Базовый шрифт создаем из одного из шрифтов из папки Windows:
        var БазовыйШрифт = BaseFont.CreateFont(
                @"C:\WINDOWS\Fonts\comic.ttf", "CP1251", BaseFont.EMBEDDED);
        // Заказываем шрифт размером 10 пунктов. Можно заказать
        // шрифт Font.ITALIC (наклонный) или Font.BOLD (жирный):
        var Шрифт = new Font(БазовыйШрифт, 10, Font.NORMAL, BaseColor.BLUE);
        // или цвет текста отдельно: Шрифт.Color = BaseColor.RED:
        var Таблица = new PdfPTable(2);
        var Ячейка = new PdfPCell();
        Ячейка.HorizontalAlignment = Element.ALIGN_CENTER;
        // Две ячейки объединить в одну:
        Ячейка.Colspan = 2;
        // Границы ячейки не показывать:
        Ячейка.Border = 0;
        // Высота ячейки:
        Ячейка.FixedHeight = 16.0F;
        Ячейка.Phrase = new Phrase(
                       "Как же нам найти гармонию между Ж и М ?", Шрифт);
        Таблица.AddCell(Ячейка);
        // Не объединять ячейки:
        Ячейка.Colspan = 1;
        // Границы ячеек показывать:
        Ячейка.Border = 15;
        // Увеличиваем высоту ячеек для изображений:
        Ячейка.FixedHeight = 83.0F;
        // Вставляем изображения в ячейки:
        Ячейка.Image = Image.GetInstance(@"D:\g.jpg");
        Таблица.AddCell(Ячейка);
        Ячейка.Image = Image.GetInstance(@"D:\m.jpg");
        Таблица.AddCell(Ячейка);
        Ячейка.Colspan = 2; // две ячейки объединить в одну
        Ячейка.Border = 0;  // не показывать границ ячейки
        Ячейка.Phrase = new Phrase(
               "Может, примем друг друга такими, как мы есть ?", Шрифт);
        Ячейка.BackgroundColor = BaseColor.WHITE;
        Таблица.AddCell(Ячейка);
        // Регулируем ширину таблицы:
        Таблица.TotalWidth = Документ.PageSize.Width - 380;
        // Третий и четвертый параметры - это координаты
        // левого верхнего угла таблицы:
        Таблица.WriteSelectedRows(0, -1, 40,
                 Документ.PageSize.Height - 30, Писатель.DirectContent);
        Документ.Close() ; Писатель.Close();
        // PDF-документ можно открыть с помощью интернет-браузера:
        System.Diagnostics.Process.Start("IExplore.exe", System.IO.
                     Directory.GetCurrentDirectory() + @"\ТаблГраф.pdf");
        }
    }
}
