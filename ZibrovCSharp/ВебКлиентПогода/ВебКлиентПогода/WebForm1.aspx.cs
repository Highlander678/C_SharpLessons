// Веб-приложение, потребляющее сервис удаленной веб-службы прогноза
// погоды. Приложение в текстовом поле TextBox демонстрирует XML-строку
// с параметрами погоды для города, указанного во входных параметрах
// при обращении к веб-службе. Также выводит в текстовую метку значение
// температуры в этом городе
using System;
using System.Web.UI.WebControls;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВебКлиентПогода
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Text = "Выяснить погоду";
            Label1.Text = String.Empty;
            TextBox1.TextMode = TextBoxMode.MultiLine;
            Button1.Focus();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Создаем клиентское приложение веб-службы:
            // http://www.webservicex.net/globalweather.asmx
            // Эта веб-служба часто бывает перегужена и поэтому может
            // выдать сообщение: "Server is too busy"
            // Создание экземпляра прокси-класса:
            var ПОГОДА = new net.webservicex.www.GlobalWeather();
            // Эти три строчки - для отладки, чтобы лишний раз
            // не "дергать" сервер:
            // var Reader = new System.IO.StreamReader(@"D:\Погода.xml");
            // var Строка_XML = Reader.ReadToEnd();
            // Reader.Close();
            // Функция GetWeather запрашивает строковые параметры с названием
            // города и страны и возвращает строку с XML-документом:
            var Строка_XML = ПОГОДА.GetWeather("Moscow", "Russia");
            // Можно тут же сохранить XML-строку в файл для дальнейшей
            // отладки программы:
            // System.IO.File.WriteAllText(@"D:\Погода.xml", Строка_XML);
            // Какая погода в Киеве:
            // var Строка_XML = ПОГОДА.GetWeather("Kyiv", "Ukraine");
            TextBox1.Text = Строка_XML;
            var Документ = new System.Xml.XmlDocument();
            // Загрузка строки XML в XML-документ
            Документ.LoadXml(Строка_XML);
            var Читатель = new System.Xml.XmlNodeReader(Документ);
            var Имя = String.Empty;
            var Значение = String.Empty;
            // Цикл по узлам XML-документа:
            while (Читатель.Read() == true)
            {
                // Читаем последовательно каждый узел, выясняя тип узла:
                if (Читатель.NodeType == System.Xml.
                          XmlNodeType.Element) Имя = Читатель.Name;
                // Каждый раз запоминаем имя узла
                if (Читатель.NodeType != System.Xml.
                          XmlNodeType.Text) continue;
                if (Имя == "Temperature")
                {
                    Значение = Читатель.Value;
                    break;
                }
            }
            // Выход из цикла, когда прочитали данные узла "Temperature"
            Label1.Text = "Температура воздуха в Москве: " + Значение;
        }
    }
}
