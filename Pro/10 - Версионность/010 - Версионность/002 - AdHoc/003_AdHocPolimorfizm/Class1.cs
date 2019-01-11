using System;

namespace AdHocPolimorfizm
{
    public class Class1 : AbsBaseClass1
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Class 1");
        }

        public override void VirtualMethod()
        {
            Console.WriteLine("Переопределенный Виртуальный метод класса Class1");
        }
    }
}
