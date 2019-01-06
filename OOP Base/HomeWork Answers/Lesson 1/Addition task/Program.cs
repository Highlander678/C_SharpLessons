using System;

// Задание
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Требуется: 
// Создать класс с именем Address.
// В теле класса, требуется создать поля: index, country, city, street, house, apartment.  
// Для каждого поля, создать свойство с двумя методами доступа. 
// Создать экземпляр класса Address. 
// В поля экземпляра записать информацию о почтовом адресе. 
// Выведите на экран значения полей описывающих адрес.

namespace Lessons_1
{
    //Создание класса Address с полями index, country, city, street, house, apartment.
    class Address
    {
        // Переменные, над которыми нет смысла производить арифметических операций,
        // следует создавать с типом string. (Например: index, или год рождения...)

        //Поле строкового типа с модификатором доступа private. Доступ к закрытым членам можно получить только внутри тела класса.
        private string index;

        //Создание свойства с модификатором доступа public. Public доступ является уровнем доступа с максимальными правами. Ограничений доступа не существует.
        public string Index
        {
            //Метод доступа get–используется для получения значения из переменной.
            get { return index; }
            //Метод доступа set-используется для записи значения в переменную.
            set { index = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private string house;
        public string House
        {
            get { return house; }
            set { house = value; }
        }

        private string apartment;
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
    class Program
    {
        static void Main()
        {
            //Создание экземпляра класса по сильной ссылке.
            Address address = new Address();

            //Обращение к свойству Country класса Address и вызов метода 'set' для присвоения значения.
            address.Country = "Ukraine";
            address.City = "Kiev";
            address.Street = "Khreshchatyk Street";
            address.House = "1";
            address.Apartment = "1";
            address.Index = "11111";

            //С помощью метода Console.WriteLine обращение к свойству Country класса Address и вызов метода 'get' для отображения значения.
            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);
            Console.WriteLine(address.Index);

            //Delay.
            Console.ReadKey();
        }
    }
}
