using System;

namespace MVP_StopWatch
{
    class Presenter
    {
        private readonly Model model; ///Создание модели
        private readonly Form1 view; //Создание отображения
        
        public Presenter(Form1 v) //Конструктор по умолчанию
        {
            //Инициализация элементов
            model = new Model();
            view = v;
            //Подписка на события
            view.Start += ViewStart;
            view.Stop += ViewStop;
            view.Reset += ViewReset;
            view.timer1.Tick += TimerTick;
            view.timer1.Start();
            view.timer1.Enabled = false;

        }

        #region Обработчики событий
        void ViewReset(object sender, EventArgs e) //Обработчик события нажатия по кнопке ViewReset
        {
            view.timer1.Stop();
            view.SecondsTextBox.Clear();
            model.Reset();
        }

        private void ViewStop(object sender, EventArgs e) //Обработчик события нажатия по кнопке ViewStop
        {
            view.timer1.Enabled = false;
        }

        private void ViewStart(object sender, EventArgs e)//Обработчик события нажатия по кнопке ViewStart
        {
            view.timer1.Enabled = true;
        }

        private void TimerTick(object sender, EventArgs e)//Обработчик события TimerTick
        {
            view.SecondsTextBox.Text = model.Tick();
        }
        #endregion

    }
}
