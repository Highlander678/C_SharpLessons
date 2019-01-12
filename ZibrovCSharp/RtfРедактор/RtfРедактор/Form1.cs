// Программа простейшего RTF-редактора
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace RtfРедактор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Простой RTF-редактор"; richTextBox1.Clear();
            openFileDialog1.FileName = @"D:\Text2.txt";
            saveFileDialog1.Filter = "Файлы RTF (*.RTF)|*.RTF";
            // Оба события щелчка указателем мыши на пунктах меню "Открыть
            // в формате RTF" и "Открыть в формате Win1251" будем
            // обрабатывать одной процедурой ОТКРЫТЬ:
            открытьВФорматеRTFToolStripMenuItem.Click += 
                                            new EventHandler(ОТКРЫТЬ);
            открытьВФорматеWin1251ToolStripMenuItem.Click += 
                                            new EventHandler(ОТКРЫТЬ);
        }
        void ОТКРЫТЬ(Object sender, EventArgs e)
        {
            // Процедура обработки событий открытия
            // файла в двух разных форматах.
            // Выясняем, в каком формате открыть файл:
            var t = (ToolStripMenuItem)sender;
            // Читаем надпись на пункте меню:
            var Формат = t.Text;
            try
            {   // Открыть в каком-либо формате:
                if (Формат == "Открыть в формате RTF")
                {
                    openFileDialog1.Filter =
                                       "Файлы RTF (*.RTF)|*.RTF";
                    openFileDialog1.ShowDialog();
                    if (openFileDialog1.FileName == null) return;
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                if (Формат == "Открыть в формате Win1251")
                {
                    openFileDialog1.Filter = 
                                    "Текстовые файлы (*.txt)|*.txt";
                    openFileDialog1.ShowDialog();
                    if (openFileDialog1.FileName == null) return;
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                                          RichTextBoxStreamType.PlainText);
                }
                richTextBox1.Modified = false;
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                MessageBox.Show(Ситуация.Message +
                    "\nНет такого файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            {   // Отчет о других ошибках
                MessageBox.Show(Ситуация.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void сохранитьВФорматеRTFToolStripMenuItem_Click(
                                                object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) Запись();
        }
        void Запись()
        {
            try
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                richTextBox1.Modified = false;
            }
            catch (Exception Ситуация)
            {
                // Отчет обо всех возможных ошибках:
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
            if (richTextBox1.Modified == false) return;
            // Если текст модифицирован, то выясняем, записывать ли файл?
            var MBox = MessageBox.Show(
                "Текст был изменен.\n" + "Сохранить изменения?",
                "Простой редактор", MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Exclamation);
            // YES — диалог:  NO — выход:  CANCEL - редактирование
            if (MBox == DialogResult.No) return;
            if (MBox == DialogResult.Cancel) e.Cancel = true;
            if (MBox == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                { Запись(); return; }
                else e.Cancel = true; // Передумал выходить из ПГМ
            } // Конец условия DialogResult.Yes
        }
    }
}
