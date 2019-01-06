namespace Lessons_16
{
    class Point
    {
        //Автоматические свойства для хранения координат токчки
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point() //Конструктор по умолчанию
        {

        }

        public static Point operator +(Point p1, Point p2) //Перегрузка оператора сложения
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        public Point(int x, int y, int z)//Пользовательский конструктор который принимает 3 параметра 
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
