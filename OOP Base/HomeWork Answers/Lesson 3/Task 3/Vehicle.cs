using System;

namespace Task_3
{
    class Vehicle
    {
        readonly int xLocation; //Создание переменной предназначеной только для чтения
        public int XLocation
        {
            get { return xLocation; } //Вывод значения переменной xLocation
        }

        readonly int yLocation;
        public int YLocation
        {
            get { return yLocation; } //Вывод значения переменной yLocation
        }

        readonly uint price;
        public uint Price
        {
            get { return price; } //Вывод значения переменной price
        }

        readonly uint speed;
        public uint Speed
        {
            get { return speed; } //Вывод значения переменной speed
        }

        readonly uint year;
        public uint Year
        {
            get { return year; }  //Вывод значения переменной year
        }

        //Пользовательский конструктор принимающий 2 целых числа со знаком (int) и 3 без знака (uint)
        public Vehicle(int xLocation, int yLocation, uint price, uint speed, uint year)
        {
            //Инициализация переменных класса
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        //Перегрузка пользовательского конструктора который принемает 3 целых числа без знака и вызывает конструктор своего класса
        public Vehicle(uint price, uint speed, uint year)
            :this(0,0, price,  speed,  year)
        {
            
        }
    }

    //Производный класс Car от базового класса Vehicle
    class Car : Vehicle
    {
        //Пользовательский конструктор принимающий 2 целых числа со знаком и 3 без знака, и  вызывает конструктор базового класса
        public Car(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }
        //Перегрузка пользовательского конструктора принимающий 3 целых числа без знака, и  вызывает конструктор базового класса
        public Car(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }
    }

    //Производный класс Ship от базового класса Vehicle
    class Ship : Vehicle
    {
        //Пользовательский конструктор принимающий 2 целых числа со знаком и 3 без знака, и  вызывает конструктор базового класса
        public Ship(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }
        //Перегрузка пользовательского конструктора принимающий 3 целых числа без знака, и  вызывает конструктор базового класса
        public Ship(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }
        private int passengers;
        public int Passengers
        {
            get { return passengers; } //Получение значения из переменной passengers
            set //запись значения в переменную
            {
                if (passengers < 0)
                {
                    Console.WriteLine("Количетво пасажиров не может быть отрицательным");
                }
                else
                {
                    passengers = value; //Запись значения
                }
            }
        }

        private string port;
        public string Port
        {
            get
            {
                //Условный оператор сравнивает значение переменной port и null.
                if (port == null)
                    return "Порт не задан";
                return port;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Значение пустое");
                }
                else
                {
                    port = value;
                }
            }
        }
    }

    //Производный класс Plane от базового класса Vehicle
    class Plane : Vehicle
    {
        //Пользовательский конструктор принимающий 2 целых числа со знаком и 3 без знака, и  вызывает конструктор базового класса
        public Plane(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }
        //Перегрузка пользовательского конструктора принимающий 3 целых числа без знака, и  вызывает конструктор базового класса
        public Plane(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }

        public int Hight { get; set; }

        private int passengers;
        public int Passengers
        {
            get { return passengers; }
            set
            {
                if (passengers < 0)
                {
                    Console.WriteLine("Количетво пасажиров не может быть отрицательным");
                }
                else
                {
                    passengers = value;
                }
            }
        }
    }
}
