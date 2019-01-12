// Веб-приложение, реализующее счетчик посещений сайта с использованием
// базы данных и объекта Session
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе.
// Добавим директиву для краткости выражений:
using System.Data.OleDb;
namespace Counter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Счетчик посещений сайта";
            if (Page.IsPostBack == true) return;
            Label1.Text = String.Empty;
            // При первой загрузке страницы выясняем IP-адрес посетителя
            var IP_адрес = Request.UserHostAddress;
            String URL_адрес;
            try
            {
                // Определение, с какой веб-страницы вы сюда пришли
                URL_адрес = Request.UrlReferrer.AbsoluteUri;
                Response.Write("<br /><br />Вы пришли на эту страницу "
                             + "со страницы " + URL_адрес);
            }
            catch // Ситуация As NothingReferenceException
            { // Если пришли на эту страницу, набрав URL-адрес
                // в адресной строке браузера
                URL_адрес = "Адресная строка браузера";
                Response.Write("<br /><br />Вы пришли на эту " +
                           "страницу набрав URL-адрес в адресной строке");
            }
            Response.Write("<br /><br />Вы пришли на эту страницу " +
                                               "с IP-адреса " + IP_адрес);
            // МАНИПУЛЯЦИИ С БД О ПОСЕЩЕНИИ ПОЛЬЗОВАТЕЛЯ.
            // Строка подключения
            var СтрокаПодкл =
              "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                                                Server.MapPath("Web.mdb");
            // Создание экземпляра объекта Connection
            var Подключение = new OleDbConnection(СтрокаПодкл);
            try
            {
                // Открытие подключения
                Подключение.Open();
            }
            catch (Exception Ситуация)
            {
                Response.Write("<br /><br />" + Ситуация.Message);
                Подключение.Close();
                return;
            }
            String SQL_запрос;
            var Команда = new OleDbCommand();
            // ЕСЛИ ОБ ЭТОМ ПОСЕЩЕНИИ ЕЩЕ НЕТ ЗАПИСИ
            if (Page.Session["ЕСТЬ ЛИ ЗАПИСЬ ОБ ЭТОМ ПОСЕЩЕНИИ?"] == null)
            {
                // ЕСЛИ НЕТ, ТО ДОБАВЛЯЕМ ЗАПИСЬ О ПОСЕЩЕНИИ В БД:
                var ДАТА = System.DateTime.Now.ToString();
                // Строка SQL-запроса:
                SQL_запрос =
                   "INSERT INTO [Таблица посещений веб-страницы] " +
                   "([Дата посещения], [IP-адрес посетителя], " +
                   "[С какой страницы пришли]) VALUES ('" + ДАТА +
                   "', '" + IP_адрес + "', '" + URL_адрес + "')";
                // Создание объекта Command с заданием SQL-запроса
                Команда.CommandText = SQL_запрос;
                // Для добавления записи эта команда обязательна
                Команда.Connection = Подключение;
                try
                {
                    // Выполнение команды SQL, т. е. ЗАПИСЬ В БД
                    Команда.ExecuteNonQuery();
                    Response.Write(
                    "<br /><br />В таблицу БД посещений добавлена запись");
                    // ТЕПЕРЬ ПОЯВИЛАСЬ ЗАПИСЬ ОБ ЭТОМ ПОСЕЩЕНИИ
                    Page.Session[
                               "ЕСТЬ ЛИ ЗАПИСЬ ОБ ЭТОМ ПОСЕЩЕНИИ?"] = "ДА";
                }
                catch (Exception Ситуация)
                {
                    Response.Write("<br /><br />" + Ситуация.Message);
                }
            }
            // ОПРЕДЕЛЕНИЕ КОЛИЧЕСТВА ЗАПИСЕЙ О ПОСЕЩЕНИИ
            // Новый SQL-запрос — это одна ячейка в новой таблице
            SQL_запрос = "SELECT COUNT(*) FROM [Таб" +
                                          "лица посещений веб-страницы]";
            Команда.CommandText = SQL_запрос;
            Команда.Connection = Подключение;
            // ExecuteScalar выполняет запрос и возвращает первую
            // колонку первого ряда таблицы запроса
            var КОЛ_ВО = 0;
            try
            {
                КОЛ_ВО = (int)Команда.ExecuteScalar();
            }
            catch (Exception Ситуация)
            {
                Response.Write("<br /><br />" + Ситуация.Message);
            }
            Подключение.Close();
            Label1.Text = String.Format(
                "Количество посещений страницы = {0}", КОЛ_ВО);
        }
    }
}
