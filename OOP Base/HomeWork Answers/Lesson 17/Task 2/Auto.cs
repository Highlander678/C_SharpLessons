namespace Task_2
{
    struct Auto
    {
        //Поля доступные только для чтения
        readonly string marka;
        readonly string model;
        readonly int year;
        private readonly string color;

        public Auto(string marka, string model, int year, string color) //Пользовательский конструктор
        {
            this.marka = marka;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public string Color //Свойство возвращающее значение поля color
        {
            get { return color; }
        }

        public string Model//Свойство возвращающее значение поля model
        {
            get { return model; }
        }

        public int Year//Свойство возвращающее значение поля year
        {
            get { return year; }
        }

        public string Marka//Свойство возвращающее значение поля marka
        {
            get { return marka; }
        }

        public override string ToString() //Переопределение метода ToString базового класса Object
        {
            return "Марка: " + marka + " Модель: " + model + " Год выпуска: " + year + " Цвет: " + color;
        }
    }
}
