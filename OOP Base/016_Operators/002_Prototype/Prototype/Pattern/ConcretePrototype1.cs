using System;

namespace Prototype
{
    // "ConcretePrototype1"
    class ConcretePrototype1 : Prototype
    {
        // �����������.
        public ConcretePrototype1(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            // �������� �����������.
            return new ConcretePrototype1(this.Id);
        }
    }
}
