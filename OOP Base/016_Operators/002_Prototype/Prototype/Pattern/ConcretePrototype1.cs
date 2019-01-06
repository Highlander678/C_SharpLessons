using System;

namespace Prototype
{
    // "ConcretePrototype1"
    class ConcretePrototype1 : Prototype
    {
        // Конструктор.
        public ConcretePrototype1(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            // Глубокое копирование.
            return new ConcretePrototype1(this.Id);
        }
    }
}
