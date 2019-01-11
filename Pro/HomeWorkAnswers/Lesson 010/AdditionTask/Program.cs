using System;

namespace AdditionTask
{
    class BaseClass
    {
        protected virtual void DoWork()
        {
            Console.WriteLine("BaseClass");
        }

        public void GetWork()
        {
            DoWork();
        }
    }

    class DerivedClass : BaseClass
    {
        protected override void DoWork()
        {
            Console.WriteLine("DervedClass");
        }
    }
    class Program
    {
        static void Main()
        {
            BaseClass instance = new DerivedClass();

            instance.GetWork();
        }
    }
}
