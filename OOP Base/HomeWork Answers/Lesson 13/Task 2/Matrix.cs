using System;
using System.Threading;

namespace Task_2
{
    class Matrix
    {
        static object locker = new object();//Объект синхронизации доступа к разделяемому ресурсу (объект блокировки)

        Random rand;//Создание екземпляра класса Random

        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";//Статическое строковое поле

        public int Colunm { get; set; } //Автоматическое свойство

        public bool NeedSecond { get; set; }

        public Matrix(int col, bool needSecond) //Пользовательский конструктор
        {
            //Инициализация полей класса
            Colunm = col;
            rand = new Random((int)DateTime.Now.Ticks);
            NeedSecond = needSecond;
        }

        private char GetChar() //Метод получения случайного значния из строки litters
        {
            return litters.ToCharArray()[rand.Next(0, 35)];
        }

        public void Move()
        {
            int lenght;
            int count;

            while (true) //бесконечный цикл
            {
                count = rand.Next(3, 12); //Определяем длинну цепочки
                lenght = 0;
                Thread.Sleep(rand.Next(20, 5000));//Остонавливаем поток на случайное время
                for (int i = 0; i < 40; i++)
                {
                    lock (locker)//Блокирует блок кода, предназначен для контроля доступа к критической секции
                    {
                        //  Console.CursorTop = 0;

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.CursorTop = i - lenght; //Устанавливаем строку в которой нужно отобразить символ
                        for (int j = i - lenght - 1; j < i; j++)
                        {
                            Console.CursorLeft = Colunm; //Устанавливаем позицию курсора в столбце 
                            Console.WriteLine("█");
                        }

                        if (lenght < count)
                            lenght++;//Увеличение длинны цепочки
                        else
                            if (lenght == count)
                                count = 0;//Если длинна цепочки достигла требуемой обнуляем переменную count 
                        if (NeedSecond && i < 20 && i > lenght + 2 && (rand.Next(1, 5) == 3))
                        {
                            new Thread((new Matrix(Colunm, false)).Move).Start(); //В новом потоке вызываем метод Move
                            NeedSecond = false;
                        }

                        if (39 - i < lenght)
                            lenght--; //Уменьшение длинны цепочки по достижении нижней границы консоли
                        Console.CursorTop = i - lenght + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < lenght - 2; j++) //отображаем элементы цепочки которые идут после 2го элемнта 
                        {
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 2)//Для каждого второго символа в цепочке
                        {
                            Console.ForegroundColor = ConsoleColor.Green; //устанавливаем цвет
                            Console.CursorLeft = Colunm;//и позицию в столбце
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 1)//Для каждого первого символа в цепочке
                        {
                            Console.ForegroundColor = ConsoleColor.White; //устанавливаем цвет
                            Console.CursorLeft = Colunm;//и позицию в столбце
                            Console.WriteLine(GetChar());
                        }

                        Thread.Sleep(10);
                    }
                }
            }
        }
    }
}
