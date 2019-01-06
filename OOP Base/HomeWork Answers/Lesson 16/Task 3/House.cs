using System;

namespace Task_3
{
    class House
    {
        //Создание закрытых полей класса
        private string city;
        private Street street;

        public House(Street street, string city) //Кользовательский конструктор
        {
            //Инициализация полей класса
            this.street = street;
            this.city = city;
        }

        public House Clone()
        {
            return this; // Поверхностное копирование
        }

        public House DeepClone()
        {
            return new House(this.street.Clone() as Street, this.City);//глубокое копирование
        }

        public Street Street //Свойтсво для образения к экземпляру классаStreet
        {
            get { return street; }
            set { street = value; }
        }

        public string City//Свойтсво для образения к переменной 
        {
            get { return city; }
            set { city = value; }
        }
    }

    class Street : ICloneable //класс Street реализирует интерфейс ICloneable
    {
        private string str;

        public Street(string s) //Пользовательский конструктор
        {
            str = s;
        }

        public string Str//Свойтсво для отображения значения
        {
            get { return str; }
        }

        public object Clone() //Реализация интерфейса ICloneable
        {
            return new Street(this.str);
        }
    }
}
