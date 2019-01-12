// Программа читает из БД таблицу в сетку данных DataGridView 
// с использованием объектов класса Command, Adapter и DataSet
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace БдАдаптерGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Чтение таблицы из БД:";
            var Подключение = new 
                      System.Data.OleDb.OleDbConnection(
                     "Data Source=\"D:\\vic.mdb\";User " +
                     "ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
            Подключение.Open();
            var Команда = new System.Data.OleDb.OleDbCommand(
                     "Select * From [БД телефонов]", Подключение);
            // Выбираем из таблицы только те записи, поле ФИО которых
            // начинается на букву "М":
            // var Команда =
            //    new System.Data.OleDb.OleDbCommand("SELECT * FRO" +
            //    "M [БД телефонов] WHERE (фио LIKE 'м%')", Подключение);
            // Создаем объект класса Adapter и выполняем SQL-запрос
            var Адаптер = new System.Data.OleDb.OleDbDataAdapter(Команда);
            // Создаем объект класса DataSet
            var НаборДанных = new System.Data.DataSet();
            // Заполняем DataSet результатом SQL-запроса
            Адаптер.Fill(НаборДанных, "БД телефонов");
            // Содержимое DataSet в виде строки XML для отладки:
            var СтрокаXML = НаборДанных.GetXml();
            // Указываем источник данных для сетки данных:
            dataGridView1.DataSource = НаборДанных;
            // Указываем имя таблицы в наборе данных:
            dataGridView1.DataMember = "БД телефонов";
            Подключение.Close();
        }
    }
}
