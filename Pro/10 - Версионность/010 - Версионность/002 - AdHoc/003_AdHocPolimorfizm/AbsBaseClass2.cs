using System;

namespace AdHocPolimorfizm
{
    public abstract class AbsBaseClass2
    {
        // (1)
        public abstract void AbstractMethod();

        // (2)
        // ����������� �����.
        public virtual void VirtualMethod()
        {
            Console.WriteLine("����������� ����� ������������ ������ AbsBaseClass2");
        }

        // (3) 
        // ������� �����.
        public void SimpleMethod()
        {
            Console.WriteLine("������� ����� ������������ ������ AbsBaseClass2");
        }
    }
}
