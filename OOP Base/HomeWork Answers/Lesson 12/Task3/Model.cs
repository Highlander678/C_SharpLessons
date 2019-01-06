namespace MVP_StopWatch
{
    class Model
    {
        private int s; //Создание закрытого поля целочисленного типа?
       
        public string Tick()
        {
            s++; //Инкрементируем поле s
            return s >= 60 ? (s/60) + " мин " + s%60 + " сек" : s.ToString();
        }
        public void Reset() //Метод обнуления поля
        {
            s = 0;
        }

    }
}
