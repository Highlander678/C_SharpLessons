using System;

namespace AdHocPolimorfizm
{
    public abstract class AbsBaseClass3
    {
        // (1)
        public abstract void AbstractMethod();

        // (2)
        // ����������� �����.
        public virtual void VirtualMethod()
        {
            Console.WriteLine("����������� ����� ������������ ������ AbsBaseClass3");
        }

        // (3) 
        // ������� �����.
        public void SimpleMethod()
        {
            Console.WriteLine("������� ����� ������������ ������ AbsBaseClass3");
        }
    }
}
