// На вход данной веб-службы предлагается ввести два числа, а веб-служба
// берет на себя функцию сложения этих двух чисел и вывода (возврата)
// суммы. При этом веб-служба производит диагностику вводимых данных
// ~ ~ ~ ~ ~ ~ ~ ~ 
using System;
using System.Web.Services;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВебСлужбаСумма
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
        public string Сумма(String Число1, String Число2)
        {
            // Входные параметры объявляем типа String, чтобы принимать
            // от пользователя любые символы, их анализировать, и при
            // "плохом вводе" сообщать по-русски.
            Single X, Y;
            var Число_ли = Single.TryParse(
                        Число1, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out X);
            if (Число_ли == false) 
                          return "В первом поле должно быть число";

            Число_ли = Single.TryParse(
                        Число2, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out Y);
            if (Число_ли == false) 
                          return "Во втором поле должно быть число";

            var Z = X + Y;
            return "Сумма = " + Z.ToString();
        }
    }
}
