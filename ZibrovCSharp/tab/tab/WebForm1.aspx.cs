// Таблица с переменным числом ячеек, управляемая двумя раскрывающимися
// списками. Веб-страница позволяет с помощью двух раскрывающихся
// списков DropDownList заказать необходимое число рядов и столбцов в
// таблице, а затем строить заказанную таблицу
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace tab
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Укажите размерность таблицы";
            if (Page.IsPostBack == true) return;
            // Заполнять выпадающий список необходимо при первой загрузке
            // страницы IsPostBack = false, иначе будут добавляться новые
            // пункты в выпадающей список при каждой перегрузке страницы
            DropDownList1.Items.Add("1");
            DropDownList1.Items.Add("2");
            DropDownList1.Items.Add("3");
            DropDownList2.Items.Add("1");
            DropDownList2.Items.Add("2");
            DropDownList2.Items.Add("3");
            Table1.Caption = "Название таблицы";
            Table1.CaptionAlign = TableCaptionAlign.Right;
            Table1.ToolTip =
                "Укажи количество рядов и столбцов и нажми кнопку";
            Table1.BorderStyle = BorderStyle.Solid;
            Table1.GridLines = GridLines.Both;
            Label1.Text = "- количество строк";
            Label2.Text = "- количество столбцов";
            Button1.Text = "Обновить таблицу";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Один цикл по ячейкам таблицы вложен в другой по ее рядам:
            for (int i = 1; i <= int.Parse(
                                 DropDownList1.SelectedItem.Value); i++)
            {
                var РЯД = new TableRow();
                // Цикл по ячейкам:
                for (int j = 1; j <= int.Parse(
                                 DropDownList2.SelectedItem.Value); j++)
                {
                    var ЯЧЕЙКА = new TableCell();
                    ЯЧЕЙКА.Text = String.Format("Ряд {0}, Колон {1}", i, j);
                    ЯЧЕЙКА.HorizontalAlign = HorizontalAlign.Center;
                    РЯД.Cells.Add(ЯЧЕЙКА);
                }
                Table1.Rows.Add(РЯД);
            }
        }
    }
}