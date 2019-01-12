// Клиентское веб-приложение, потребляющее сервис веб-службы Центрального
// банка России для получения ежедневных курсов валют. На выходе
// приложения получаем таблицу курсов валют
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВебКлиентРоссия
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Text = "Курсы валют";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Создаем клиентское приложение веб-службы:
            //        http://www.cbr.ru/DailyInfoWebServ/DailyInfo.asmx
            // Создаем экземпляр удаленного класса:
            var Валюта = new ru.cbr.www.DailyInfo();
            var Дата = DateTime.Now;
            // Получение ежедневных курсов валют - уже не поддерживается:
            // var НаборДанных = Валюта.GetSeldCursOnDate(Дата);
            // Функция, актуальная сегодня:
            var НаборДанных = Валюта.GetCursOnDate(Дата);
            // Содержимое DataSet в виде строки XML для отладки:
            var СтрокаXML = НаборДанных.GetXml();
            // Указываем источник данных для сетки данных:
            GridView1.DataSource = НаборДанных;
            var tmp = GridView1.DataMember;
            GridView1.DataBind();
        }
    }
}