using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfОрфография
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

        private void Сетка_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = "Проверка орфографии";
            // Размеры окна:
            this.Width = 300; this.Height = 150;
            // Расстояния от краев текстового поля до краев окна:
            ТекстПоле.Margin = new Thickness(10, 10, 0, 0);
            // Размеры текстового поля:
            ТекстПоле.Width = 270; ТекстПоле.Height = 95;
            ТекстПоле.Text = null; ТекстПоле.Focus();
            // Включить проверку орфографии:
            ТекстПоле.SpellCheck.IsEnabled = true;
            // Можно включить проверку орфографии также таким образом:
            // SpellCheck.SetIsEnabled(ТекстПоле, True)
            // Разрешить перенос слов на другую строку:
            ТекстПоле.TextWrapping = TextWrapping.Wrap;
            // При нажатии на клавишу <Enter> разрешить переход на
            // следующую строку
            ТекстПоле.AcceptsReturn = true;
            // Коллекция словарей для проверки орфографии:
            var Словари = SpellCheck.GetCustomDictionaries(ТекстПоле);
            // Добавить в коллекцию словарей словарь, созданный нами:
            // Словари.Add(New Uri("D:/dic.lex"));
            // Software is like sex, it's better when it's free
        }
    }
}
