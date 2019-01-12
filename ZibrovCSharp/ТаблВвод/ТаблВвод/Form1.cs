// Программа предлагает пользователю заполнить таблицу телефонов его
// знакомых, сотрудников, родственников, любимых и т. д. После щелчка
// на кнопке Запись данная таблица записывается на диск в файл в формате
// XML. Для упрощения текста программы предусмотрена запись в один и тот
// же файл D:\tabl.xml. При последующих запусках данной программы таблица
// будет считываться из этого файла, и пользователь может продолжать
// редактирование таблицы
using System;
using System.Data;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ТаблВвод
{
    public partial class Form1 : Form
    {
        DataTable Таблица;  // Объявление объекта "таблица данных"
        DataSet НаборДанных;  // Объявление объекта "набор данных"
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Почти табличный редактор";
            button1.Text = "Запись";
            Таблица = new DataTable();
            НаборДанных = new DataSet();
            if (System.IO.File.Exists(@"D:\tabl.xml") == true)
            {
                // Если XML-файл ЕCТЬ:
                НаборДанных.ReadXml(@"D:\tabl.xml");
                // Содержимое DataSet в виде строки XML для отладки:
                var СтрокаXML = НаборДанных.GetXml();
                dataGridView1.DataMember = "Название таблицы";
                dataGridView1.DataSource = НаборДанных;
            }
            else
            {
                // Если XML-файла НЕТ:
                dataGridView1.DataSource = Таблица;
                // Заполнение "шапки" таблицы
                Таблица.Columns.Add("ИМЕНА");
                Таблица.Columns.Add("НОМЕРА ТЕЛЕФОНОВ");
                // Добавить объект Таблица в DataSet
                НаборДанных.Tables.Add(Таблица);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Сохранить файл tabl.xml:
            Таблица.TableName = "Название таблицы";
            НаборДанных.WriteXml(@"D:\tabl.xml");
        }
    }
}
