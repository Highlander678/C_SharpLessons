
// Наследование.

namespace Inheritance
{
    class BaseClass
    {
        private int basenumber;
        public int Basenumber {
            get { return basenumber; }
            set { }
        }
        // Конструктор по умолчанию.
        public BaseClass() 
        {
        }

        // Пользовательский конструктор.
        public BaseClass(int number)
        {
            this.basenumber = number;
        }
    }
}
