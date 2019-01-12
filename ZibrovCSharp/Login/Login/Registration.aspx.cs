// Регистрация и аутентификация пользователя с помощью базы данных
// MS Access. Данный пример включает в себя три веб-формы: 
// Registration.aspx и Login.aspx и Secret.aspx. Первая форма
// Registration.aspx приглашает пользователя ввести регистрационные
// данные, проверяет правильность ввода имени пользователя и пароля
// с использованием валидаторов, регистрирует пользователя в базе данных
// MS Access и перенаправляет пользователя на уже разрешенный после
// регистрации ресурс Secret.aspx
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе.
// Добавим директиву для краткости выражений:
using System.Data.OleDb;
namespace Login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Обработка события "загрузка страницы"
            Page.Title = "РЕГИСТРАЦИЯ";
            Label1.Text = "ВВЕДИТЕ РЕГИСТРАЦИОННЫЕ ДАННЫЕ";
            Label2.Text = "Имя"; Label3.Text = "Пароль";
            Label4.Text = "Подтвердите пароль";
            Button1.Text = "Готово"; TextBox1.Focus();
            TextBox2.TextMode = TextBoxMode.Password;
            TextBox3.TextMode = TextBoxMode.Password;
            // Контролируем факт заполнения двух текстовых полей:
            RequiredFieldValidator1.ControlToValidate = "TextBox1";
            RequiredFieldValidator1.EnableClientScript = false;
            RequiredFieldValidator1.ErrorMessage =
                         "* Следует заполнить это текстовое поле";
            RequiredFieldValidator2.ControlToValidate = "TextBox2";
            RequiredFieldValidator2.EnableClientScript = false;
            RequiredFieldValidator2.ErrorMessage =
                         "* Следует заполнить это текстовое поле";
            // Контроль правильности введения паспорта путем сравнения
            // содержимого двух полей:   
            CompareValidator1.EnableClientScript = false;
            CompareValidator1.ControlToValidate = "TextBox2";
            CompareValidator1.ControlToCompare = "TextBox3";
            CompareValidator1.ErrorMessage = "* Вы ввели разные паспорта";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Обработка события "щелчок на кнопке"
            // Запись в базу данных только при повторной отправке
            // и при достоверных данных
            if (IsPostBack == false || IsValid == false) return;
            // Здесь можно записать введенные пользователем сведения в БД.
            // Строка подключения:
            var СтрокаПодкл =
                         "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                         Server.MapPath("Web.mdb");
            // MapPath - возвращает физический путь
            // Создание экземпляра объекта Connection:
            var Подключение = new OleDbConnection(СтрокаПодкл);
            try
            {
                // Открытие подключения
                Подключение.Open();
            }
            catch (Exception Ситуация1)
            {
                Response.Write("<br><br>" + Ситуация1.Message);
                return;
            }
            var Команда = new OleDbCommand();
            // ДОБАВЛЕНИЕ ЗАПИСИ О ПОЛЬЗОВАТЕЛЕ В БД.
            // Строка SQL-запроса
            var SQL_запрос = 
                     "INSERT INTO [Аутентифицированные пользовате" +
                     "ли] ([Имя пользователя], [Пароль]) VALUES ('" +
                      TextBox1.Text + "', '" + TextBox2.Text + "')";
            // Создание объекта Command с заданием SQL-запроса
            Команда.CommandText = SQL_запрос;
            // Для добавления записи в БД эта команда обязательна
            Команда.Connection = Подключение;
            try
            {
                // Выполнение команды SQL, т. е. ЗАПИСЬ В БД
                Команда.ExecuteNonQuery();
            }
            catch (Exception Ситуация2)
            {
                Response.Write("<br><br>" + Ситуация2.Message);
                return;
            }
            Подключение.Close();
            // Перенаправление на уже разрешенную страницу
            Response.Redirect("Secret.aspx");
        }
    }
}
