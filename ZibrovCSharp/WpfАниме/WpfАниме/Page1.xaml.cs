// WPF-приложение выводит на веб-страницу командную кнопку и изображение.
// При щелчке на кнопке и на изображении демонстрируются возможности
// анимации: кнопка расширяется, а затем медленно уменьшается до исходных
// размеров; аналогично поведение изображения
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace WpfАниме
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Сетка_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowTitle = "Анимационный эффект";
            // Сетку Сетку размещаем в левом верхнем углу веб-страницы:
            Сетка.HorizontalAlignment = HorizontalAlignment.Left;
            Сетка.VerticalAlignment = VerticalAlignment.Top;
            // Удобно для отладки показать грид-линии:
            // Сетка.ShowGridLines = True
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
            Grid.SetRow(Изо, 1); Grid.SetColumn(Изо, 0);
            Кнопка.Width = 100;
            Кнопка.Content = "Привет!"; Кнопка.Focus();
            Кнопка.Margin = new Thickness(10, 10, 10, 10);
            // Указывем, что изображение добавлено в проект:
            Изо.Source = new BitmapImage(
                         new Uri("poryv.png", UriKind.Relative));
            Изо.Margin = new Thickness(10, 10, 10, 10);
            Изо.Width = 100; Изо.Height = 100;
        }
        private void Кнопка_Click(object sender, RoutedEventArgs e)
        {
            var Аниме = new System.Windows.Media.Animation.
                                                 DoubleAnimation();
            // Изменить размер от 160 до 100 пикселей:
            Аниме.From = 160; Аниме.To = 100;
            // Продолжительность анимационного эффекта 5 секунд:
            Аниме.Duration = TimeSpan.FromSeconds(5);
            // Начать анимацию:
            Кнопка.BeginAnimation(Button.WidthProperty, Аниме);
        }
        private void Изо_MouseLeftButtonUp(
                                  Object sender, MouseButtonEventArgs e)
        {
            // Щелчок на изображении:
            var Аниме = new System.Windows.Media.Animation.
                                                    DoubleAnimation();
            Аниме.From = 160; Аниме.To = 100;
            Аниме.Duration = TimeSpan.FromSeconds(5);
            Изо.BeginAnimation(Image.WidthProperty, Аниме);
            Изо.BeginAnimation(Image.HeightProperty, Аниме);
        }
    }
}
