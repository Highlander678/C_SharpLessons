using System;

namespace Task_2
{
    class ClassRoom
    {
        //Создание екземпляра класса Random
        Random rand = new Random();
        Pupil[] pupils = new Pupil[4];

        //Пользовательский конструктор принимающий экземпляры класса Pupil
        public ClassRoom(Pupil p0, Pupil p1)
        {
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = GeneratePupil();//Вызов метода генерирующего новый экземпляр класса Pupil
            pupils[3] = GeneratePupil();
        }

        //Перегрузка пользовательского конструктора принимающего экземпляры класса Pupil
        public ClassRoom(Pupil p0, Pupil p1, Pupil p2)
        {
            pupils[0] = p0; //Заполение массива значениями
            pupils[1] = p1;
            pupils[2] = p2;
            pupils[3] = GeneratePupil();
        }
        //Перегрузка пользовательского конструктора принимающего экземпляры класса Pupil
        public ClassRoom(Pupil p0, Pupil p1, Pupil p2, Pupil p3)
        {
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = p2;
            pupils[3] = p3;
        }

        //Закрытый метод класса
        private Pupil GeneratePupil()
        {
            int r = rand.Next(1, 4); //Получение случайного значение от 1 до 4 методом Next на экземпляре rand класса Random
            
            switch (r)  //Оператор многозначного выбора
            {
                case 1: return new ExcelentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();  //обращение к конструтору по умолчанию
            }
            return new BadPupil();
        }

        public void Study()
        {
            foreach (Pupil p in pupils)
            {
                p.Study(); //пример полиморфизма
            }
        }
        public void Write()
        {
            foreach (Pupil p in pupils)
            {
                p.Write();
            }
        }
        public void Read()
        {
            foreach (Pupil p in pupils)
            {
                p.Read();
            }
        }
        public void Relax()
        {
            foreach (Pupil p in pupils)
            {
                p.Relax();
            }
        }

    }
}
