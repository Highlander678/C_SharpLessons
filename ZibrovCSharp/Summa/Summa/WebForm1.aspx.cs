// Создание простейшей активной веб-страницы на Visual C# 11.
// Веб-страница демонстрирует способность складывать числа, введенные
// пользователем
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Summa
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Обработка события "загрузка страницы"
            Page.Title = "Введите два числа";
            Label1.Text = String.Empty;
            Button1.Text = "Найти сумму двух чисел";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Обработка события "щелчок на кнопке"
            var Z = Convert.ToDouble(TextBox1.Text) +
                       Convert.ToDouble(TextBox2.Text);
            Label1.Text = String.Format("Сумма = {0}", Z);
        }
    }
}