using System;

namespace AdHocPolimorfizm
{
    public abstract class AbsBaseClass
    {
        // (1)
        // ����������� �����
        public abstract void AbsMeth();
        
        // (2)
        // ����������� ����� (����� ���� ���������� � ����������� �������)
        public virtual void VirtMeth()
        {
            Console.WriteLine("� ����������� ����� ������������ ������ AbsBaseClass");
        }

        // (3) 
        // ������� ����� � ����������� ������
        public void SimpleMeth()
        {
            Console.WriteLine("� ������� ����� ������������ ������ AbsBaseClass");
        }

        // ����

        // ������ �� ������ ����������� �����.
        //public abstract int field;

        // ������ �� ������ ����������� �����.
        //public virtual string field = "����������� ����";

        // ������� ���������� � ����������� ������, ����������� ������������ ��������.
        public int field = 777;


        // ��������

        // ����������� ��������.    [1]
        public abstract int AbsProp
        {
            get;
            set;
        }

        private int myVar2 = 888;

        // ����������� ��������.    [2]
        public virtual int VirtualProp
        {
            get { return myVar2; }
            set { myVar2 = value; }
        }

        protected int myVar = 000;

        // ������� ��������.        [3]
        public virtual int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public abstract event Action AbstractEvent;

        public virtual event Action VirtualEvent;
    }
}
