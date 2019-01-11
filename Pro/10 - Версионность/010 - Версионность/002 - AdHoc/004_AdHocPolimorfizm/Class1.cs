using System;

namespace AdHocPolimorfizm
{
    public class Class1 : AbsBaseClass
    {
        // Релизация абстрактного метода.
        public override void AbsMeth()
        {
            Console.WriteLine("Релизация абстрактного метода в Class1");
        }

        private int myVar = 111;
        // Релизация абстрактного свойства.
        public override int AbsProp
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public override int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public override event Action AbstractEvent;
    }
}
