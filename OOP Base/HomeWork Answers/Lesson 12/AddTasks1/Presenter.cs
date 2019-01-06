using System;

// Presenter

namespace AddTask1
{
    class Presenter
    {
        Model model = null; 
        MainWindow mainWindow = null; 

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();//Связываем Presenter и Model
            this.mainWindow = mainWindow;//Связываем Presenter и MainWindow
            this.mainWindow.MyEvent += new EventHandler(mainWindow_myEvent); //Подписываем mainWindow_myEvent на событие mainWindow.MyEvent
        }

        void mainWindow_myEvent(object sender, System.EventArgs e) //Обработчик события mainWindow.MyEvent
        {
            string variable = model.Logic(this.mainWindow.textBox1.Text); //В переменную строкового типа записываем значение полученое после выполнения  model.Logic

            this.mainWindow.textBox1.Text = variable; //textBox1.Text присваиваем значение переменной variable
        }
    }
}
