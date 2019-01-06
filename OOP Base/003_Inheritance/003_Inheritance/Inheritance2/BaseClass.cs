using System;

// Наследование.

namespace Inheritance
{
    class BaseClass
    {
        // Поля
        BaseClass inner = null;
        public string publicField = "BaseClass.publicField";
        private string privateField = "BaseClass.privateField";
        protected string protectedField = "BaseClass.protectedField";

        // Методы

        public void Show()
        {
            Console.WriteLine(privateField);
        }

        private void Show1()
        {
            Console.WriteLine("Печатаем из private метода");
        }
        public void Show_Show1()
        {
            
            inner = new BaseClass();
            inner.Show1();
       
        }
    }
}
