using System;

namespace AdHocPolimorfizm
{
    public abstract class AbsBaseClass1
    {
        // (1)
        public abstract void AbstractMethod();

        // (2)
        // ����������� �����.
        public virtual void VirtualMethod()
        {
            Console.WriteLine("����������� ����� ������������ ������ AbsBaseClass1");
        }

        // (3) 
        // ������� �����.
        public void SimpleMethod()
        {
            Console.WriteLine("������� ����� ������������ ������ AbsBaseClass1");
        }
    }
}
