using System;

namespace Task_2
{
    struct Worker
    {
        //Поля класса
        int year;
        string name;
        string post;

        public string Name //Свойство возвращающее значение поля name
        {
            get
            {
                return name;
            }
        }

        public string Post//Свойство возвращающее значение поля post
        {
            get
            {
                return post;
            }
        }

        public int Year //Свойство для обращения к полю year
        {
            get //Аксессор
            {
                return year;
            }
            set //Мутатор
            {
                if (value <= DateTime.Now.Year && DateTime.Now.Year - value <= 50) //Если полученное значение меньше текущей даты и результат вычитания текущей даты и полученного значения равен не больше 50
                {
                    year = value; //Записываем значение
                }
                else //Если хоть одно из условий не истинно 
                {
                    Console.WriteLine("Неверно задан год! Повторите");
                    Year = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public int Experience() //Метод возвращающий возраст
        {
            return DateTime.Now.Year - year;
        }

        public Worker(string name, string post, int year) //Пользовательский конструктор
        {
            this.year = DateTime.Now.Year;
            this.name = name;
            this.post = post;
            this.Year = year;
        }
    }
}
