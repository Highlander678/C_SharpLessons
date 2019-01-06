using System.Collections.Generic;
using System.Collections;

namespace Task_4
{
    class MyList<T> : IEnumerable<T> //Пользовательская реализация коллекции список
    {
        T[] array = null; //Создае массив элементов типа T

        public MyList() //Конструктор по умолчанию
        {
            array = new T[0]; //Инициализируем массива пустым объектом
        }

        public int Count  //Свойство возвращающее длинну списка
        {
            get
            {
                return array.Length;
            }
        }

        public void Add(T elem) //Метод добавления нового элемента в список
        {
            T[] arr = new T[array.Length + 1];
            array.CopyTo(arr, 0);
            arr[array.Length] = elem;
            array = arr;
        }

        public T this[int index] //Индексатор
        {
            get
            {
                return array[index];
            }
        }

        int position = -1; //Поле которое сохраняет позицию 

        public void Reset() //Метод возвращает в начало массива
        {
            position = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
