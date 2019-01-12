// Вывод табличных данных в веб-форму с помощью элемента управления
// GridView. В данной веб-странице организован вывод двух строковых
// массивов в таблицу в веб-форму с помощью элемента управления GridView
// и объекта класса DataTable
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace TabGrdWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Вывод таблицы в веб-форму";
            String[] Имена = {"Андрей - раб", "ЖЭК",                            
                           "Мама - дом", "Карапузова Маша"};
            String[] Тлф = {"274-88-17", "22-345-72",                           
                         "570-38-76", "201-72-23-прямой моб"};
            var Таблица = new System.Data.DataTable();
            // Заполнение "шапки" таблицы 
            Таблица.Columns.Add("ИМЕНА");
            Таблица.Columns.Add("НОМЕРА ТЕЛЕФОНОВ");
            // Заполнение клеток (ячеек) таблицы
            for (var i = 0; i <= 3; i++)
                Таблица.Rows.Add(Имена[i], Тлф[i]);
            // Немного другое свойство, чем в WindowsApplication 
            GridView1.Caption = "Таблица телефонов";
            GridView1.BorderWidth = Unit.Pixel(2);
            GridView1.BorderColor = System.Drawing.Color.Gray;
            GridView1.DataSource = Таблица;
            // Этого нет в WindowsApplication  
            GridView1.DataBind();
        }
    }
}