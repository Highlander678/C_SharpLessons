// Простой текстовый редактор
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ТекстовыйРедактор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true; textBox1.Clear();
            textBox1.Size = new Size(268, 160);
            this.Text = "Простой текстовый редактор";
            openFileDialog1.FileName = @"D:\Text2.txt";
            openFileDialog1.Filter =
                "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter =
                "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
        }
        private void открытьToolStripMenuItem_Click(
                                           object sender, EventArgs e)
        {
            // Вывести диалог открытия фала
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            // Чтение текстового файла:
            try
            {
                // Создание экземпляра StreamReader для чтения из файла
                var Читатель = new System.IO.StreamReader(
                                     openFileDialog1.FileName,
                                       Encoding.GetEncoding(1251));
                // - здесь заказ кодовой страницы Win1251 для русских букв
                textBox1.Text = Читатель.ReadToEnd();
                Читатель.Close();
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                MessageBox.Show(Ситуация.Message + "\nНет такого файла",
                    "Ошибка", MessageBoxButtons.OK,
                              MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            {   // Отчет о других ошибках
                MessageBox.Show(Ситуация.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void сохранитьКакToolStripMenuItem_Click(
                                                object sender, EventArgs e)
        {
            // Пункт меню Сохранить как
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() ==
                                           DialogResult.OK) Запись();
        }
        private void Запись()
        {
            try
            {
                // Создание экземпляра StreamWriter для записи в файл:
                var Писатель = new System.IO.StreamWriter(
                                  saveFileDialog1.FileName, false,
                                  System.Text.Encoding.GetEncoding(1251));
                // - здесь заказ кодовой страницы Win1251 для русских букв
                Писатель.Write(textBox1.Text);
                Писатель.Close(); textBox1.Modified = false;
            }
            catch (Exception Ситуация)
            {
                // Отчет обо всех возможных ошибках
                MessageBox.Show(Ситуация.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void выходToolStripMenuItem_Click(
                                           object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(
                                object sender, FormClosingEventArgs e)
        {
            // Обработка момента закрытия формы:
            if (textBox1.Modified == false) return;
            // Если текст модифицирован, то спросить, записывать ли файл?
            var MBox = MessageBox.Show(
                "Текст был изменен." + "Сохранить изменения?",
                "Простой редактор", MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Exclamation);
            // YES — диалог:  NO — выход:  CANCEL - редактировать
            if (MBox == DialogResult.No) return;
            if (MBox == DialogResult.Cancel) e.Cancel = true;
            if (MBox == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                { Запись(); return; }
                else e.Cancel = true; // Передумал выходить из ПГМ
            } // DialogResult.Yes
        }
    }
}
