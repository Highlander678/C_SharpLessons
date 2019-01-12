// Передача данных между веб-страницами через параметры гиперссылки. В
// данном примере имеем две веб-страницы: Source.aspx и Target.aspx. На
// первой странице Source.aspx с помощью генератора случайных чисел
// Random выбираем одну из пар "имя - фамилия", затем кодируем их, чтобы
// они не были видны в адресной строке. Щелчок пользователя на
// гиперссылке вызывает переход на страницу Target.aspx, причем в
// гиперссылке указаны оба закодированных параметра
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Ссылка
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // var Генератор = New Random(DateTime.Now.Millisecond)
            // или просто
            var Генератор = new Random();
            var ЧИСЛО = Генератор.Next(0, 3);
            var t1 = String.Empty;
            var t2 = String.Empty;
            switch (ЧИСЛО)
            {
                // Случайное попадание на одну из меток case:
                case 0:
                    t1 = "Витя"; t2 = "Зиборов"; break;
                case 1:
                    t1 = "Света"; t2 = "Ломачинская"; break;
                case 2:
                    t1 = "Андрей"; t2 = "Зиборов-младший"; break;
            }
            // Закодируем t1 и t2 для того, чтобы они не были видны в
            // адресной строке:
            t1 = System.Web.HttpUtility.UrlEncode(t1);
            t2 = System.Web.HttpUtility.UrlEncode(t2);
            HyperLink1.Text = "Щелкните эту ссылку для " +
                              "передачи данных на страницу Target.aspx";
            HyperLink1.NavigateUrl = "Target.aspx?n1=" + t1 + "&n2=" + t2;
        }
    }
}
