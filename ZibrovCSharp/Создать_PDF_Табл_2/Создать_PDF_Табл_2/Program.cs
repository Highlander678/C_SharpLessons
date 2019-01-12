// Программа "на лету" создает PDF-файл, и записывает в этот
// файл "узкую" таблицу с малым числом колонок
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~
// Следует добавить эти две директивы:
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Создать_PDF_Табл_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализируем два строковых массива:
            String[] Столицы = { "СТОЛИЦЫ", "Киев", "Москва", "Минск" };
            String[] Страны = {
                     "ГОСУДАРСТВА", "Украина", "Россия", "Белоруссия" };
            // В текущем каталоге создаем PDF-документ:
            var Документ = new Document();
            var Писатель = PdfWriter.GetInstance(Документ, new System.
             IO.FileStream("ОтчетТабл.pdf", System.IO.FileMode.Create));
            // System.IO.FileMode.Create - если такой файл уже есть, то он
            // будет удален, а новый создан
            Документ.Open();
            // Базовый шрифт создаем из одного из шрифтов из папки Windows:
            var БазовыйШрифт = BaseFont.CreateFont(
               @"C:\WINDOWS\Fonts\times.ttf", "CP1251", BaseFont.EMBEDDED);
            // @"C:\WINDOWS\Fonts\comic.ttf", "CP1251", BaseFont.EMBEDDED);
            // @"C:\WINDOWS\Fonts\CONSOLA.TTF", "CP1251", 
            //                                          BaseFont.EMBEDDED);
            // Заказываем шрифт размером 10 пунктов. Можно заказать
            // шрифт Font.ITALIC (наклонный) или Font.BOLD (жирный):
            var Шрифт = new Font(БазовыйШрифт, 10,
                                          Font.NORMAL, BaseColor.BLUE);
            // или цвет текста отдельно: Шрифт.Color = BaseColor.RED:
            var Таблица = new PdfPTable(2);
            var Ячейка = new PdfPCell();
            Ячейка.HorizontalAlignment = Element.ALIGN_LEFT; // ALIGN_CENTER
            // Две ячейки объединить в одну:
            Ячейка.Colspan = 2;
            // Границы ячейки не показывать:
            Ячейка.Border = 0;
            // Высота ячейки:
            Ячейка.FixedHeight = 16.0F;
            Ячейка.Phrase = new Phrase(
                                "Какой-либо текст до таблицы", Шрифт);
            Таблица.AddCell(Ячейка);
            Ячейка.BackgroundColor = BaseColor.LIGHT_GRAY;
            // Не объединять ячейки:
            Ячейка.Colspan = 1;
            // Границы ячеек показывать:
            Ячейка.Border = 15;
            for (int i = 0; i <= 3; i++)
            {
                Ячейка.Phrase = new Phrase(Страны[i], Шрифт);
                Таблица.AddCell(Ячейка);
                Ячейка.Phrase = new Phrase(Столицы[i], Шрифт);
                Таблица.AddCell(Ячейка);
            }
            Ячейка.Colspan = 2; // две ячейки объединить в одну
            Ячейка.Border = 0;  // не показывать границ ячейки
            Ячейка.Phrase = new Phrase(
                     "Некоторый текст после таблицы", Шрифт);
            Ячейка.BackgroundColor = BaseColor.WHITE;
            Таблица.AddCell(Ячейка);
            // Регулируем ширину таблицы:
            Таблица.TotalWidth = Документ.PageSize.Width - 400;
            // Третий и четвертый параметры - это координаты
            // левого верхнего угла таблицы:
            Таблица.WriteSelectedRows(0, -1, 40,
                              Документ.PageSize.Height - 30,
                              Писатель.DirectContent);
            Документ.Close(); Писатель.Close();
            // PDF-документ можно открыть с помощью интернет-браузера:
            System.Diagnostics.Process.Start("IExplore.exe", System.IO.
                   Directory.GetCurrentDirectory() + @"\ОтчетТабл.pdf");
        }
    }
}
