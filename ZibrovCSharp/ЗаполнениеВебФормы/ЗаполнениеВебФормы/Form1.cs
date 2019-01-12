// Программа загружает в элемент WebBrowser начальную страницу поисковой
// системы http://yahoo.com. Далее, используя указатель на неуправляемый
// интерфейс DomDocument (свойство объекта класса WebBrowser),
// приводим его к указателю IHTMLDocument2. В этом случае мы получаем
// доступ к формам и полям веб-страницы по их именам. Заполняем поле
// поиска ключевыми словами для нахождения соответствующих веб-страниц,
// а затем для отправки заполненной формы на сервер "программно" нажимаем
// кнопку Submit. В итоге получим в элементе WebBrowser результат работы
// поисковой системы, а именно множество ссылок на страницы, содержащие
// указанные ключевые слова
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ЗаполнениеВебФормы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Программное заполнение формы";
            // *** Для сайта "http://google.com":
            // var АдресСайта = "http://google.com";
            // var ИмяФормы = "f";
            // var ИмяПоляФормы = "q";
            // Для сайта "http://meta.ua":
            // var АдресСайта = "http://meta.ua";
            // var ИмяФормы = "sForm";
            // var ИмяПоляФормы = "q";
            // *** Для сайта "http://yandex.ru":
            // var АдресСайта = "http://yandex.ru";
            // var ИмяФормы = "form";
            // var ИмяПоляФормы = "text";
            // *** Для сайта "http://rambler.ru":
            // var АдресСайта = "http://rambler.ru";
            // var ИмяФормы = "rSearch";
            // var ИмяПоляФормы = "query";
            // *** Для сайта "http://aport.ru":
            // var АдресСайта = "http://aport.ru";
            // var ИмяФормы = "aport_search";
            // var ИмяПоляФормы = "r";
            // *** Для сайта "http://bing.com":
            // var АдресСайта = "http://bing.com";
            // var ИмяФормы = "sb_form";
            // - в HTML-коде нет name формы, но есть id = "sb_form"
            // var ИмяПоляФормы = "q";
            // *** Для сайта "http://yahoo.com";
            var АдресСайта = "http://yahoo.com";
            var ИмяФормы = "sf1"; // или "p_13838465-searchform"
            var ИмяПоляФормы = "p"; // или "p_13838465-p"
            // Загружаем веб-документ в элемент WebBrowser:
            webBrowser1.Navigate(АдресСайта);
            while (webBrowser1.ReadyState != 
                                     WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }
            if (webBrowser1.Document == null)
            {
                MessageBox.Show(
                    "Возможно, вы не подключены к Интернету", "Ошибка");
                return;
            }
            // Свойство DomDocument приводим к указателю IHTMLDocument2:
            var Док = (mshtml.IHTMLDocument2)
                                      webBrowser1.Document.DomDocument;
            // В этом случае мы получаем доступ к формам веб-страницы
            // по их именам:
            var Форма = (mshtml.HTMLFormElement)
                                         Док.forms.item(ИмяФормы, null);
            if (Форма == null)
            // В VB: If Форма Is Nothing Then...
            {
                MessageBox.Show(String.Format("Форма с " +
                    "именем \"{0}\" не найдена", ИмяФормы), "Ошибка");
                return;
            }
            // В форме находим нужное поле по его (полю) имени:
            var ТекстовоеПоле = (mshtml.IHTMLInputElement)
                                          Форма.namedItem(ИмяПоляФормы);
            if (ТекстовоеПоле == null)
            // В VB: If ТекстовоеПоле Is Nothing Then...
            {
                MessageBox.Show(String.Format("Поле формы с " +
                    "именем \"{0}\" не найдено ", ИмяПоляФормы), "Ошибка");
                return;
            }
            // Заполняем текстовое поле:
            var ТекстЗапроса = "Зиборов Visual";
            ТекстовоеПоле.value = ТекстЗапроса;
            // "Программно" нажимаем кнопку "Submit":
            Форма.submit();
        }
    }
}
