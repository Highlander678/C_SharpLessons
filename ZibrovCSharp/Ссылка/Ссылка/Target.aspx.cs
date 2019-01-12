// Передача данных между веб-страницами через параметры гиперссылки.
// На этой новой странице Target.aspx.cs с помощью объекта Request
// получаем оба переданных параметра и выводим их в веб-документе
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Ссылка
{
    public partial class Target : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Получаем параметры, переданные с веб-страницы, с которой была
            // вызвана данная страница
            // Request - это запрос
            var ИМЯ1 = Request.QueryString.Get("N1");
            var ИМЯ2 = Request.QueryString.Get("N2");
            try
            {
                var URL = Request.UrlReferrer.AbsoluteUri;
                Response.Write("<br />Вы попали на данную веб-" +
                                        "страницу со страницы: " + URL + "<br />");
                Response.Write("<br />Страница " + URL + " передала на " +
                            "данную страницу имя: " + ИМЯ1 + " и фамилию " + ИМЯ2);
            }
            catch (Exception Ситуация)
            {
                Response.Write("<br />Вы пытаетесь попасть на данную страницу " +
                   "не через ссылку, а набрав URL-адрес в адресной " +
                   "строке браузера.<br />" +
                Ситуация.Message);
            }
        }
    }
}