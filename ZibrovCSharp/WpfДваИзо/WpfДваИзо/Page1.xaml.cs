// WPF-приложение содержит на веб-странице два изображения. Поскольку 
// месторасположение обоих изображений задано одинаково, а также совпадают
// размеры изображений, пользователь будет видеть только второе "верхнее"
// изображение. После щелчка на изображении оно становится все более
// прозрачным, постепенно "проявляя" тем самым "нижнее" изображение. После
// исчезновения "верхнего" изображения, мы будем видеть только "нижнее"
// изображение. При повторном щелчке на изображении, наоборот,
// прозрачность верхнего изображения постепенно снижается, и в конце
// анимационного эффекта мы опять видим только "верхнее" изображение
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
//using System.Windows.Media;
using System.Windows.Media.Imaging;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace WpfДваИзо
{
    public partial class Page1 : Page
    {
        Boolean Флажок = false;// Внешняя переменная
        public Page1()
        {
            InitializeComponent();
        }
        private void Сетка_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowTitle = "Щелкни на изображении";
            // Изображение автомобиля Chevrolet Cavalier:
            Изо1.Source = new BitmapImage(
                                    new Uri("c1.bmp", UriKind.Relative));
            // Изображение автомобиля BMW M3:
            Изо2.Source = new BitmapImage(
                                    new Uri("c2.bmp", UriKind.Relative));
            // Положение обоих изображений на странице задаем одинаковое,
            // поэтому один рисунок закрывает другой:
            Изо1.HorizontalAlignment = HorizontalAlignment.Left;
            Изо2.HorizontalAlignment = HorizontalAlignment.Left;
            Изо1.VerticalAlignment = VerticalAlignment.Top;
            Изо2.VerticalAlignment = VerticalAlignment.Top;
            // Размеры изображений:
            Изо1.Width = 591; Изо1.Height = 258;
            Изо2.Width = 591; Изо2.Height = 258;
            // Расстояния от краев Web-страницы до сетки Grid:
            Изо1.Margin = new Thickness(10, 10, 0, 0);
            Изо2.Margin = new Thickness(10, 10, 0, 0);
            // Присоединяем один обработчик двух событий:
            Изо1.MouseDown += new MouseButtonEventHandler(Изо_MouseDown);
            Изо2.MouseDown += new MouseButtonEventHandler(Изо_MouseDown);
            // Свойство Opacity задает уровень непрозрачности
            // Изо1.Opacity = 1; 
        }
        private void Изо_MouseDown(object sender, RoutedEventArgs e)
        {
            // Ниже написана процедура обработки события "щелчок" на любом
            // из изображений.
            // Изменяем состояние флажка на противоположное:
            Флажок = !Флажок;
            // Создаем объект анимации:
            var Аниме = new System.Windows.Media.Animation.
                                          DoubleAnimation();
            // Устанавливаем пределы изменения степени непрозрачности:
            if (Флажок == true)
            {
                Аниме.From = 1; Аниме.To = 0;
            }
            else
            {
                Аниме.From = 0; Аниме.To = 1;
            }
            // Продолжительность анимационного эффекта задаем равной 
            // 5 секундам:
            Аниме.Duration = TimeSpan.FromSeconds(5);
            // Запускаем анимацию для "верхнего" изображения:
            Изо2.BeginAnimation(Image.OpacityProperty, Аниме);
        }
    }
}
