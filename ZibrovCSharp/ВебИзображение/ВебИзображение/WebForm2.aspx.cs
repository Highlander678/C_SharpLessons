// На веб-странице имеем изображение, например мужчины, - файл m.jpg. Это
// изображение используем для ссылки на другую веб-страницу, например, на
// WebForm1.aspx. Причем при наведении на него указателя мыши происходит
// смена изображения на изображение женщины - файл g.jpg
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВебИзображение
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Элемент управления ImageButton отображает изображение и
            // отвечает за нажатия на нем указателя мыши
            ImageButton1.PostBackUrl = "WebForm1.aspx";
            // Указываем виртуальный путь к файлу изображения
            ImageButton1.ImageUrl = Request.ApplicationPath + "m.jpg";
            // Задаем альтернативный текст
            ImageButton1.AlternateText =
                           "Щелкните, чтобы перейти на WebForm1.aspx";
            // Добавляем два события JavaScript
            ImageButton1.Attributes.Add("onmouseover", "this.src='g.jpg'");
            ImageButton1.Attributes.Add("onmouseout", "this.src='m.jpg'");
        }
    }
}
