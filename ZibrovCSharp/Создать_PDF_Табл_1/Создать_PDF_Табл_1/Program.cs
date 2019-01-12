// Программа "на лету" создает PDF-файл, и записывает в этот
// файл "широкую" таблицу
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~
// Для более компактных выражений добавим эти две директивы:
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Создать_PDF_Табл_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализируем четыре строковых массива:
            String[] Номер_п_п = { "N п/п", "1", "2", "3" };
            String[] Страны = { 
                    "ГОСУДАРСТВА", "Украина", "Россия", "Белоруссия" };
            String[] Столицы = { "СТОЛИЦЫ", "Киев", "Москва", "Минск" };
            String[] Население = { 
                    "НАСЕЛЕНИЕ", "2 760 000", "10 380 000", " 1 740 000" };
            // В текущем каталоге создаем PDF-документ:
            var Документ = new Document();
            var Писатель = PdfWriter.GetInstance(Документ, new System.
              IO.FileStream("ОтчетТабл1.pdf", System.IO.FileMode.Create));
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
            var Шрифт = new Font(БазовыйШрифт, 12, Font.NORMAL);
            // Цвет текста: 
            Шрифт.Color = BaseColor.BLUE;
            // Некорый текст до таблицы:
            Документ.Add(new Paragraph(
                         "Таблица государств:" + "\n\n", Шрифт));
            // Заказываем таблицу с четырьмя колонками:
            var Табл = new PdfPTable(4);
            // Таблицу выровнять в центр:
            Табл.HorizontalAlignment = Element.ALIGN_CENTER; // ALIGN_LEFT
            var Ячейка = new PdfPCell(new Phrase("Ячейка", Шрифт));
            // Пропорции размеров колонок в таблице:
            Single[] ШиринаКолонок = { 10.0F, 30.0F, 30.0F, 30.0F };
            Табл.SetTotalWidth(ШиринаКолонок);
            // Степень заливки ячейки:
            Ячейка.GrayFill = 0.92F;
            // Высота ячейки:
            Ячейка.FixedHeight = 20.0F;
            // Цвет границ ячеек:
            Ячейка.BorderColor = BaseColor.BLUE;
            // Выравнивание содержимого ячеек:
            Ячейка.HorizontalAlignment = Element.ALIGN_LEFT;// ALIGN_CENTER
            Ячейка.VerticalAlignment = Element.ALIGN_MIDDLE;
            // В цикле создаем каждую ячейку и добавляем ее в таблицу:
            for (int i = 0; i <= 3; i++)
            {
                Ячейка.Phrase = new Phrase(Номер_п_п[i], Шрифт);
                Табл.AddCell(Ячейка);
                Ячейка.Phrase = new Phrase(Страны[i], Шрифт);
                Табл.AddCell(Ячейка);
                Ячейка.Phrase = new Phrase(Столицы[i], Шрифт);
                Табл.AddCell(Ячейка);
                Ячейка.Phrase = new Phrase(Население[i], Шрифт);
                Табл.AddCell(Ячейка);
            }
            Документ.Add(Табл);
            Документ.Add(new Paragraph("Текст после таблицы", Шрифт));
            Документ.Close(); Писатель.Close();
            // PDF-документ можно открыть с помощью интернет-браузера:
            System.Diagnostics.Process.Start("IExplore.exe", System.IO.
                     Directory.GetCurrentDirectory() + @"\ОтчетТабл1.pdf");
            // PDF-документ можно открыть с помощью Adobe Acrobat,
            // если он установлен:
            System.Diagnostics.Process.Start("ОтчетТабл1.pdf");
        }
    }
}
