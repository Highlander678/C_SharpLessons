// Вывод в веб-форму хэш-таблицы, которая позволяет поставить в
// соответствие государства их столицам. То есть в качестве ключей
// имеем государства, а их столицы - в качестве значений. Далее,
// используя элемент управления GridView, программа выводит эту
// хэш-таблицу на веб-страницу
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Hash_Grid
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Пример хэш-таблицы";
            var Хэш = new System.Collections.Hashtable();
            // Заполнение хэш-таблицы:
            // Можно добавлять записи "ключ-занчение" так:
            Хэш["Украина"] = "Киев";
            // А можно добавлять так:
            Хэш.Add("Россия", "Москва");
            // Здесь государство - это ключ, а столица - это значение
            Хэш.Add("Белоруссия", "Минск");
            // Создаем обычную таблицу (не хэш):
            var Таблица = new System.Data.DataTable();
            // Заполнение "шапки" таблицы вывода
            Таблица.Columns.Add("ГОСУДАРСТВА");
            Таблица.Columns.Add("СТОЛИЦЫ");
            // В цикле заполняем обычную таблицу парами из хэш-таблицы
            // по рядам:
            foreach (System.Collections.DictionaryEntry ОднаПара in Хэш)
                // Здесь структура DictionaryEntry определяет
                // пару ключ-значение
                Таблица.Rows.Add(ОднаПара.Key, ОднаПара.Value);

            // Немного другое свойство, чем в WindowsApplication:
            GridView1.Caption = "Таблица государств"; // Заголовок таблицы
            GridView1.BorderWidth = Unit.Pixel(2);
            GridView1.BorderColor = System.Drawing.Color.Gray;
            // Источник данных для GridView
            GridView1.DataSource = Таблица;
            // Этого нет в WindowsApplication
            GridView1.DataBind();
        }
    }
}