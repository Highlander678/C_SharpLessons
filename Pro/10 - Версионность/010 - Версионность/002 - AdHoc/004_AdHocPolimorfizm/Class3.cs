using System;

namespace AdHocPolimorfizm
{
    public class Class3 : AbsBaseClass
    {
        // Релизация абстрактного метода.
        public override void AbsMeth()
        {
            Console.WriteLine("Релизация абстрактного метода в Class3");
        }

        private int myVar = 333;
        // Релизация абстрактного свойства.
        public override int AbsProp
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public override event Action AbstractEvent;

    }
}
