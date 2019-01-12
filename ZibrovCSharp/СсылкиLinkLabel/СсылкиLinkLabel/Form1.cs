// Программа обеспечивает ссылку для посещения почтового сервера
// www.mail.ru, ссылку для просмотра папки C:\Windows\ и ссылку для запуска
// текстового редактора Блокнот с помощью элемента управления LinkLabel
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace СсылкиLinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Обработка процедуры загрузки формы:
            this.Text = "Щелкните на ссылке:";
            linkLabel1.Text = "www.mail.ru";
            linkLabel2.Text = @"Папка C:\Windows\";
            linkLabel3.Text = "Вызвать \"Блокнот\"";
            this.Font = new Font("Consolas", 12.0F);
            linkLabel1.LinkVisited = true;
            linkLabel2.LinkVisited = true;
            linkLabel3.LinkVisited = true;
            // Подписка на события: все три события обрабатываются
            // одной процедурой:
            linkLabel1.LinkClicked += new System.Windows.Forms.
                       LinkLabelLinkClickedEventHandler(this.ССЫЛКА);
            linkLabel2.LinkClicked += new System.Windows.Forms.
                       LinkLabelLinkClickedEventHandler(this.ССЫЛКА);
            linkLabel3.LinkClicked += new System.Windows.Forms.
                       LinkLabelLinkClickedEventHandler(this.ССЫЛКА);
        }
        private void ССЫЛКА(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Обработка щелчка на любой из ссылок:
            var ссылка = (LinkLabel)sender;
            // Выбор ссылки:
            switch (ссылка.Name) 
            {
                case "linkLabel1": // инрернет-ресурс
                     System.Diagnostics.Process.Start(
                                  "IExplore.exe", "http://www.mail.ru"); 
                     break;
                case "linkLabel2": // папка файловой системы
                     System.Diagnostics.Process.Start(
                                   "C:\\Windows\\"); 
                     break;
                case "linkLabel3": // редактор Блокнот
                     System.Diagnostics.Process.Start(
                                   "Notepad", "text.txt");
                     break;
            }
        }
    }
}
