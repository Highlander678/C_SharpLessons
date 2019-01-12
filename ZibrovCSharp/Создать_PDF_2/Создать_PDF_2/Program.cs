// Данная программа "на лету" генерирует PDF-документ
// ~ ~ ~ ~ ~ ~ ~ ~
// Добавляем ссылку на библиотеку itextsharp.dll:
// Project | Add References и на вкладке Browse (Обзор)
// находим файл itextsharp.dll.
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~
// Добавляем пространство имен для более коротких выражений:
using iTextSharp.text.pdf;
namespace Создать_PDF_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // В текущем каталоге создаем PDF-документ:
            var Документ = new iTextSharp.text.Document();
            PdfWriter.GetInstance(
                   Документ, new System.IO.FileStream(
                "Отчет.pdf", System.IO.FileMode.Create));
            Документ.Open();
            // Базовый шрифт создаем используя один из шрифтов из папки
            // Windows:
            var БазовыйШрифт = BaseFont.CreateFont(
              @"C:\WINDOWS\Fonts\comic.ttf", "CP1251", BaseFont.EMBEDDED);
            // @"C:\WINDOWS\Fonts\times.ttf", "CP1251", BaseFont.EMBEDDED);
            // @"C:\WINDOWS\Fonts\CONSOLA.TTF", "CP1251", BaseFont.EMBEDDED);
            // Задаем шрифт размером 10 пунктов. Можно задать
            // шрифт Font.ITALIC (наклонный) или Font.BOLD (жирный):
            var Шрифт = new iTextSharp.text.Font(
                           БазовыйШрифт, 10, iTextSharp.text.Font.NORMAL);
            Документ.Add(new iTextSharp.text.Paragraph(
                            "Здравствуйте!" + "\n" +
                            "Вы увлекаетесь Visual C# 12?", Шрифт));
            Документ.Close();
            // PDF-документ можно открыть с помощью интернет-браузера:
            // System.Diagnostics.Process.Start("IExplore.exe", System.IO.
            //           Directory.GetCurrentDirectory() + @"\Отчет.pdf");
            // PDF-документ можно открыть с помощью Adobe Acrobat,
            // если он установлен:
            System.Diagnostics.Process.Start("Отчет.pdf");
        }
    }
}
