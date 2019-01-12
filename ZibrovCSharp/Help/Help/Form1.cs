// В программе предусмотрена экранная форма, которая в заголовке имеет
// только кнопку Справка (в виде вопросительного знака) и кнопку
// Закрыть. Здесь реализована контекстная помощь, когда после щелчка
// мыши на кнопке Справка можно получить контекстную всплывающую
// подсказку по тому или иному элементу управления, находящемуся в форме
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Help
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false; // - отмена кнопки Развернуть
            MinimizeBox = false; // - отмена кнопки Свернуть
            // Чтобы стиль формы содержал кнопку помощи,
            // т. е. вопросительный знак
            this.HelpButton = true;
            this.Text = "Демонстрация помощи";
            // Me.Font = New Font("Courier New", 10.0F);
            button1.Text = "Следующая"; button2.Text = "Предыдущая";
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            label1.Text = "Номер п/п"; label2.Text = "ФИО";
            label3.Text = "Номер телефона";
            var Хелп = new HelpProvider();
            Хелп.SetHelpString(this.textBox1,
                "Enter the item number in this text box");
            // "Здесь отображаются номера записи по порядку")
            Хелп.SetHelpString(this.textBox2,
                "Поле для редактирования имени абонента");
            Хелп.SetHelpString(textBox3,
                "Поле для ввода и отображения номера телефона");
            Хелп.SetHelpString(button1,
                "Кнопка для перехода на следующую запись");
            Хелп.SetHelpString(button2,
                "Кнопка для перехода на предыдущую запись");
            // Назначаем, какой help-файл будет вызываться
            // при нажатии клавиши <F1>
            Хелп.HelpNamespace = @"C:\Windows\System32\appverif.chm";
            // "mspaint.chm"
        }
    }
}
