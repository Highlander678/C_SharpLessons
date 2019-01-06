using System;

namespace Task_4
{
    class Article
    {
        double price; //Создание поля

        public string Name { get; private set; } //Автоматическое свойство
        public string Shop { get; set; }

        public double Price //Свойство для работы с полем price
        {
            set //мутатор
            {
                if (value >= 0) //Проверка входного значения на положительность
                    price = value;
                else
                    Console.WriteLine("Стоимость не может быть отрицательной");
            }
            get //Аксесор
            {
                return price;
            }
        }

        public Article(string name) //Пользовательский конструктор
        {
            Name = name; //Инициализация поля класса
        }

        public Article(string name, string shop, double price) //Перегрузка пользовательского конструктора 
        {
            Name = name; //Инициализация полей класса
            Shop = shop;
            Price = price;
        }

        public string Info() //Метод отображения значений полей класса
        {
            return string.Format("{0} из {1} стоимость : {2} грн.", Name, Shop, Price);
        }
    }
}
