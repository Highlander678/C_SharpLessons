// Веб-страница демонстрирует, как можно организовать переход 
// на разные страницы сайта (гиперссылки) с помощью раскрывающегося
// списка DropDownList
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Menu
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Переход на другую страницу:";
            if (Page.IsPostBack == true) return;
            // Можно писать так:
            // var it1 = new ListItem();
            // it1.Text = "Сложить два числа";
            // it1.Value = "Summa.aspx";
            // DropDownList1.Items.Add(it1);
            // А можно короче:
            // DropDownList1.Items.Add(new ListItem("Имя", "значение"));
            DropDownList1.Items.Add(new ListItem(
                           "Остаться на этой странице", "WebForm1.aspx"));
            DropDownList1.Items.Add(new ListItem(
                    "Проверка достоверности введенных данных",
                                                     "Validations.aspx"));
            DropDownList1.Items.Add(new ListItem(
                    "Управляемая таблица", "tab.aspx"));
            // Делать ли повторную отправку (постбэк), когда
            // пользователь сделает выбор в раскрывающемся списке?
            DropDownList1.AutoPostBack = true;
            // При AutoPostBack = true будет работать
            // событие DropDownList1_SelectedIndexChanged.
            Label1.Text = "Перейти на другую веб-страницу:";
        }
        protected void DropDownList1_SelectedIndexChanged(
                                            Object sender, EventArgs e)
        {
            // Выполнить команду перейти на другую стрвницу:
            Response.Redirect(DropDownList1.SelectedValue);
        }
        //protected void Page_PreInit(object sender, EventArgs e) 
        //{ 
        // Мы могли бы заполнять пункты раскрывающегося списка DropDownList
        // не при загрузке формы, а при ее инициализации (событие 
        // Page_PreInit), тогда не думать про постбэк.
        // Чтобы получить обработчик этого события, надо просто его
        // написать: protected void Page_PreInit...
        //}
    }
}
