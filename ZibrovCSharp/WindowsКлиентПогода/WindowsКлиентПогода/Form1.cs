// Windows-приложение, потребляющее сервис удаленной веб-службы прогноза
// погоды. Приложение в текстовом поле TextBox демонстрирует XML-строку
// с параметрами погоды для города, указанного во входных параметрах при
// обращении к веб-службе. Также выводит в текстовую метку значение
// температуры в этом городе
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Добавляем внешнюю ссылку на веб-службу таким образом:
// Проект - Добавить ссылку на службу - Дополнительно -
// Добавить веб-ссылку http://www.webservicex.net/globalweather.asmx
namespace WindowsКлиентПогода
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Выяснить погоду";
            label1.Text = String.Empty;
            textBox1.Multiline = true;
            button1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра прокси-класса:
            var ПОГОДА = new net.webservicex.www.GlobalWeather();
            // Эти три строчки - для отладки, чтобы лишний раз не "дергать"
            // сервер:
            // var Reader = new System.IO.StreamReader(@"D:\Погода.xml");
            // var Строка_XML = Reader.ReadToEnd();
            // Reader.Close();
            // Функция GetWeather запрашивает строковые параметры с названием
            // города и страны и возвращает строку с XML-документом:
            var Строка_XML = ПОГОДА.GetWeather("Moscow", "Russia");
            // Какая погода в Киеве:
            // var Строка_XML = ПОГОДА.GetWeather("Kyiv", "Ukraine")
            textBox1.Text = Строка_XML;
            // Здесь считывание значения узла из XML-строки выполено более
            // эффективно:
            var XML_элемент = System.Xml.Linq.XElement.Parse(Строка_XML);
            var Значение = XML_элемент.Element("Temperature").Value;
            label1.Text = "Температура воздуха в Москве: " + Значение;
        }
    }
}
