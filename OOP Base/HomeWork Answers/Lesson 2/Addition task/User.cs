using System;

namespace Lessons_2
{
    class User
    {
        string login, name, surname;
        int age;
        public readonly DateTime date;

        //Свойство для работы с переменной login
        public string Login
        {
            //Используется для получения значения из переменной login.
            set 
            {
                login = value;
            }
            //Используется для записи значения в переменную.
            get
            {
                //Проверка заполненности переменной
                if (login == null)
                    return "Поле не заполнено";
                return login;
            }
        }
        //Свойство для работы с переменной Name
        public string Name
        {
            set { name = value; }
            get
            {
                if (name == null)
                    return "Поле не заполнено";
                return name;
            }
        }

        //Свойство для работы с переменной Surname
        public string Surname
        {
            set { surname = value; }
            get
            {
                if (surname == null)
                    return "Поле не заполнено";
                return surname;
            }
        }

        //Свойство для работы с переменной Age
        public int Age
        {
            set { age = value; }
            get
            {
                if (age <= 0)
                    return 25;
                return age;
            }
        }

        //Конструктор по умолчанию
        public User()
        {
            //Инициализация поля класса
            date = DateTime.Now;
        }

        //Пользовательский конструктор
        public User(string login, string name, string surname, int old)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = old;
            date = DateTime.Now;
        }

    }
}
