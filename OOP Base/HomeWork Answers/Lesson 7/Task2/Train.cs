using System;

namespace Task_2
{
    public struct Train
    {
        //Создание закрытых полей класса
        private string punkt;
        private int nomer;
        private DateTime time;

        public Train(string punkt, int nomer, DateTime time) //Пользовательский конструктор
        {
            //Инициализация полей класса
            this.punkt = punkt; 
            this.nomer = nomer;
            this.time = time;
        }

        public string Punkt //Свойство для возвращения значения поля punkt
        {
            get { return punkt; }
        }

        public int Nomer //Свойство для возвращения значения поля nomer
        {
            get { return nomer; }
        }

        public DateTime Time //Свойство для возвращения значения поля time
        {
            get { return time; }
        }
    }
}
