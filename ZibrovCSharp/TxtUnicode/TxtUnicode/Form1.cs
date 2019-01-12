// Программа для чтения/записи текстового файла в кодировке Unicode
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace TxtUnicode
{
    public partial class Form1 : Form
    {
        // Объявляем ИмяФайла вне всех подпрограмм, чтобы эта переменная
        // была "видна" во всех процедурах обработок событий:
        String ИмяФайла;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Установка начальных значений:                     
            textBox1.Multiline = true; textBox1.Clear();
            textBox1.Size = new Size(268, 112);
            button1.Text = "Открыть"; button1.TabIndex = 0;
            button2.Text = "Сохранить";
            this.Text = "Здесь кодировка Unicode";
            ИмяФайла = @"D:\Text1.txt";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Щелчок на кнопке Открыть.
            // Русские буквы будут корректно читаться,
            // если открыть файл в кодировке UNICODE:
            try
            {   // Создание объекта StreamReader для чтения из файла:
                var Читатель = new System.IO.StreamReader(ИмяФайла);
                // Непосредственное чтение всего файла в текстовое поле:
                textBox1.Text = Читатель.ReadToEnd();
                Читатель.Close(); // закрытие файла
                // Читать текстовый файл в кодировке UNICODE в массив
                // строк можно также таким образом (без Open и Close):
                // var МассивСтрок = System.IO.File.
                //                  ReadAllLines(@"D:\Text1.txt");
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                // Обработка исключительной ситуации:
                MessageBox.Show(Ситуация.Message + "\n" + 
                                "Нет такого файла", "Ошибка", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            {
                // Отчет о других ошибках:
                MessageBox.Show(Ситуация.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Щелчок на кнопке Сохранить:
            try
            {   // Создание объекта StreamWriter для записи в файл:
                var Писатель = new System.IO.
                                            StreamWriter(ИмяФайла, false);
                Писатель.Write(textBox1.Text);
                Писатель.Close();
                // Сохранить текстовый файл можно также таким образом
                // (без Close), причем, если файл уже существует,
                // то он будет заменен:
                // System.IO.File.WriteAllText(
                //                          @"D:\tmp.tmp", textBox1.Text);
            }
            catch (Exception Ситуация)
            {
                // Отчет обо всех возможных ошибках:
                MessageBox.Show(Ситуация.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
