using System;

namespace Task_4
{
    class Figure
    {
        //Создание массива значений типа Point
        Point[] point;
        
        string type;
        //Свойство для отображения типа фигуры 
        public string Type
        {
            get { return type; }
        }

        //Метод вычисления длинны сторони
        double LengthSide(Point A, Point B)
        {
            //Возвращает квадратный корень из суммы разниц координат возвышенных в квадрат  =√((Y.b - Y.a)^2 + (X.b - X.a)^2)
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }

        //Метод вычисления периметра фигуры
        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < point.Length - 1; i++)
            {
                //Суммируем длину каждой стороны фигуры
                sum += LengthSide(point[i], point[i + 1]);
            }
            //Прибавляем длину последней стороны
            sum += LengthSide(point[point.Length - 1], point[0]);
            Console.Write(sum); 
        }
        //Пользовательский конструктор
        public Figure(Point p1, Point p2, Point p3)
        {
            //Инициализация полей.
            point = new Point[3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            type = "Triangle";
        }

        //Перегрузка пользовательского конструктора
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            //Инициализация полей.
            point = new Point[4];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            type = "Tetragon";
        }
        //Перегрузка пользовательского конструктора
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            //Инициализация полей.
            point = new Point[5];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            point[4] = p5;
            type = "Pentagon";
        }
    }
}
