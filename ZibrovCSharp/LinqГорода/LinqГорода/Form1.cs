// В данной программе экранная форма содержит элемент управления для
// отображения и редактирования табличных данных DataGridView, две
// командные кнопки и текстовое поле. При старте программы, если есть
// соответствующий файл XML, то программа отображает в DataGridView
// таблицу городов - название города и численность населения. При 
// щелчке на кнопке "Сохранить" все изменения в таблице записываются
// в XML-файл. При щелчке на второй кнопке "Найти" выполняется
// LINQ-запрос к набору данных DataSet на поиск городов-миллионеров в
// искомой таблице. Результат запроса выводится в текстовое поле
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace LinqГорода
{
    public partial class Form1 : Form
    {       
        // Создание объекта таблица данных
        DataTable Таблица = new DataTable();
        // Создание объекта набор данных
        DataSet НаборДанных = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "LINQ-запрос к набору данных DataSet";
            button1.Text = "Сохранить"; button2.Text = "Найти";
            textBox1.Multiline = true;
            if (System.IO.File.Exists(@"D:\Города.xml") == false)
            {
                // Если XML-файла НЕТ:
                // Заполнение "шапки" таблицы
                Таблица.Columns.Add("Город");
                Таблица.Columns.Add("Население");
                // Добавить объект Таблица в DataSet
                НаборДанных.Tables.Add(Таблица);
                dataGridView1.DataSource = Таблица;
            }
            else
            { // Если XML-файл ЕCТЬ:
                НаборДанных.ReadXml(@"D:\Города.xml");
                // Содержимое DataSet в виде строки XML для отладки:
                // var СтрокаXML = НаборДанных.GetXml()
                Таблица = НаборДанных.Tables["Города"];
                dataGridView1.DataMember = "Города";
                dataGridView1.DataSource = НаборДанных;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Щелчок мышью на кнопке "Сохранить" - сохранить
            // файл Города.xml:
            Таблица.TableName = "Города";
            НаборДанных.WriteXml(@"D:\Города.xml");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Щелчок мышью на кнопке "Поиск" - запрос городов-миллионеров:
            textBox1.Clear(); // - очистка текстового поля 
            // Linq-запрос:
            // Поскольку к таблице класса DataTable невозможно задавать
            // Linq-запросы, преобразуем ее к коллекции строк в таблице:
            var ГородаМлн =
                from Строка in Таблица.AsEnumerable()
                where Convert.ToInt32(
                Строка.Field<String>("Население")) >= 1000000
                select new
                {
                    A = Строка.Field<String>("Город"),
                    B = Строка.Field<String>("Население")
                };
            // select задает поля запроса, здесь заданы два поля.
            // ~ ~ ~ ~ ~ ~ ~ ~ 
            // Вывод результата запроса в текстовое поле:
            textBox1.Text = "Города-миллионеры: " + "\r\n";
            foreach (var Строка in ГородаМлн)
                textBox1.Text +=
                         Строка.A + " - " + Строка.B + "\r\n";
        }
    }
}
