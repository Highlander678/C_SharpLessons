// Вторая страница приложения
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace WpfПереходы
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Сетка_Initialized(object sender, EventArgs e)
        {
            this.WindowTitle = "Вторая WPF-страница";
            // Сетку Сетку размещаем в левом верхнем углу веб-страницы: 
            Сетка.HorizontalAlignment = HorizontalAlignment.Left;
            Сетка.VerticalAlignment = VerticalAlignment.Top;
            // Удобно для отладки показать линии сетки:
            // Сетка.ShowGridLines = true;
            // Расстояния от краев веб-страницы до сетки Сетка:
            Сетка.Margin = new Thickness(10, 10, 10, 10);
            // Цвет объекта Сетка:
            // Сетка.Background = Brushes.LightGray;
            // Сетка имеет одну колонку и два ряда:
            Сетка.ColumnDefinitions.Add(new ColumnDefinition());
            Сетка.RowDefinitions.Add(new RowDefinition());
            Сетка.RowDefinitions.Add(new RowDefinition());
            // Указываем, что кнопку расположить в верхнем ряду, а
            //  изображение - в нижнем ряду:
            Grid.SetRow(Метка, 0); Grid.SetColumn(Метка, 0);
            Grid.SetRow(ТекстБлок, 1); Grid.SetColumn(ТекстБлок, 0);
            Метка.Content = "Вы перешли на вторую страницу";
            ТекстБлок.Text = "Щелкните ";
            // Создаем объект класса Hyperlink для размещения гиперссылки:
            var Ссылка = new Hyperlink();
            // Задаем ссылку для перехода на нужный ресурс:
            Ссылка.NavigateUri = new Uri("Page1.xaml", UriKind.Relative);
            // Задаем текст, отображаемый в элементе управления Hyperlink:
            Ссылка.Inlines.Add("здесь");
            // Добавляем ссылку в текстовый блок:
            ТекстБлок.Inlines.Add(Ссылка);
            // Добавляем текст в текстовый блок:
            ТекстБлок.Inlines.Add(
                              " для перехода назад на первую страницу.");
        }
    }
}
