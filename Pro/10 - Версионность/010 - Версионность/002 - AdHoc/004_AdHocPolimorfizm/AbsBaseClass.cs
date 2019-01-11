using System;

namespace AdHocPolimorfizm
{
    public abstract class AbsBaseClass
    {
        // (1)
        // Абстрактный метод
        public abstract void AbsMeth();
        
        // (2)
        // Виртуальный метод (Может быть перегружен в производных классах)
        public virtual void VirtMeth()
        {
            Console.WriteLine("Я Виртуальный метод Абстрактного класса AbsBaseClass");
        }

        // (3) 
        // Обычный метод в абстрактном классе
        public void SimpleMeth()
        {
            Console.WriteLine("Я Обычный метод Абстрактного класса AbsBaseClass");
        }

        // ПОЛЯ

        // ОШИБКА Не бывает абстрактных полей.
        //public abstract int field;

        // ОШИБКА Не бывает виртуальных полей.
        //public virtual string field = "Виртуальное поле";

        // Обычная переменная в абстрактном классе, наследуется производными классами.
        public int field = 777;


        // СВОЙСТВА

        // Абстрактное свойство.    [1]
        public abstract int AbsProp
        {
            get;
            set;
        }

        private int myVar2 = 888;

        // Виртуальное свойство.    [2]
        public virtual int VirtualProp
        {
            get { return myVar2; }
            set { myVar2 = value; }
        }

        protected int myVar = 000;

        // Простое свойство.        [3]
        public virtual int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public abstract event Action AbstractEvent;

        public virtual event Action VirtualEvent;
    }
}
