// Веб-служба, которая с помощью синтаксического разбора веб-страницы
// http://www.forex-rdc.ru/subscribers.php?action=prognoz
// извлекает торговую рекомендацию на рынке Forex для валютной пары EURUSD,
// предлагаемую данным сайтом на текущий день, и выводит ее потребителю
// сервиса веб-службы в виде строки
// ~ ~ ~ ~ ~ ~ ~ ~ 
using System;
using System.Web.Services;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВебСлужбаForex
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET
    // AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string Рекомендация()
        {
            // Создаем объект для чтения веб-страницы:
            var КЛИЕНТ = new System.Net.WebClient();
            // Чтобы русские буквы читались корректно, объявляем
            // объект Кодировка:
            var Кодировка = System.Text.Encoding.GetEncoding(1251);
            System.IO.Stream ПОТОК;
            var СТРОКА = "Строка";
            try
            {
                // Попытка открытия веб-ресурса:
                ПОТОК = КЛИЕНТ.OpenRead(
                 "http://www.forex-rdc.ru/subscribers.php?action=prognoz");
            }
            catch (Exception Ситуация)
            {
                СТРОКА = String.Format(
                         "Ошибка открытия www.forex-rdc.ru" +
                         "\r\n" + "{0}", Ситуация);
                return СТРОКА;
            }
            // Чтение HTML-разметки веб-страницы:
            var Читатель = new System.IO.StreamReader(ПОТОК, Кодировка);
            // Копируем HTML-разметку в строковую переменную:
            СТРОКА = Читатель.ReadToEnd();
            // Ищем в разметке страницы фрагмент с указанной строкой:
            var i = СТРОКА.IndexOf("Торговая стратегия:");
            // Ищем стратегию только для EURUSD:
            СТРОКА = СТРОКА.Substring(i, 120);
            // Удаляем HTML-разметку:
            i = СТРОКА.IndexOf("</p>");
            СТРОКА = СТРОКА.Remove(i);
            СТРОКА = СТРОКА.Replace("</b>", "");
            // Вставляем текущую дату:
            СТРОКА = СТРОКА.Replace(
                     "стратегия:", "стратегия для EURUSD на " +
                     DateTime.Now.ToLongDateString() + ":" + "\r\n");
            ПОТОК.Close();
            return СТРОКА;
        }
    }
}
