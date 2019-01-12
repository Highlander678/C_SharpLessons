// Данная программа "на лету" генерирует PDF-документ
// Добавляем ссылку на библиотеку itextsharp.dll:
// Project | Properties | Add References и на вкладке Browse (Обзор)
// находим файл itextsharp.dll.
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Создать_PDF_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // В текущем каталоге создаем PDF-документ:
            var Документ = new iTextSharp.text.Document();
            iTextSharp.text.pdf.PdfWriter.GetInstance(
                   Документ, new System.IO.FileStream(
                "Отчет.pdf", System.IO.FileMode.Create));
            Документ.Open();
            Документ.Add(
                new iTextSharp.text.Paragraph("Hello !" + "\n" +
                                   "Do you like Visual C# 11 ?"));
            Документ.Close();
            // PDF-документ можно открыть с помощью Adobe Acrobat,
            // если он установлен:
            System.Diagnostics.Process.Start("Отчет.pdf");
            // Также созданный PDF-документ можно открыть с помощью
            // какого-либо веб-обозревателя, например, Internet Explorer:
            // var ТекущийКаталог = System.IO.Directory.
            //                               GetCurrentDirectory();
            // System.Diagnostics.Process.Start(
            //          "IExplore.exe", ТекущийКаталог + @"\Отчет.pdf");
        }
    }
}
