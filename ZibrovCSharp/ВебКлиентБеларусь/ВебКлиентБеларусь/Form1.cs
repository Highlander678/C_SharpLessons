// Клиентское Windows-приложение, потребляющее сервис веб-службы
// Национального банка Республики Беларусь для получения ежедневных
// курсов валют. На выходе приложения получаем таблицу курсов валют
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВебКлиентБеларусь
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Курсы валют";
        }
        private void button1_Click(object sender, EventArgs e)
        {        // Создаем клиентское приложение веб-службы:
            // http://www.nbrb.by/Services/ExRates.asmx
            // Создаем экземпляр удаленного класса:
            var Валюта = new by.nbrb.www.ExRates();
            // А этот сайт автор нашел на сайте:
            // http://ivbeg.bestpersons.ru/feed/post3279396/
            // Здесь есть ссылки на другие русскоязычные сервисы
            var Дата = DateTime.Now;
            // На вход метода ExRatesDaily подаем текущую дату:
            var НаборДанных = Валюта.ExRatesDaily(Дата);
            // Метод ExRatesDaily возвращает курсы валют в виде DataSet
            // Содержимое DataSet в виде строки XML для отладки:
            var СтрокаXML = НаборДанных.GetXml();
            // Указываем источник данных для сетки данных:
            dataGridView1.DataSource = НаборДанных;
            // Указываем имя таблицы в наборе данных:
            dataGridView1.DataMember = "DailyExRatesOnDate";
        }
    }
}
