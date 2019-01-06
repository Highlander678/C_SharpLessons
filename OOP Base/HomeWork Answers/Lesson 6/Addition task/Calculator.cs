namespace Lessons_7
{
    static class Calculator //Статический класс
    {
        static public double Add(double a, double b) //Статический метод сложения чисел
        {
            return a + b; //Возвращает метод результат математической операции сложения
        }

        static public double Subtraction(double a, double b) //Статический метод вычитания чисел
        {
            return a - b;
        }

        static public double Multiply(double a, double b) //Статический метод умножения чисел
        {
            if (a == 0 || b == 0) //Если одно из значений равно нулю то результат будет нуль
            {
                return 0;
            }
            return a * b;
        }

        static public double Division(double a, double b) //Статический метод деления чисел
        {
            if (b == 0) //Если делитель равен нулю, то выполнение операции невозможно, возвращаем нуль
            {
                return 0;
            }
            return a / b;
        }
    }
}
