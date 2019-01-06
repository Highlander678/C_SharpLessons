using System;

namespace Task_3
{
    class Employee
    {
        readonly string surname, name;   //Создание полей класса предназначеных только для чтения
        int experience;
        string post;

        //Свойство используется для получения значения из переменной surname и возвращает его в Surname
        public string Surname
        {
            get
            {
                return surname;
            }
        }

        //Свойство используется для получения значения из переменной Name и возвращает его в Name
        public string Name
        {
            get
            {
                return name;
            }
        }


        public string Post
        {
            get
            {
                if (post == null)
                    return "Должность неизвестна";
                return post;
            }
            set
            {
                if (value != null)
                {
                    post = value;
                }
            }
        }

        //Свойство для роботы с переменной experience
        public int Experience
        {
            //Используется для получения значения из переменной experience.
            get 
            { 
                return experience;
            }
            //Используется для записи значения в переменную.
            set
            {
                //В условной конструкции if проверяется значение если опыт больше или ровно нулю то experience присваивается значение value 
                if (value >= 0)
                {
                    experience = value;
                }
            }
        }

        //Конструктор по умолчанию
        public Employee()
        {
        }

        //Пользовательский конструктор
        public Employee(string surname, string name)
        {
            //Инициализация полей класса
            this.surname = surname;
            this.name = name;
        }

        //Метод вычисления заработной платы
        public double CountSalary()
        {
            double salarykoef;
            //В соответствии с должностью в переменную salarykoef вносится нужное значение
            //Метод ToLower  предназначен для перевода символов верхнего регистра в нижний регистр
            switch (post.ToLower())
            {
                case "manager": salarykoef = 200;
                    break;
                case "developer": salarykoef = 150;
                    break;
                case "secretary": salarykoef = 80;
                    break;
                case "cleaner": salarykoef = 65;
                    break;
                default: salarykoef = 100;
                    break;
            }

            //В соответсттвии значение поля experience вычисляется заработная плата
            switch (experience)
            {
                case 0: salarykoef *= 1.5;
                    break;
                case 1: salarykoef *= 2;
                    break;
                case 2: salarykoef *= 2.5;
                    break;
                default: salarykoef *= 5;
                    break;
            }
            //Возвращаем значение заработной плати
            return salarykoef;
        }

        //Метод используется для 
        public void ShowSalary()
        {
            Console.WriteLine("Зарплата {0}, подоходный налог {1}", CountSalary(), CountSalary() * 0.13);
        }
    }
}
