// Чтение/запись текстового файла веб-приложением. Веб-приложение читает
// текстовый файл в текстовое поле, а пользователь имеет возможность
// редактировать текст и сохранять его в том же файле
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace RW_txt
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String ИмяФайла; // - имя файла используется в обеих процедурах
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Здесь кодировка Win1251";
            Button1.Width = 95; Button2.Width = 95;
            Button1.Text = "Читать"; Button2.Text = "Сохранить";
            Button1.Focus();
            // Разрешаем многострочие: 
            TextBox1.TextMode = TextBoxMode.MultiLine;
            ИмяФайла = Request.PhysicalApplicationPath + "txt.txt";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Чтение файла:
            try
            {
                // Создаем экземпляр StreamReader для чтения из файла
                var ЧИТАТЕЛЬ = new System.IO.StreamReader(ИмяФайла,
                                   System.Text.Encoding.GetEncoding(1251));
                TextBox1.Text = ЧИТАТЕЛЬ.ReadToEnd();
                ЧИТАТЕЛЬ.Close();
            }
            catch (System.IO.FileNotFoundException Ситуация1)
            {
                Response.Write("Нет такого файла <br />" + 
                                           Ситуация1.Message);
            }
            catch (Exception Ситуация2)
            { // Отчет о других ошибках
                Response.Write("Ошибка чтения файла  <br />" +
                                           Ситуация2.Message + " <br />");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            // Сохранение файла:
            try
            {
                // Создание экземпляра StreamWriter для записи в файл
                var ПИСАТЕЛЬ = new System.IO.StreamWriter(ИмяФайла, false,
                                   System.Text.Encoding.GetEncoding(1251));
                ПИСАТЕЛЬ.Write(TextBox1.Text);
                ПИСАТЕЛЬ.Close();
            }
            catch (Exception Ситуация)
            {
                // Отчет обо всех возможных ошибках
                Response.Write("Ошибка записи файла <br />" +
                                           Ситуация.Message + " <br />");
            }
        }
    }
}
