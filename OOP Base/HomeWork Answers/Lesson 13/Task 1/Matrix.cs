using System;
using System.Threading;

namespace Task_1
{
    class Matrix
    {
        static readonly object locker = new object();  //Объект синхронизации доступа к разделяемому ресурсу (объект блокировки)

        Random rand; //Создание екземпляра класса Random

        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; //Статическое строковое поле

        public int Colunm { get; set; } //Автоматическое свойство

        public Matrix(int col) //Пользовательский конструктор принимающий один целочисленный параметр
        {
            //Инициализация
            Colunm = col;
            rand = new Random((int)DateTime.Now.Ticks);
        }

        private char GetChar()//Метод возвращающий 
        {
            return litters.ToCharArray()[rand.Next(0, 35)]; //Возвращает оодно значение из строкового поля litters
        }

        public void Move()//Метод отображения одной цепочки
        {
            int lenght; 
            int count;
            while (true)
            {
                count = rand.Next(3, 6);//Метод возвращает случайное значение в указаном промежутке
                lenght = 0;
                Thread.Sleep(rand.Next(20, 5000)); //Останавливаем поток на время полученое выполнением метода rand.Next в указаном прромеж
                for (int i = 0; i < 40; i++) //Цикл со счетчиком
                {
                    lock (locker) //Блокирует блок кода, предназначен для контроля доступа к критической секции
                    {
                        Console.CursorTop = 0; //Устанавливае курсор в указанное положение
                        Console.ForegroundColor = ConsoleColor.Black; //Устанавливает цвет
                        for (int j = 0; j < i; j++)
                        {
                            Console.CursorLeft = Colunm; //Устанавливаем позицию столбца курсора
                            Console.WriteLine("█");
                        }
                        if (lenght < count)
                            lenght++;//Увеличение длинны цепочки
                        else
                            if (lenght == count) //Если длинна цепочки достигла требуемой обнуляем переменную count 
                                count = 0;

                        if (39 - i < lenght)
                            lenght--;//Уменьшение длинны цепочки по достижении нижней границы консоли
                        Console.CursorTop = i - lenght + 1;//Устанавливаем координату курсора от верхнего края консоли
                        Console.ForegroundColor = ConsoleColor.DarkGreen; 
                        for (int j = 0; j < lenght - 2; j++)
                        {
                            Console.CursorLeft = Colunm; //Устанавливаем позицию курсора в рядке
                            Console.WriteLine(GetChar()); //Вызов метода GetChar
                        }
                        if (lenght >= 2) //Для каждого второго символа в цепочке
                        {
                            Console.ForegroundColor = ConsoleColor.Green; //устанавливаем цвет
                            Console.CursorLeft = Colunm; //и позицию в столбце
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 1) //Для каждого первого символа в цепочке
                        {
                            Console.ForegroundColor = ConsoleColor.White; //Устанавливаем цвет
                            Console.CursorLeft = Colunm; //и позицию в столбце
                            Console.WriteLine(GetChar());
                        }
                        Thread.Sleep(20);
                    }
                }
            }
        }
    }
}
