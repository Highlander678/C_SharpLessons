// Эта программа использует элемент управления WebBrowser 
// для отображения веб-страницы и ее HTML-кода
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Split
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Веб-страница и ее HTML-код";
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox2.Multiline = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            button1.Text = "ПУСК";
            webBrowser1.Dock = DockStyle.None;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Обработка события "щелчок на кнопке ПУСК":
            webBrowser1.Navigate(textBox1.Text);
            // webBrowser1.Navigate("www.latino.ho.ua");
            // webBrowser1.GoBack();    // Назад
            // webBrowser1.GoForward(); // Вперед
            // webBrowser1.GoHome();    // На домашнюю страницу
        }
        private void webBrowser1_DocumentCompleted(object sender,
                                  WebBrowserDocumentCompletedEventArgs e)
        {
            // Обработка события "Веб-документ полностью загружен"
            // Получаем HTML-код из элемента WebBrowser:
            textBox2.Text = webBrowser1.Document.Body.InnerHtml;
        }
    }
}
