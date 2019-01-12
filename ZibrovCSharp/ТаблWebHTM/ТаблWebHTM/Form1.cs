// В программе для отображения таблицы используется элемент управления
// WebBrowser. Таблица записана на языке HTML с помощью элементарных
// тегов <tr> (строка в таблице) и <td> (ячейка в таблице)
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ТаблWebHTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Никакие края (из четырех) не привязаны к экранной форме:
            webBrowser1.Dock = DockStyle.None;
            // или webBrowser1.Navigate(@"D:\table.htm");
            var СтрокаHTML = "Какой-либо текст до таблицы" +
                         "<table border> " +
                         "<caption>Таблица телефонов</caption> " +
                         "<tr><td>Андрей — раб<td>274-88-17 " +
                         "<tr><td>Света-X<td>+38(067)7030356 " +
                         "<tr><td>ЖЭК<td>22-345-72 " +
                         "<tr><td>Справка по тел<td>009 " +
                         "</table> " +
                         "Какой-либо текст после таблицы";
            webBrowser1.Navigate("about:" + СтрокаHTML);
        }
    }
}
