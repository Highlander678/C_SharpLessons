using System;

namespace Lessons8
{
    public struct Notebook
    {
        readonly string model; //Создание полей только для чтения
        readonly string producer;
        readonly double price;

        public string Model //Свойство только для чтения поля model
        {
            get { return model; }
        }

        public string Producer //Свойство только для чтения поля producer
        {
            get { return producer; }
        }

        public double Price //Свойство только для чтения поля price
        {
            get { return price; }
        }

        public Notebook(string model, string producer, double price) //Пользовательский конструктор, принимает 3 аргумента
        {
            this.model = model;
            this.producer = producer;
            this.price = Math.Abs(price);
        }

        public Notebook(string model) //Перегрузка пользовательского конструктора, принимает 1 аргумент и вызывает конструктор принимающий 3 аргумента
            : this(model, "", 0)
        {
        }
        public Notebook(double price) //Перегрузка пользовательского конструктора, принимает 1 аргумент и вызывает конструктор принимающий 3 аргумента
            : this("", "", price)
        {
        }

        public void Show() //Метод отображения
        {
            Console.WriteLine("Модель {0} от {1} стоимостью {2}$", model, producer, price);
        }
    }
}
