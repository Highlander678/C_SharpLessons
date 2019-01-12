// На начальной веб-странице имеем командную кнопку "ПЕРЕХОД" и текстовое
// поле, которое заполняет пользователь. После щелчка на кнопке происходит
// переход на другую веб-страницу. На новой странице отображается
// содержимое текстового поля и надпись на кнопке из предыдущей страницы
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Передача2
{
    public partial class ishod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Text = "ПЕРЕХОД";
            Button1.PostBackUrl = "res.aspx";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Response.Redirect("res.aspx");
        }
    }
}