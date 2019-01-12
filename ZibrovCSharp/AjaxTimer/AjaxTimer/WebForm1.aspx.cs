// Веб-страница демонстрирует время на текстовой метке Label1. На эту
// метку каждую секунду копируем новое время, но обновляем при этом не
// всю форму, а только метку с помощью технологии AJAX
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace AjaxTimer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 1000; // миллисекунд = 1 сек
            Label1.Text = "Текущее время: " + 
                               DateTime.Now.ToLongTimeString();
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            // Обновление содержимого метки каждую секунду времени:
            Label1.Text = "Текущее время: " + 
                              DateTime.Now.ToLongTimeString();
        }
    }
}