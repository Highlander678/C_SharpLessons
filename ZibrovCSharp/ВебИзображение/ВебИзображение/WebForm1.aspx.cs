// На странице имеем изображение - файл poryv.png, при щелчке мышью на
// нем изображение увеличивается вдвое без перезагрузки веб-страницы
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВебИзображение
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Щелкнуть мышью для увеличения";
            // Указываем виртуальный путь к файлу изображения
            Image1.ImageUrl = Request.ApplicationPath + "poryv.png";
            // Получаем URL, который используется в браузере
            var адрес = ResolveClientUrl(Image1.ImageUrl);
            // Добавляем атрибут Alt
            Image1.AlternateText = 
                      "Двойной щелчок возвращает в исходный размер";
            // Добавляем два события JavaScript
            Image1.Attributes.Add("onclick", "this.src='" +
                        адрес + "';this.height=200;this.width=200");
            Image1.Attributes.Add("ondblclick", "this.src='" +
                        адрес + "';this.height=100;this.width=100");
        }
    }
}