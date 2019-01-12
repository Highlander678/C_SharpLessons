// Программа воспроизводит видеоролик с помощью элемента MediaElement и
// накладывает на него форматированный текст "ПОЛЕТ"
using System;
using System.Windows;
using System.Windows.Media;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace WpfТекстНаВидео
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Grid_Initialized_1(object sender, EventArgs e)
        {
            this.Title = "Высший пилотаж";
            // Размеры окна:
            this.Width = 420; this.Height = 355;
            Медиа.Width = 400; Медиа.Height = 300;
            Медиа.Source = new Uri(@"D:/ВысшийПилотаж.mp4");
            // Создаем форматированный текст:
            var ФорматированныйТекст = new FormattedText("ПОЛЕТ",
               System.Globalization.CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                new Typeface(this.FontFamily, FontStyles.Normal,
                    FontWeights.ExtraBold, FontStretches.Normal),
                111.0, Brushes.Red);
            // Строим геометрическую фигуру с отрисованным форматированным
            // текстом:
            var ГеометрическаяФигура = ФорматированныйТекст.
                                 BuildGeometry(new Point(12.0F, -36.0F));
            // Масштабируем геометрическую фигуру растягивая ее по
            // вертикали:
            var Масштаб = new ScaleTransform();
            // Указываем коэффициент растяжения по вертикали:
            Масштаб.ScaleY = 3.55;
            ГеометрическаяФигура.Transform = Масштаб;
            // Задаем геометрию в пределах контура медиа-элемента:
            Медиа.Clip = ГеометрическаяФигура;
        }
    }
}
