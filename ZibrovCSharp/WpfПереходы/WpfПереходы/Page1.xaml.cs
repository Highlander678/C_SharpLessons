// Данное WPF-приложение содержит в себе две веб-страницы: Page1.xaml
// и Page2.xaml. На первой мы разместили командную кнопку и текстовый
// блок. В программном коде первой страницы мы создали объект Hyperlink,
// чтобы обеспечить переход на почтовый сервер www.ukr.net. Щелчок мышью
// на кнопке реализует переход на вторую веб-страницу Page2.xaml.
// Возврат со второй страницы на первую организован также с помощью
// гиперссылки Hyperlink
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace WpfПереходы
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Сетка_Initialized(object sender, EventArgs e)
        {
            this.WindowTitle = "Первая WPF-страница";
            // Сетку Сетку размещаем в левом верхнем углу веб-страницы: 
            Сетка.HorizontalAlignment = HorizontalAlignment.Left;
            Сетка.VerticalAlignment = VerticalAlignment.Top;
            // Удобно для отладки показать линии сетки:
            // Сетка.ShowGridLines = true;
            // Расстояния от краев веб-страницы до сетки Сетка:
            Сетка.Margin = new Thickness(10, 10, 10, 10);
            // Цвет объекта Сетка:
            Сетка.Background = Brushes.LightGray;
            // Сетка имеет одну колонку и два ряда:
            Сетка.ColumnDefinitions.Add(new ColumnDefinition());
            Сетка.RowDefinitions.Add(new RowDefinition());
            Сетка.RowDefinitions.Add(new RowDefinition());
            // Указываем, что кнопку расположить в верхнем ряду, а
            //  изображение - в нижнем ряду:
            Grid.SetRow(Кнопка, 0); Grid.SetColumn(Кнопка, 0);
            Grid.SetRow(ТекстБлок, 1); Grid.SetColumn(ТекстБлок, 0);
            Кнопка.Width = 170; Кнопка.Focus();
            Кнопка.Content = "Перейти на вторую страницу";
            Кнопка.Margin = new Thickness(10, 10, 10, 10);
            ТекстБлок.Margin = new Thickness(10, 10, 10, 10);
            ТекстБлок.Text = "Перейти ";
            // Создаем объект класса Hyperlink для размещения гиперссылки:
            var Ссылка = new Hyperlink();
            // Задаем ссылку для перехода на нужный ресурс:
            Ссылка.NavigateUri = new Uri("http://www.ukr.net");
            // Задаем текст, отображаемый в элементе управления Hyperlink:
            Ссылка.Inlines.Add("на почтовый сервер www.ukr.net");
            // Добавляем ссылку в текстовый блок:
            ТекстБлок.Inlines.Add(Ссылка);
        }
        private void Кнопка_Click(object sender, RoutedEventArgs e)
        {
            // Объект NavigationService обеспечивает навигацию на другой
            // ресурс:
            this.NavigationService.Navigate(
                  new Uri("Page2.xaml", UriKind.Relative));
        }
    }
}
