// Автономное WPF-приложение содержит текстовый блок. Цвет текста в
// этом блоке закрашен с применением градиента. Между начальной t=0.0
// и конечной t=1.0 точками области текста заданы две ключевые точки
// t=0.25 и t=0.75. Каждой точке ставим в соответствие цвета: желтый,
// красный, синий и зеленый. Между этими цветами задаем плавный переход
// от одного цвета к другому с помощью градиента
using System.Windows;
using System.Windows.Media;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace WpfГрадиент
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Сетка_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = "Игорь Губерман";
            ТекстБлок.Text =
                "Какие дамы, и не раз, шептали: \"Дорогой," + "\r\n" +
                "Конечно, да, но не сейчас, не здесь, и не с тобой!\"";
            ТекстБлок.Width = 470; ТекстБлок.Height = 50;
            ТекстБлок.FontSize = 20;
            // ТекстБлок.Background = Brushes.Gray
            // Создаем горизонтальный линейный градиент
            var Градиент = new LinearGradientBrush();
            // Задаем область для закрашивания линейным градиентом:
            Градиент.StartPoint = new Point(0, 0.5);
            Градиент.EndPoint = new Point(1, 0.5);
            // Четыре точки t=0.0; t=0.25; t=0.75 и t=1.0 образуют три
            // подобласти с переходом цвета от желтого к красному, далее
            // синему и затем зеленому
            Градиент.GradientStops.Add(new GradientStop(Colors.Yellow, 0.0));
            Градиент.GradientStops.Add(new GradientStop(Colors.Red, 0.25));
            Градиент.GradientStops.Add(new GradientStop(Colors.Blue, 0.75));
            Градиент.GradientStops.Add(new GradientStop(
                                                    Colors.LimeGreen, 1.0));
            // Закрашиваем текст горизонтальным линейным градиентом:
            ТекстБлок.Foreground = Градиент;
        }
    }
}
