using System;

namespace AdHocPolimorfizm
{
    public class Class2 : AbsBaseClass
    {
        // ��������� ������������ ������.
        public override void AbsMeth()
        {
            Console.WriteLine("��������� ������������ ������ � Class2");
        }

        private int myVar = 222;
        // ��������� ������������ ��������.
        public override int AbsProp
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public override event Action AbstractEvent;

    }
}
