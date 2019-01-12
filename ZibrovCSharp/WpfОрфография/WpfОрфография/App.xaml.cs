// Автономное WPF-приложение содержит элемент управления TextBox с
// включенной проверкой правописания англоязычного текста. Технология
// .NET Framework 4.5 WPF обеспечивает только английский, французский,
// немецкий и испанский словари. Чтобы появилась возможность проверять
// русскоязычный текст, следует в коллекцию CustomDictionaries добавить
// пользовательский словарь русскоязычной лексики *.lex
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace WpfОрфография
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
}
