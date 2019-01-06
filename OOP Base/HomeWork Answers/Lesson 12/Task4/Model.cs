namespace MVPCalculate
{
    class Model
    {
        #region Методы арифметических операций
        public string Add(int a, int b) //Метод сложения чисел
       {
           return (a+b).ToString();
       }
        public string Sub(int a, int b) //Метод вычитания чисел
        {
            return (a - b).ToString();
        }
        public string Multi(int a, int b) //Метод умножения чисел
        {
            return (a*b).ToString();
        }
        public string Div(int a, int b) //Метод деления чисел
        {
            if (b != 0)
                return ((double) a/b).ToString();
            return "На нуль делить нельзя";
        }
        #endregion
    }
}
