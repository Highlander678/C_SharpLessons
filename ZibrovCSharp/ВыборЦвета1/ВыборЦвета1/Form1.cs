// Программа меняет цвет фона формы BackColor, перебирая константы
// цвета, предусмотренные в Visual Studio 11, с помощью элемента
// управления ListBox
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВыборЦвета1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Получаем массив строк имен цветов из перечисления KnownColor
            var ВсеЦвета = Enum.GetNames(typeof(KnownColor));
            // В VB: Dim ВсеЦвета = [Enum].GetNames(GetType(KnownColor))
            listBox1.Items.Clear();
            // В список элементов добавляем имена всех цветов:
            listBox1.Items.AddRange(ВсеЦвета);
            // Сортировать записи в алфавитном порядке
            listBox1.Sorted = true;
        }
        private void listBox1_SelectedIndexChanged(
                                               object sender, EventArgs e)
        {
        // Цвет Transparent является "прозрачным":
        if (listBox1.Text == "Transparent")return;
        this.BackColor = Color.FromName(listBox1.Text);
        this.Text = "Цвет: " + listBox1.Text;
        }
    }
}
