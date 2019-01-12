// Программа меняет цвет фона формы
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВыборЦвета2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Получаем массив строк имен цветов из перечисления KnownColor.
            // Enum.GetNames возвращает массив имен констант
            // в указанном перечислении.
            // Удаление всех элементов из коллекции:
            listBox1.Items.Clear();
            // Добавляем имена всех цветов в список listBox1:
            foreach (String Цвет in Enum.GetNames(typeof(KnownColor)))
                if (Цвет != "Transparent") listBox1.Items.Add(Цвет);
            // Цвет Transparent является "прозрачным"
            // Сортируем все цвета в списке в алфавитном порядке:
            listBox1.Sorted = true;
        }
        private void listBox1_SelectedIndexChanged(
                                           object sender, EventArgs e)
        {
            // Обработка события изменения выбранного
            // индекса в списке listBox1:
            this.BackColor = Color.FromName(listBox1.Text);
            // Надпись в строке заголовка формы:
            this.Text = "Цвет: " + listBox1.Text;
        }
    }
}
