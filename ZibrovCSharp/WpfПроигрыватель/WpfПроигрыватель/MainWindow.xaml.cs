// WPF-проигрыватель, позволяющий воспроизводить мультимедиа, включать
// паузу, остановку, а также настраивать громкость с помощью "ползунка"
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace WpfПроигрыватель
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Сетка_Loaded(object sender, RoutedEventArgs e)
        {
            // Строка заголовка веб-страницы: 
            this.Title = "Мадиа проигрыватель";
            this.Width = 435; this.Height = 430;
            // Компонуем элементы управления с помощью панели StackPanel:
            Ст1.Margin = new Thickness(10, 10, 0, 0);
            Ст1.Width = 410; Ст1.Height = 400;
            Ст2.Width = 410; Ст2.Height = 50;
            // При отладке удобно задать фоновый цвет панели:
            //Ст2.Background = Brushes.LightGray;
            Ст1.Orientation = Orientation.Vertical;
            Ст2.Orientation = Orientation.Horizontal;
            Кн1.Height = 23; Кн2.Height = 23; Кн3.Height = 23;
            Кн1.Width = 75; Кн2.Width = 75; Кн3.Width = 75;
            Кн1.Focus(); Кн1.Content = "Play";
            Кн2.Content = "Pause"; Кн3.Content = "Stop";
            // Расстояния от краев текстового блока до краев окна:
            ТБ.Margin = new Thickness(10, 13, 10, 0);
            ТБ.Text = "Громкость:"; ТБ.FontSize = 12;
            // Элемент выбора из диапазона значений "Ползунок" (Slider):
            Сл.Height = 23; Сл.Width = 100;
            Сл.Minimum = 0; Сл.Maximum = 1; Сл.Value = 0.5;
            // MediaElement представляет элемент, содержащий аудио 
            // и/или видео:
            Медиа.Source = new Uri(@"D:/ВысшийПилотаж.mp4");
            Медиа.Width = 400; Медиа.Height = 340;
            Медиа.HorizontalAlignment = HorizontalAlignment.Left;
            // Manual - состояние, используемое для управления элементом
            // MediaElement вручную, при этом можно использовать
            // интерактивные методы, такие как Play и Pause:
            Медиа.LoadedBehavior = MediaState.Manual;
            Медиа.UnloadedBehavior = MediaState.Stop;
            Медиа.Stretch = Stretch.Fill;
        }
        private void Кн1_Click(object sender, RoutedEventArgs e)
        {
            // Чтобы начать просмотр ролика, следует подать команду Play.
            // Если MediaElement пребывает в состоянии Pause, то команда
            // Play продолжит воспроизведение ролика с текущего положения.
            // Метод Play начинает воспроизведение файла мультимедиа:
            Медиа.Play();
            // Задаем громкость воспроизведения файла мультимедиа в
            // зависимости от состояния элемента "ползунок":
            Медиа.Volume = Сл.Value;
        }
        private void Медиа_MediaEnded(Object sender, RoutedEventArgs e)
        {
            // При завершении воспроизведения файла мультимедиа переводим
            // элемент MediaElement в состояние Stop:
            Медиа.Stop();
        }
        private void Сл_ValueChanged(Object sender,
                                  RoutedPropertyChangedEventArgs<double> e)
        {
            // Если значение свойства Value элемента "ползунок" изменяется,
            // то изменяем громкость вопроизведения мультимедиа Volume:
            Медиа.Volume = Сл.Value;
        }
        private void Кн2_Click(Object sender, RoutedEventArgs e)
        {
            // Приостанавливаем воспроизведение файла мультимедиа:
            Медиа.Pause();
        }
        private void Кн3_Click(object sender, RoutedEventArgs e)
        {
            // Останавливаем и возвращаем воспроизведение файла мультимедиа
            // на начало:
            Медиа.Stop();
        }
    }
}
