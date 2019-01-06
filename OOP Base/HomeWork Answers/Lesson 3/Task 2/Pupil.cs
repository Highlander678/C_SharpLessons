using System;

namespace Task_2
{
    //Базовый класс
    class Pupil
    {
        public virtual void Study()  //Ключевое слово virtual используется для разрешения переопределения в производном классе
        {
            Console.WriteLine("Pupil.Stydy()");//Отображение сообщения
        }
        public virtual void Read()
        {
            Console.WriteLine("Pupil.Read()");
        }
        public virtual void Write()
        {
            Console.WriteLine("Pupil.Write()");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Pupil.Relax()");
        }
    }

    //Класс ExcelentPupil производный класс базового класса Pupil
    class ExcelentPupil : Pupil
    {
        public override void Study() //Модификатор override требуется для расширения изменений виртуальной реализации унаследованного метода.
        {
            Console.WriteLine("ExcelentPupil.Stydy()");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil.Read()");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupil.Write()");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil.Relax()");
        }
    }

    //Класс GoodPupil производный класс базового класса Pupil
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil.Stydy()");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupil.Read()");
        }
        public override void Write()
        {
            Console.WriteLine("GoodPupil.Write()");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupil.Relax()");
        }
    }

    //Класс BadPupil производный класс базового класса Pupil
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil.Stydy()");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil.Read()");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil.Write()");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil.Relax()");
        }
    }
}
