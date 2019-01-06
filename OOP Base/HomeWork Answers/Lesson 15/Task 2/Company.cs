using System;
using System.Linq;

namespace Task_2
{
    class Company
    {
        Worker[] staff; //Создание массива объектов класса Worker

        public Company() //Конструктор по умолчанию
        {
            //Создзание локальных переменных
            string name;
            string post;
            int year;
            string tmp;

            staff = new Worker[5]; //Инициализация массива из 5 обектов класса Worker

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите имя сотрудника");
                name = Console.ReadLine();

                Console.WriteLine("Введите должность");
                post = Console.ReadLine();

                Console.WriteLine("Введите год начала работы ");
                tmp = Console.ReadLine();

                try //Попытка конвертировать полученое значение в ToInt32
                {
                    year = Convert.ToInt32(tmp);
                }
                catch (Exception e) //Обработка исключения
                {
                    Console.WriteLine("Вы ввели недопустимое значение года.");
                    Console.WriteLine(e.Message);
                    year = DateTime.Now.Year; //В переменную записывем значение текущего года
                }

                staff[i] = new Worker(name, post, year); //Добавление в массив нового екземпляра класса
                Console.Clear(); //Очистка консоли
            }
            staff = staff.OrderBy(worker => worker.Name).ToArray<Worker>(); //Сортировка записей по полю Name
        }

        public string this[int index] //Индексатор для отображения сотрудников с определенным стажем работы
        {
            get
            {
                string answer = ""; //Локальная переменная
                for (int i = 0; i < staff.Length; i++)
                {
                    if (staff[i].Experience() > index)//Проверка значения поля Experience каждого работника и значения index
                    {
                        answer += "Фамилия работника " + staff[i].Name + "\n";
                    }

                }
                if (answer.Length >= 0)
                {
                    return answer;
                }
                return "Нет сотрудников с таким стажем работы";
            }
        }
    }
}
