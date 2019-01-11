#define Config

using System;
using System.Linq;
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
        ISetting settings;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TextFont.ItemsSource = Fonts.SystemFontFamilies.OrderBy(x => x.Source);
            TextSize.ItemsSource = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

#if Config
            settings = new SettingConfig();
#else
            settings = new SettingRegistry();
#endif
            FillSettings();
        }

        private void ClrBack_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var bc = new BrushConverter();
            MainText.Background = BackColor.Background = TextColor.Background = FontSize.Background = FontStyle.Background
                = (Brush)bc.ConvertFromString(ClrBack.SelectedColor.ToString());

        }

        private void ClrText_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var bc = new BrushConverter();
            MainText.Foreground = BackColor.Foreground = TextColor.Foreground = FontSize.Foreground = FontStyle.Foreground
               = (Brush)bc.ConvertFromString(ClrText.SelectedColor.ToString());
        }

        private void TextSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainText.FontSize = BackColor.FontSize = TextColor.FontSize = FontSize.FontSize = FontStyle.FontSize
                = Convert.ToInt32(TextSize.SelectedItem);
        }

        private void TextFont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainText.FontFamily = BackColor.FontFamily = TextColor.FontFamily = FontSize.FontFamily = FontStyle.FontFamily
                = TextFont.SelectedItem as FontFamily;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            settings.BackColor = BackColor.Background;
            settings.TextColor = TextColor.Foreground;
            settings.TextSize = (int)FontSize.FontSize;
            settings.TextFont = FontStyle.FontFamily;

            settings.SaveSettings();

            MainTab.IsSelected = true;
        }

        private void FillSettings()
        {
            MainText.Background = BackColor.Background = TextColor.Background = FontSize.Background = FontStyle.Background
                = settings.BackColor;

            MainText.Foreground = BackColor.Foreground = TextColor.Foreground = FontSize.Foreground = FontStyle.Foreground
                = settings.TextColor;

            MainText.FontSize = BackColor.FontSize = TextColor.FontSize = FontSize.FontSize = FontStyle.FontSize
                = settings.TextSize;

            MainText.FontFamily = BackColor.FontFamily = TextColor.FontFamily = FontSize.FontFamily = FontStyle.FontFamily
                = settings.TextFont;
        }
    }
}
