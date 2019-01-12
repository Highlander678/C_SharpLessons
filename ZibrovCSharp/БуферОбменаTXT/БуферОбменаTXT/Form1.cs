// Эта программа имеет возможность записи какого-либо текста в
// буфер обмена, а затем извлечения этого текста из буфера обмена
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace БуферОбменаTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Введите текст в верхнее поле";
            textBox1.Clear(); textBox2.Clear();
            textBox1.TabIndex = 0;
            button1.Text = "Записать в БО";
            button2.Text = "Извлечь из БО";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Записать выделенный в верхнем поле текст в БО
            if (textBox1.SelectedText != String.Empty)
            {
                Clipboard.SetDataObject(textBox1.SelectedText);
                textBox2.Text = String.Empty;
            }
            else textBox2.Text = "В верхнем поле текст не выделен";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Объявление объекта-получателя из БО
            var Получатель = Clipboard.GetDataObject();
            // Если данные в БО представлены в текстовом формате...
            if (Получатель.GetDataPresent(DataFormats.Text) == true)
                // то записать их в Text тоже в текстовом формате,
                textBox2.Text = Получатель.
                               GetData(DataFormats.Text).ToString();
            else // иначе
                textBox2.Text = "Запишите что-либо в буфер обмена";
        }
    }
}
