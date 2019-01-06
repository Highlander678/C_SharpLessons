namespace Task_2
{
    class Rectangle
    {
        //Создание полей класса.
        double side1, side2;

        /// <summary>
        /// Построение прямоугольника.
        /// </summary>
        /// <param name="side1">Длина первой стороны</param>
        /// <param name="side2">Длина второй стороны</param>

        //Пользовательский конструктор
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        /// <summary>
        /// Расчет периметра.
        /// </summary>
        /// <returns>Периметр</returns>
         
        //Метод вычисления периметра прямоугольника
        double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
        //Данное свойство только для чтения, и всегда возвращает результат выполнения метода PerimeterCalculator
        public double Perimeter
        {
            get
            {
                //Ключевое слово this ссылается на текущий экземпляр класса
                return this.PerimeterCalculator();
            }
        }

        /// <summary>
        /// Расчет площади
        /// </summary>
        /// <returns>Площадь</returns>

        //Вычисление площади прямоугольника
        double AreaCalculator()
        {
            return side1 * side2;
        }

        //Данное свойство только для чтения, и всегда возвращает результат выполнения метода AreaCalculator
        public double Area
        {
            get
            {
                //Ключевое слово this ссылается на текущий экземпляр класса
                return this.AreaCalculator();
            }
        }
    }
}
