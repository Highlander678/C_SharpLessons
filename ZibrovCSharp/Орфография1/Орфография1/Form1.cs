// Программа позволяет пользователю ввести какие-либо слова, предложения
// в текстовое поле и после нажатия соответствующей кнопки проверить
// орфографию введенного текста. Для непосредственной проверки орфографии
// воспользуемся функцией CheckSpelling объектной библиотеки MS Word
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Орфография1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // В данный проект следует добавить ссылку
            // Microsoft.Office.Interop.Word
            textBox1.Clear(); button1.Text = "Проверка орфографии";
            textBox1.TabIndex = 0; button1.TabIndex = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр класса Word.Application:
            var Ворд1 = new Microsoft.Office.
                                        Interop.Word.Application();
            // Ворд1.Visible = false;
            // Открываем новый документ MS Word:
            var Документ = Ворд1.Documents.Add();
            // Вводим в документ MS Word текст из текстового поля:
            Документ.Words.First.InsertBefore(
                                           textBox1.Text);
            // Непосредственная проверка орфографии:
            Документ.CheckSpelling();
            // Получаем исправленный текст:
            var ИсправленныйТекст = Документ.Content.Text;
            // Возвращаем в текстовое поле исправленный текст:
            textBox1.Text = ИсправленныйТекст;
            Ворд1.Documents.Close(Microsoft.Office.Interop.Word.
                                  WdSaveOptions.wdDoNotSaveChanges);
            // Закрыть документ Word без сохранения:
            Ворд1.Quit();
            Ворд1 = null;
        }
    }
}
