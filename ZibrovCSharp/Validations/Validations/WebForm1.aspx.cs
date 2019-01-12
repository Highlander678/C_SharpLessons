// Проверка достоверности ввода имени, адреса e-mail, URL-адреса и пароля.
// Веб-страница проверяет ввод пользователем имени, e-mail-адреса, 
// URL-адреса и пароля, например, при регистрации пользователя. Причем
// если страница (веб-форма) успешно прошла все этапы проверки, то
// направляем пользователя на другую, уже разрешенную для этого
// пользователя, веб-страницу.
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Validations
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Обработка события "загрузка страницы"
            Page.Title = "Заполните следующие поля:"; TextBox1.Focus();
            Label1.Text = "Имя"; Label2.Text = "E-Mail";
            Label3.Text = "Персональная веб-страница";
            Label4.Text = "Пароль"; Label5.Text = "Подтвердите пароль";
            TextBox4.TextMode = TextBoxMode.Password;
            TextBox5.TextMode = TextBoxMode.Password;
            // Контролируем факт заполнения четырех текстовых полей:      
            RequiredFieldValidator1.ControlToValidate = "TextBox1";
            RequiredFieldValidator1.EnableClientScript = false;
            RequiredFieldValidator1.ErrorMessage =
                         "* Следует заполнить это текстовое поле";
            RequiredFieldValidator2.ControlToValidate = "TextBox2";
            RequiredFieldValidator2.EnableClientScript = false;
            RequiredFieldValidator2.ErrorMessage =
                         "* Следует заполнить это текстовое поле";
            RequiredFieldValidator3.ControlToValidate = "TextBox3";
            RequiredFieldValidator3.EnableClientScript = false;
            RequiredFieldValidator3.ErrorMessage =
                         "* Следует заполнить это текстовое поле";
            RequiredFieldValidator4.ControlToValidate = "TextBox4";
            RequiredFieldValidator4.EnableClientScript = false;
            RequiredFieldValidator4.ErrorMessage =
                         "* Следует заполнить это текстовое поле";
            RegularExpressionValidator1.ControlToValidate = "TextBox2";
            RegularExpressionValidator1.EnableClientScript = false;
            // Контроль правильности ведения E-mail адреса и адреса
            // веб-страницы:
            RegularExpressionValidator1.ValidationExpression =
                         @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            RegularExpressionValidator1.ErrorMessage =
                             "* Следует ввести правильный адрес E-mail";
            RegularExpressionValidator2.ControlToValidate = "TextBox3";
            RegularExpressionValidator2.EnableClientScript = false;
            RegularExpressionValidator2.ValidationExpression =
                            @"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
            RegularExpressionValidator2.ErrorMessage =
                            "* Следует ввести правильный адрес веб-узла";
            // Контроль правильности введения паспорта путем сравнения             
            // содержимого двух полей:                                             
            CompareValidator1.ControlToValidate = "TextBox4";
            CompareValidator1.ControlToCompare = "TextBox5";
            CompareValidator1.EnableClientScript = false;
            CompareValidator1.ErrorMessage = "* Вы ввели разные паспорта";
            Button1.Text = "Готово";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Обработка события "щелчок на кнопке"
            if (Page.IsPostBack == true)
                if (Page.IsValid == true)
                    // Здесь можно записать введенные пользователем сведения
                    // в базу данных. Перенаправление на следующую страницу:
                    Response.Redirect("Next_Page.html");
        }
    }
}
