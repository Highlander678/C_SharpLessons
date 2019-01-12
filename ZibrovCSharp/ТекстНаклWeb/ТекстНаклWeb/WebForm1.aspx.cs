// Веб-страница формирует файл изображения методами класса Graphics. На
// изображение выводится текстовая строка, наклоненная к горизонту на 356
// градусов (наклон вверх). Далее этот файл изображения отображается в форме
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе.
// Добавим эту директиву для более кратих выражений:
using System.Drawing;
namespace ТекстНаклWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Вывод даты";
            // Создаем точечное изображение размером 230 x 40 точек
            // с глубиной цвета 24
            var Рисунок = new Bitmap(230, 40,
          System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            // Создаем новый объект класса Graphics из изображения Рисунок
            var Графика = Graphics.FromImage(Рисунок);
            // Теперь становятся доступными методы класса Graphics !
            // Заливка поверхности указанным цветом
            Графика.Clear(Color.AliceBlue);
            // или Графика.Clear(ColorTranslator.FromHtml("#ECECFF"));
            // Вывод в строку полной даты:
            var Дата = String.Format("Сегодня {0:D}", DateTime.Now);
            // Разворачиваем мир на 356 градусов по часовой стрелке.
            // То есть ось X направлена влево, ось Y - вниз, а углы
            // отсчитываются от оси X в сторону Y.
            Графика.RotateTransform(356.0F);
            var Фонт = new Font("Times New Roman", 14,
                                           FontStyle.Regular);
            // Выводим на изображение текстовую строку Дата,
            // x=5, y=15 - координаты левого верхнего угла строки
            Графика.DrawString(Дата, Фонт, Brushes.Red, 5, 15);
            // Определяем физический путь файла для текущего веб-узла,
            // сохраняем изображение в файле risunok.jpg каталога веб-узла
            Рисунок.Save(Request.PhysicalApplicationPath + "risunok.jpg",
                                 System.Drawing.Imaging.ImageFormat.Jpeg);
            // Возможность вывода изображения в исходящий поток ответа НТТР:
            // Рисунок.Save(Response.OutputStream, System.Drawing.
            //                                    Imaging.ImageFormat.Jpeg);
            // Цвет и ширина рамки рисунка:
            Image1.BorderColor = Color.Red;
            Image1.BorderWidth = 2;
            // Указываем виртуальный путь к файлу изображения
            Image1.ImageUrl = Request.ApplicationPath + "risunok.jpg";
            // Освобождение ресурсов
            Рисунок.Dispose(); Графика.Dispose();
        }
    }
}
