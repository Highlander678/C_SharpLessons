// Программа создает базу данных MS Access, т. е. файл new_BD.mdb.
// Эта база данных будет пустой, т. е. не будет содержать ни одной таблицы.
// Наполнять базу данных таблицами можно будет в последствие
// как из программного кода Visual C# 11, так и используя MS Access.
// В этом примере технология ADO.NET не использована
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Добавим в наш проект библиотеку ADOX: Project | Add Reference, и на
// вкладке COM выбираем Microsoft ADO Ext. 2.8 for DDL and Security
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Для вызова MessageBox выберем следующие пункты меню:
// Project | Add Reference | Accemblies | Framework, затем в списке ссылок
// выберем ссылку System.Windows.Forms, а в тексте программы добавим
// директиву:
using System.Windows.Forms;
namespace БДСоздание
{
    class Program
    {
        static void Main(string[] args)
        {
            var Каталог = new ADOX.Catalog();
            try
            {
                Каталог.Create("Provider=Microsoft.Jet." +
                          "OLEDB.4.0;Data Source=D:\\new_BD.mdb");
                MessageBox.Show(
                    @"База данных D:\new_BD.mdb успешно создана");
            }
            catch (
                System.Runtime.InteropServices.COMException Ситуация)
            {
                MessageBox.Show(Ситуация.Message);
            }
            finally
            {
                Каталог = null;
            }
        }
    }
}
