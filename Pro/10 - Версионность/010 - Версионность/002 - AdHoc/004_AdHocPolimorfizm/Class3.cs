using System;

namespace AdHocPolimorfizm
{
    public class Class3 : AbsBaseClass
    {
        // ��������� ������������ ������.
        public override void AbsMeth()
        {
            Console.WriteLine("��������� ������������ ������ � Class3");
        }

        private int myVar = 333;
        // ��������� ������������ ��������.
        public override int AbsProp
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public override event Action AbstractEvent;

    }
}
