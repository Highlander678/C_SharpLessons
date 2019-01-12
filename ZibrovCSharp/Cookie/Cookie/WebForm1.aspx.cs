// Чтение/запись cookie-файлов. Веб-страница предлагает посетителю ввести
// данные о себе: имя и род занятий. При нажатии кнопки "Запись Cookie"
// введенные в текстовые поля сведения будут записаны в cookie-файл. Этот
// cookie-файл будет храниться на компьютере пользователя сутки. В течение
// этих суток, каждый раз вызывая данную страницу, в текстовых полях мы
// будем видеть введенные нами сведения, которые мы можем тут же исправлять
// и опять записывать в cookie
using System;
using System.Web;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Введите данные о себе";
            // При повторной отправке выйти из процедуры
            if (Page.IsPostBack == true) return;
            Label1.Text = "Имя посетителя";
            Label2.Text = "Род занятий";
            Button1.Text = "Запись Cookie";
            // ЧТЕНИЕ COOKIE.
            // Cookie может быть целая коллекция:
            // Dim CookieN As HttpCookieCollection
            HttpCookie Куки;
            // Читаю только один раздел cookie "О посетителе страницы"
            Куки = Request.Cookies.Get("О посетителе страницы");
            // Если на машине клиента нет такого cookie
            if (Куки == null) return;
            // А если есть, то заполняю текстовые поля из cookie
            TextBox1.Text = Куки["Имя посетителя"];
            TextBox2.Text = Куки["Род занятий посетителя"];
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // ЗАПИСЬ COOKIE
            var Куки = new HttpCookie("О посетителе страницы");
            // Запись двух пар "имя (ключ) – значение"
            Куки["Имя посетителя"] = TextBox1.Text;
            Куки["Род занятий посетителя"] = TextBox2.Text;
            // Установка даты удаления cookie: сейчас плюс один день
            Куки.Expires = DateTime.Now.AddDays(1);
            // Добавление раздела "О посетителе страницы" в cookie-файл
            Response.Cookies.Add(Куки);
        }
    }
}