// Вторая форма Login.aspx запрашивает имя пользователя и пароль, 
// проверяет наличие пользователя с таким именем и паролем в базе
// данных. Если такого пользователя не оказалось, то форма отправляет
// пользователя на регистрацию Registration.aspx, а если есть, то он
// получает доступ к ресурсу Secret.aspx
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// Добавим директиву для краткости выражений:
using System.Data.OleDb;
namespace Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Логин"; Page.Form.Method = "post";
            Label1.Text = "АУТЕНТИФИКАЦИЯ ПОЛЬЗОВАТЕЛЯ";
            Label2.Text = "Имя"; Label3.Text = "Пароль";
            Label4.Text = String.Empty; Label5.Text = String.Empty;
            TextBox1.Focus(); TextBox2.TextMode = TextBoxMode.Password;
            Button1.Text = "Готово"; Button2.Text = "Регистрация";
            Button1.Width = 125; Button2.Width = 125;
            TextBox1.Width = 140; TextBox1.Width = 140;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Щелчок на кнопке "Готово"
            var ПОЛЬЗОВАТЕЛЬ_АУТЕНТИФИЦИРОВАН = false;
            // Строка подключения
            var СтрокаПодкл =
                  "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                                         Server.MapPath("Web.mdb");
            // Создание экземпляра объекта класса Connection
            var Подключение = new OleDbConnection(СтрокаПодкл);
            try
            {
                // Открытие подключения
                Подключение.Open();
            }
            catch (Exception Ситуация1)
            {
                Label5.Text = Ситуация1.Message;
            }
            // Строка SQL-запроса для проверки имени и пароля
            var SQL_запрос =
               "SELECT Пароль FROM [Аутентифицированные пользо" +
               "ватели] WHERE ([Имя пользователя] = '" +
               TextBox1.Text + "') AND (Пароль = '" + TextBox2.Text + "')";
            // Создание объекта Command с заданием SQL-запроса
            var Команда = new OleDbCommand();
            Команда.CommandText = SQL_запрос;
            Команда.Connection = Подключение;
            try
            {
                // Выполнение команды SQL
                var Читатель = Команда.ExecuteReader();
                if (Читатель.Read() == true)
                {
                    ПОЛЬЗОВАТЕЛЬ_АУТЕНТИФИЦИРОВАН = true;
                    Label4.Text = "Пользователь аутентифицирован";
                }
                else
                {
                    ПОЛЬЗОВАТЕЛЬ_АУТЕНТИФИЦИРОВАН = false;
                    Label4.Text = "Неправильное имя или пароль, " +
                                  "пожалуйста, зарегистрируйтесь!";
                }
            }
            catch (Exception Ситуация2)
            {
                Label5.Text = Label5.Text + "<br />" + Ситуация2.Message;
            }
            Подключение.Close();
            if (ПОЛЬЗОВАТЕЛЬ_АУТЕНТИФИЦИРОВАН == true)
                // Направляем пользователя на уже разрешенную страницу
                Response.Redirect("Secret.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            // Щелчок на кнопке "Регистрация"
            Response.Redirect("Registration.aspx");
        }
    }
}