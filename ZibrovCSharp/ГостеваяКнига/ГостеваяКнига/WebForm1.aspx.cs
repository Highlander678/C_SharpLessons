// Данная веб-страница приглашает посетителя оставить какие-либо записи,
// которые могут прочитать другие посетители страницы. Записи сохраняются
// в текстовом файле kniga.txt. Записи отображаются на веб-странице с
// помощью элемента сетка данных GridView
// ~ ~ ~ ~ ~ ~ ~ ~ 
using System;
using System.Web.UI.WebControls;
// Добавляем эти две директивы для сокращения программного кода:
using System.Data;
using System.IO;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ГостеваяКнига
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataTable Таблица = new DataTable();
        StreamReader Читатель;
        StreamWriter Писатель;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "ВЫ МОЖЕТЕ НАПИСАТЬ КАКОЕ-НИБУДЬ " +
                                    "СООБЩЕНИЕ В НАШЕЙ ГОСТЕВОЙ КНИГЕ";
            Label2.Text = "Ваше имя:";
            Label3.Text = "Ваш E-mail:";
            Label4.Text = "Ваше сообщение:";
            Button1.Text = "Добавить сообщение";
            // Разрешаем многострочие:
            TextBox3.TextMode = TextBoxMode.MultiLine;
            // Контролируем обязательность заполнения всех полей:
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

            Таблица.Columns.Add("Дата"); Таблица.Columns.Add("Имя");
            Таблица.Columns.Add("E-mail"); Таблица.Columns.Add("Сообщение");
            GridView1.BorderWidth = Unit.Pixel(2);
            GridView1.BorderColor = System.Drawing.Color.Gray;
            // Расстояние между содержимым ячейки и ее границей:
            GridView1.CellPadding = 3;
            GridView1.Caption = "Записи гостевой книги";
            GridView1.CaptionAlign = TableCaptionAlign.Right;
            ЗаполнитьGridView();
        }
        public void ЗаполнитьGridView()
        {
            // Эта процедура читает файл kniga.txt (если его нет, то
            // создает), разбивает каждую строку файла на четыре части
            // (дата, имя, e-mail и сообщение) и заполняет этими частями
            // строки таблицы. Затем записывает эту таблицу в сетку
            // данных GridView
            // ~ ~ ~ ~ ~ ~ ~ ~
            // Открываем файл kniga.txt, а если его нет, то его создаем:
            var Открыватель = new FileStream(Request.
                                    PhysicalApplicationPath + 
                                    "kniga.txt", FileMode.OpenOrCreate);
            // Открываем поток для чтения всех записей из файла
            Читатель = new StreamReader(Открыватель);
            // В качестве разделителя частей строки файла выбираем Tab, 
            // поскольку Tab невозможно ввести в текстовое поле. После
            // нажатия клавиши <Tab> происходит переход в следующее
            // текстовое поле
            Char[] Сепаратор = { '\t' }; // - массив из одного символа
            while (Читатель.EndOfStream == false)
            {
                var Одна_строка = Читатель.ReadLine();
                // Функция Split делит строку на четыре части и присваивает
                // каждую часть элементам массива
                var Массив_частей_строки = Одна_строка.Split(Сепаратор);
                // Загружаем, т. е. заполняем одну строку таблицы
                Таблица.LoadDataRow(Массив_частей_строки, true);
            }
            GridView1.DataSource = Таблица;
            // Обновление сетки данных:
            GridView1.DataBind();
            Таблица.Clear();
            Читатель.Close(); Открыватель.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Щелчок на кнопке "Добавить"
            // Если проверка текстовых полей показала, что они заполнены
            // верно,
            if (Page.IsValid == false) return;
            // то открываем поток для добавления данных в конец файла:
            Писатель = new StreamWriter(Request.
                           PhysicalApplicationPath + "kniga.txt", true);
            // true означает разрешить добавление строк в файл.
            // Записываем в файл новое сообщение, между полями - символ
            // табуляции:
            Писатель.WriteLine(
                "{0:D}" + " \t" + "{1}" + " \t" + "{2}" + " \t" + "{3}",
                DateTime.Now, TextBox1.Text, TextBox2.Text, TextBox3.Text);
            // Очищаем поля и закрываем поток
            TextBox1.Text = String.Empty;
            TextBox2.Text = String.Empty;
            TextBox3.Text = String.Empty;
            Писатель.Close();
            ЗаполнитьGridView();
        }
    }
}
