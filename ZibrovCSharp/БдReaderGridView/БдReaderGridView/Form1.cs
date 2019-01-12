// Программа читает все записи из таблицы базы данных с помощью объектов
// Command, DataReader на элемент управления DataGridView (сетка данных)
using System;
using System.Data;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace БдReaderGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаем объект Connection и передаем ему строку подключения:
            var Подключение = new System.Data.OleDb.OleDbConnection(
                       "Data Source=\"D:\\vic.mdb\";User " +
                       "ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
            Подключение.Open();
            // Создаем объект Command, передавая ему SQL-команду
            var Команда = new System.Data.OleDb.
                OleDbCommand("Select * From [БД телефонов]", Подключение);
            // Выполняем SQL-команду
            var Читатель = Команда.ExecuteReader();
            // (CommandBehavior.CloseConnection)
            var Таблица = new DataTable();
            // Заполнение "шапки" таблицы
            Таблица.Columns.Add(Читатель.GetName(0));
            Таблица.Columns.Add(Читатель.GetName(1));
            Таблица.Columns.Add(Читатель.GetName(2));
            while (Читатель.Read() == true)
                // Заполнение клеток (ячеек) таблицы
                Таблица.Rows.Add(Читатель.GetValue(0),
                                 Читатель.GetValue(1), 
                                 Читатель.GetValue(2));
            // Здесь три поля: 0, 1 и 2
            Читатель.Close(); 
            Подключение.Close();
            dataGridView1.DataSource = Таблица;
        }
    }
}
