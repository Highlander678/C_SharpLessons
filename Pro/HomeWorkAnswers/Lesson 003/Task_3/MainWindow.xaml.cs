using System.IO;
using System.IO.IsolatedStorage;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();

            // Открытие файлового потока с указанием: Имени файла, FileMode, объекта хранилища.
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.OpenOrCreate, userStorage);

            // StreamWriter - чтение данных из потока userStream.
            StreamReader userReader = new StreamReader(userStream);

            string color = userReader.ReadToEnd();
            userReader.Close();
            userStream.Close();

            var bc = new BrushConverter();
            if (!string.IsNullOrEmpty(color))
            {
                ColorLabel.Background = (Brush)bc.ConvertFromString(color);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {          
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();

            // Создание файлового потока с указанием: Имени файла, FileMode, объекта хранилища.
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStorage);

            //   StreamWriter - запись данных в поток userStream.
            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine(ClrPcker.SelectedColor);
            userWriter.Close();
            userStream.Close();
            ColorLabel.Content = string.Format("Цвет '{0}' сохранен\nв изолированное хранилище", ClrPcker.SelectedColorText);
        }

        private void ClrPcker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<System.Windows.Media.Color?> e)
        {
            ColorLabel.Content = ClrPcker.SelectedColorText;

            var bc = new BrushConverter();
            ColorLabel.Background = (Brush)bc.ConvertFromString(ClrPcker.SelectedColor.ToString());
        }

    }
}
