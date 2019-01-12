// Программа вывода таблицы средствами MS Word: запускается
// программа, пользователь наблюдает, как запускается редактор
// MS Word и автоматически происходит построение таблицы
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ТаблицаWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // В меню Project укажем команду Add Reference и в узле 
            // Assemblies выберем пункт Extensions, в появившемся списке
            // отметим ссылку Microsoft.Office.Interop.Word.
            button1.Text = "Пуск"; base.Text = "Поcтроение таблицы";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Инициализируем два строковых массива:
            String[] Имена = {
                         "Андрей - раб", "Света-X", "ЖЭК",
                         "Справка по тел", "Александр Степанович",
                         "Мама - дом", "Карапузова Таня",
                         "Погода сегодня", "Театр Браво"};
            String[] Тлф = {
                       "274-88-17", "+38(067)7030356",
                       "22-345-72", "009", "223-67-67 доп 32-67",
                       "570-38-76", "201-72-23-прямой моб",
                       "001", "216-40-22"};
            // Создаем новый экземпляр класса Word.Application:
            var Ворд1 = new Microsoft.Office.Interop.
                                      Word.Application();
            Ворд1.Visible = true;
            // Открываем новый документ MS Word:
            var Документ = Ворд1.Documents.Add();
            // Вводим текст в документ MS WORD с текущей позиции:
            Ворд1.Selection.TypeText("ТАБЛИЦА ТЕЛЕФОНОВ");
            // Параметр, указывающий покаывать ли границы ячеек:
            var t1 = Microsoft.Office.Interop.
                         Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            // Параметр, указывающий будет ли приложение Word автоматически
            // изменять размер ячеек в таблице для подгонки содержимого:
            var t2 = Microsoft.Office.Interop.
                         Word.WdAutoFitBehavior.wdAutoFitContent;
            // Создаем таблицу из 9 строк и 2 столбцов:
            Ворд1.ActiveDocument.Tables.Add(Ворд1.Selection.Range,
                                                          9, 2, t1, t2);
            // Заполнять ячейки таблицы можно так:
            for (int i = 1; i <= 9; i++)
            {
                Ворд1.ActiveDocument.Tables[1].Cell(i, 1).
                                     Range.InsertAfter(Имена[i - 1]);
                Ворд1.ActiveDocument.Tables[1].Cell(i, 2).
                                       Range.InsertAfter(Тлф[i - 1]);
                // Программируя на VB мы написали бы:
                // Ворд1.ActiveDocument.Tables(1).Cell(i, 2).
                //                     Range.InsertAfter(Тлф(i - 1))
            }
            // Назначаем единицы измерения в документе приложения MS Word:
            var t3 = Microsoft.Office.Interop.Word.WdUnits.wdLine;
            // Параметр, указывающий на девятую строку в документе MS Word:
            var Строка9 = 9;
            // Перевести текущую позицию (Selection) за пределы таблицы,
            // (в девятую строку), чтобы здесь вывести какой-либо текст:
            Ворд1.Selection.MoveDown(t3, Строка9, null);
            // И здесь печатаем следующий текст:
            Ворд1.Selection.TypeText("Какой-либо текст после таблицы");
            // Сохранять документ нет смысла, но это решит пользователь:
            // var ИмяФайла = @"D:\a.doc";
            // Ворд1.ActiveDocument.SaveAs(ИмяФайла);
        }
    }
}
