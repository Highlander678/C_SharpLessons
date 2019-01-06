using System;

namespace Prototype
{
    // "Prototype"
    abstract class Prototype
    {
        // Поле.
        private string id;

        // Конструктор.
        public Prototype(string id)
        {
            this.id = id;
        }

        // Свойство.
        public string Id { get { return id; } }

        // Метод клонирования.
        public abstract Prototype Clone();
    }
}
