// Программа, используя класс WebClient, читает веб-страницу Центрального
// банка РФ www.cbr.ru, ищет в ее гипертекстовой разметке курс доллара
// США и копирует его в текстовую метку Label. Кроме того, элемент
// управления графическое поле PictureBox отображает логотип банка,
// используя URL-адрес этого изображения
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace РазборВебСтраницы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Сведения от банка России";
            // Создаем объект для чтения веб-страницы:
            var КЛИЕНТ = new System.Net.WebClient();
            // Если веб-страница записана в кодировке Win1251, то чтобы
            // русские буквы читались корректно, следует объявлявить
            // объект Кодировка:
            // var Кодировка = System.Text.Encoding.GetEncoding(1251);
            System.IO.Stream ПОТОК;
            String СТРОКА;
            try
            {
                // Попытка открытия веб-ресурса:
                ПОТОК = КЛИЕНТ.OpenRead("http://www.cbr.ru/");
            }
            catch (Exception Ситуация)
            {
                СТРОКА = String.Format(
                    "www.cbr.ru" + "\n{0}", Ситуация.Message);
                label1.Text = СТРОКА;
                return;
            }
            // Чтение HTML-разметки веб-страницы в кодировке
            // Unicode (по умолчанию):
            var Читатель = new System.IO.StreamReader(ПОТОК); //, Кодировка);
            // Копируем HTML-разметку в строковую переменную:
            СТРОКА = Читатель.ReadToEnd();
            // Ищем в HTML-разметке страницы курс доллара США:
            var i = СТРОКА.IndexOf("Доллар США");
            СТРОКА = СТРОКА.Substring(i, 300);
            i = СТРОКА.IndexOf("nowrap");
            СТРОКА = СТРОКА.Substring(i + 7);
            i = СТРОКА.IndexOf("&nbsp");
            СТРОКА = СТРОКА.Remove(i);
            // Вставляем текущую дату:
            СТРОКА = String.Format(
                            "Курс доллара США на {0:D}:\n" +
                            "{1} руб за $1 USD", DateTime.Now, СТРОКА);
            ПОТОК.Close();
            // Копируем в текстовую метку найденный курс доллара:
            label1.Text = СТРОКА;
            // В графическом поле отображаем логотип Центрального банка:
            pictureBox1.ImageLocation =
                        "http://www.cbr.ru/images/main_logo.gif";
        }
    }
}
