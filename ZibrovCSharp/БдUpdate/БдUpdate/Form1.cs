// Программа обновляет записи (Update) в таблице базы данных MS Access
using System;
using System.Data;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~ 
// А данную директиву добавим для краткости выражений:
using System.Data.OleDb;
namespace БдUpdate
{
    public partial class Form1 : Form
    {
        // ~ ~ ~ ~ ~ ~ ~ ~ 
        // Объявляем эти переменные вне всех процедур, чтобы
        // они были видны из любой из процедур:
        DataSet НаборДанных;
        OleDbDataAdapter Адаптер;
        OleDbConnection Подключение;
        OleDbCommand Команда;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            НаборДанных = new DataSet();
            Подключение = new OleDbConnection(
                "Data Source=\"D:\\vic.mdb\";User " +
                "ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
            Команда = new OleDbCommand();
            button1.Text = "Читать из БД"; button1.TabIndex = 0;
            button2.Text = "Сохранить в БД";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Читать из БД:
            if (Подключение.State ==
                            ConnectionState.Closed) Подключение.Open();
            Адаптер = new OleDbDataAdapter(
                            "Select * From [БД телефонов]", Подключение);
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
        private void button2_Click(object sender, EventArgs e)
        {
            // Сохранить в базе данных
            Команда.CommandText = "UPDATE [БД телефонов] SET [Но" +
                "мер телефона] = ?, ФИО = ?  WHERE ([Номер п/п] = ?)";
            // Имя, тип и длина параметра
            Команда.Parameters.Add("Номер телефона",
                       OleDbType.VarWChar, 50, "Номер телефона");
            Команда.Parameters.Add(
                           "ФИО", OleDbType.VarWChar, 50, "ФИО");
            Команда.Parameters.Add(
                        new OleDbParameter("Original_Номер_п_п",
                         OleDbType.Integer,
                         0, ParameterDirection.Input, false,
                         (Byte)0, (Byte)0, "Номер п/п",
                         System.Data.DataRowVersion.Original, null));
            Адаптер.UpdateCommand = Команда;
            Команда.Connection = Подключение;
            try
            {
                // Update возвращает количество измененных строк
                var kol = Адаптер.Update(НаборДанных, "БД телефонов");
                MessageBox.Show(
                          "Обновлено " + kol.ToString() + " записей");
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message, "Недоразумение");
            }
        }
    }
}
