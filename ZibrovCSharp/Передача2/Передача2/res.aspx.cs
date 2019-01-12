// Получаем данные со страницы ishod.aspx
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Передача2
{
    public partial class res : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Создаем объекты, как на форме-источнике:
                TextBox TекстовоеПоле = (TextBox)Page.PreviousPage.
                                           FindControl("TextBox1");
                Button Кнопка = (Button)Page.PreviousPage.
                                            FindControl("Button1");
                // Значения элементов управления могут быть также получены
                // c помощью метода Form.Get объекта Request:
                var S1 = Request.Form.Get("TextBox1");
                var S2 = Request.Form.Get("Button1");
                Response.Write("На начальной странице: <br />");
                Response.Write(" - cодержимое текстового поля: " +
                                        TекстовоеПоле.Text + "<br />");
                Response.Write(" - надпись на кнопке: " + Кнопка.Text);
            }
            catch (Exception Ситуация)
            {
                Response.Write("Начальная веб-страница должна " +
                               "содержать<br />текстовое поле и командную "
                               + "кнопку.<br />" + Ситуация.Message);
            }
        }
    }
}