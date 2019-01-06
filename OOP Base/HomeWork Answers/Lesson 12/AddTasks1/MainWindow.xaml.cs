using System;
using System.Windows;

// View

namespace AddTask1
{    
    public partial class MainWindow : Window
    {
        private EventHandler myEvemt = null; //Создание поля типа EventHandler
        public MainWindow() //Конструктор по умолчанию
        {
            InitializeComponent();
            new Presenter(this); //Связываем View и Presenter
        }

        internal Presenter Presenter
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public event EventHandler MyEvent //Создания события с двумя методами
        {
            add { myEvemt += value; } //Метод подписка на событие
            remove { myEvemt -= value; } //Метод отписки на событие
        }

        private void button1_Click(object sender, RoutedEventArgs e) //Обработчик события нажатия по кнопке
        {
            myEvemt.Invoke(sender, e); //Вызов обработчика события
        }
    }
}
