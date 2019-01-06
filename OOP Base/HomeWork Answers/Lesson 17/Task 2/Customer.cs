namespace Task_2
{
    struct Customer
    {
        //Поля доступные только для чтения
        readonly string name;
        readonly string model;
        readonly string tel;

        public Customer(string name, string model, string tel) //Пользовательский конструктор
        {
            this.name = name;
            this.model = model;
            this.tel = tel;
        }

        public string Tel //Свойство возвращающее значение поля tel 
        {
            get { return tel; }
        }

        public string Model//Свойство возвращающее значение поля model
        {
            get { return model; }
        }

        public string Name//Свойство возвращающее значение поля name
        {
            get { return name; }
        }

        public override string ToString()
        {
            return "Покупатель: " + name + " Модель: " + model + " Телефон: " + tel;
        }
    }
}
