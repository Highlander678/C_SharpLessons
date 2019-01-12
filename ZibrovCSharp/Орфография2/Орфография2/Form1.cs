// Программа позволяет пользователю проверить
// орфографию введенного текста
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Орфография2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear(); button1.Text = "Проверка орфографии";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var Ворд1 = new Microsoft.Office.Interop.Word.Application();
            Ворд1.Visible = false;
            // Открываем новый документ MS Word:
            Ворд1.Documents.Add();
            // Копируем содержимое текстового окна в документ
            Ворд1.Selection.Text = textBox1.Text;
            // Непосредственная проверка орфографии:
            Ворд1.ActiveDocument.CheckSpelling();
            // Копируем результат назад в текстовое поле
            textBox1.Text = Ворд1.Selection.Text;
            Ворд1.Documents.Close(false);
            // Закрыть документ Word без сохранения:
            Ворд1.Quit();
            Ворд1 = null;
        }
    }
}
