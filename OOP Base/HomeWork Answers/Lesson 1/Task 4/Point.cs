
namespace Task_4
{
    class Point
    {
        //Создание поля класса
        string name;

        //Свойство для отображения значения поля Name
        public string Name
        {
            get { return name; }
        }

        //Создание полей класса
        int x, y;

        //Свойство для отображения значения поля Х
        public int X
        {
            get { return x; }
        }

        //Свойство для отображения значения поля У
        public int Y
        {
            get { return y; }
        }

        //Пользовательский конструктор
        public Point(string name, int x, int y)
        {
            //Инициализация полей класса
            this.name = name;
            this.x = x;
            this.y = y;
        }
    }
}
