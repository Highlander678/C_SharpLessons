// Проверка введенных пользователем числовых данных с помощью валидаторов.
// Выполним проверку, ввел ли пользователь хоть что-либо в текстовые поля,
// а также проверим тип введенных данных и выясним, соответствуют ли они
// типу данных Double
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Valid1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Обработка события "загрузка страницы"
            Page.Title = "Введите два числа";
            Label1.Text = String.Empty; Label1.Width = 180;
            Button1.Text = "Найти сумму двух чисел";
            Button1.Width = 180; TextBox1.Focus();
            TextBox1.Width = 180; TextBox2.Width = 180;
            // Установки валидаторов
            // Контролируем факт заполнения текстовых полей:
            RequiredFieldValidator1.ControlToValidate = "TextBox1";
            RequiredFieldValidator1.EnableClientScript = false;
            RequiredFieldValidator1.ErrorMessage =
                                 "* Следует заполнить это текстовое поле";
            RequiredFieldValidator2.ControlToValidate = "TextBox2";
            RequiredFieldValidator2.EnableClientScript = false;
            RequiredFieldValidator2.ErrorMessage =
                                 "* Следует заполнить это текстовое поле";
            // Проверяем, соответствуют ли данные, введенные в текстовые
            // поля типу Double:
            CompareValidator1.ControlToValidate = "TextBox1";
            CompareValidator1.EnableClientScript = false;
            CompareValidator1.Type = ValidationDataType.Double;
            CompareValidator1.Operator = 
                                  ValidationCompareOperator.DataTypeCheck;
            CompareValidator1.ErrorMessage = "* Следует вводить числа";
            CompareValidator2.ControlToValidate = "TextBox2";
            CompareValidator2.EnableClientScript = false;
            CompareValidator2.Type = ValidationDataType.Double;
            CompareValidator2.Operator = 
                                  ValidationCompareOperator.DataTypeCheck;
            CompareValidator2.ErrorMessage = "* Следует вводить числа";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Обработка события "щелчок на кнопке"
            // Если проверка текстовых полей показала, что они 
            // заполнены верно:
            if (Page.IsValid == true)
            {
                var Z = Convert.ToDouble(TextBox1.Text) +
                              Convert.ToDouble(TextBox2.Text);
                Label1.Text = String.Format("Сумма = {0}", Z);
            }
        }
    }
}