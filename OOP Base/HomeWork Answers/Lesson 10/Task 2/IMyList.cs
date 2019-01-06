namespace Task_2
{
    public interface IMyList<T> //Интерфейсы также могут быть параметризированными
    {
        void Add(T a); //Сигнатура параметризированного метода Add
        T this[int index] { get; } //Сигнатура индексатора
        int Count { get; } //Сигнатура свойства Count
        void Clear(); //Сигнатура метода Clear
        bool Contains(T item); //Сигнатура метода-предиката
    }
}

