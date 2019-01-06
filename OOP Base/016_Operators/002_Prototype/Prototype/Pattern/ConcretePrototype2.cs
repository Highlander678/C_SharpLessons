using System;

namespace Prototype
{
    // "ConcretePrototype2"
    class ConcretePrototype2 : Prototype
    {
        // Конструктор.
        public ConcretePrototype2(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            // Глубокое копирование.
            return new ConcretePrototype2(this.Id);
        }
    }
}
