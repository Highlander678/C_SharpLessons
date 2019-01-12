// Данная веб-страница получает имя пользователя и адрес его электронной
// почты от веб-формы ishod.htm и отображает эти данные на странице
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Передача1
{
    public partial class res : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Прием данных от страницы ishod.htm";
            var Метод = Request.HttpMethod;
            var Имя = Request.Form.Get("name");
            var Почта = Request.Form.Get("email");
            Response.Write("Передача данных произведена методом " +
                                                      Метод + "<br />");
            Response.Write("Получено имя: " + Имя + "<br />");
            Response.Write("Получен адрес электронной почты: " + Почта);
        }
    }
}