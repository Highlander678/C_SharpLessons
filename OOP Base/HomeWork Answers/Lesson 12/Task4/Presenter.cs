using System;

namespace MVPCalculate
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow;
            //Подписываемся на события
            this.mainWindow.AddEvent += MainWindowAdd;
            this.mainWindow.SubEvent += MainWindowSub;
            this.mainWindow.MulEvent += MainWindowMul;
            this.mainWindow.DivEvent += MainWindowDiv;
        }

        #region Методы-обработчики событий
        void MainWindowAdd(object sender, EventArgs e)
        {
            string variable = model.Add(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text)); //Вызов метода Add модели который принимает 2 аргумента целого типа и возвращает значение строкового типа 
            mainWindow.Result_textBox.Text = variable;
        }
        void MainWindowSub(object sender, EventArgs e)
        {
            string variable = model.Sub(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text));//Вызов метода Sub модели который принимает 2 аргумента целого типа и возвращает значение строкового типа
            mainWindow.Result_textBox.Text = variable;
        }
        void MainWindowMul(object sender, EventArgs e)
        {
            string variable = model.Multi(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                          Convert.ToInt32(mainWindow.Operand2_textBox.Text));//Вызов метода Multi модели который принимает 2 аргумента целого типа и возвращает значение строкового типа
            mainWindow.Result_textBox.Text = variable;
        }
        void MainWindowDiv(object sender, EventArgs e)
        {
            string variable = model.Div(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text));//Вызов метода Div модели который принимает 2 аргумента целого типа и возвращает значение строкового типа
            mainWindow.Result_textBox.Text = variable;
        }
        #endregion
    }
}
