using System;

namespace AdHocPolimorfizm
{
    public abstract class AbsBaseClass2
    {
        // (1)
        public abstract void AbstractMethod();

        // (2)
        // Виртуальный метод.
        public virtual void VirtualMethod()
        {
            Console.WriteLine("Виртуальный метод Абстрактного класса AbsBaseClass2");
        }

        // (3) 
        // Обычный метод.
        public void SimpleMethod()
        {
            Console.WriteLine("Обычный метод Абстрактного класса AbsBaseClass2");
        }
    }
}
