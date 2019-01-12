// Данное WPF-приложение вычисляет значение квадратного корня из числа, 
// введенного пользователем в текстовое поле. После щелчка на кнопке
// приложение производит диагностику введенных символов, и если
// пользователь действительно ввел число, то в текстовую метку выводим
// результат извлечения корня
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace WpfКорень
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
            // Строка заголовка веб-страницы: 
            this.WindowTitle = "Извлекаю корень";
            // Компонуем элементы управления с помощью сетки Grid:
            Сетка.Width = 200; Сетка.Height = 100;
            // Сетку Сетку размещаем в левом верхнем углу веб-страницы: 
            Сетка.HorizontalAlignment = HorizontalAlignment.Left;
            Сетка.VerticalAlignment = VerticalAlignment.Top;
            // Удобно для отладки показать линии сетки:
            // Сетка.ShowGridLines = True
            // Расстояния от краев веб-страницы до сетки:
            Сетка.Margin = new Thickness(10, 10, 10, 10);
            // Цвет объекта Сетку:
            Сетка.Background = Brushes.LightGray;
            // Сетка имеет одну колонку и три ряда:
            Сетка.ColumnDefinitions.Add(new ColumnDefinition());
            Сетка.RowDefinitions.Add(new RowDefinition());
            Сетка.RowDefinitions.Add(new RowDefinition());
            Сетка.RowDefinitions.Add(new RowDefinition());
            // Указываем, что текстовое поле расположить в нулевой колонке в
            // нулевом ряду:
            Grid.SetRow(ТекстПоле, 0); Grid.SetColumn(ТекстПоле, 0);
            Grid.SetRow(Метка, 1); Grid.SetColumn(Метка, 0);
            Grid.SetRow(Кнопка, 2); Grid.SetColumn(Кнопка, 0);
            // Текстовое поле располагаем в левом нижнем углу ячейки сдвинув
            // его на 10 пикселей:
            ТекстПоле.HorizontalAlignment = HorizontalAlignment.Left;
            ТекстПоле.VerticalAlignment = VerticalAlignment.Bottom;
            ТекстПоле.Margin = new Thickness(10, 0, 0, 0);
            ТекстПоле.Width = 120; ТекстПоле.Focus();
            ТекстПоле.Text = null;
            Метка.HorizontalAlignment = HorizontalAlignment.Left;
            Метка.VerticalAlignment = VerticalAlignment.Bottom;
            Метка.Margin = new Thickness(10, 0, 0, 0);
            Кнопка.HorizontalAlignment = HorizontalAlignment.Left;
            Кнопка.VerticalAlignment = VerticalAlignment.Top;
            Кнопка.Margin = new Thickness(10, 0, 0, 0);
            Кнопка.Content = "Извлечь корень"; Кнопка.Width = 120;
            Метка.Content = "Введите число в текстовое поле";
            Метка.Foreground = Brushes.Blue;// - синий цвет текста на метке
        }
        private void Кнопка_Click(object sender, RoutedEventArgs e)
        {
            // Поскольку метод Sqrt предусматривает на входе и на выходе
            // переменные Double, будем преобразовывать к этому типу числа,
            // принимаемые от пользователя
            Double X;  // - из этого числа будем извлекать корень
            var Число_ли = Double.TryParse(ТекстПоле.Text,
                  System.Globalization.NumberStyles.Number,
                  System.Globalization.NumberFormatInfo.CurrentInfo, out X);
            // второй параметр - это разрешенный стиль числа (Integer, 
            // шестнадцатиричное число, экспоненциальный вид числа и прочее)
            // третий параметр - форматирует значения на основе текущего
            // языка и региональных параметров из Панели управления - Язык и
            // региональные стандарты число допустимого формата, метод
            // возвращает значение в переменную X
            if (Число_ли == false)
            {
                // Если пользователь ввел не число:
                Метка.Content = "Следует вводить числа";
                // Красный цвет текста на метке:
                Метка.Foreground = Brushes.Red;
                return; // - выход из процедуры
            }
            Double Y = Math.Sqrt(X); // - извлечение корня
            Метка.Foreground = Brushes.Blue; // - синий цвет текста на метке
            Метка.Content = String.Format("Корень из {0} равен {1:F5}", X, Y);
        }
    }
}
