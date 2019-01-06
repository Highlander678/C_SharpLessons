using System.Collections;
using System.Collections.Generic;

namespace Task_3
{
    class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object> //Пользовательская реализация коллекции словарь
    {
        //Поля доступные только для чтения
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int lenght;

        int position = -1;

        #region Свойство длинны коллекции
        public int Lenght
        {
            get { return lenght; }
        }
        #endregion

        #region Ctor
        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            lenght = n;
        }
        #endregion

        #region Индексатор
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "Попытка обращения за пределы массива.";
            }
        }
        #endregion

        #region Метод добавления пары ключ-значение в коллекцию
        public void Add(int i, TKey k, TValue l)
        {
            key[i] = k;
            value[i] = l;
        }
        #endregion

        #region Реализация интерфейса IEnumerator<T>
        public bool MoveNext() 
        {
            if (position < key.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return key[position] + " " + value[position]; }
        }

        object IEnumerator.Current
        {
            get { return key[position] + " " + value[position]; }
        }
        #endregion

        #region Реализация интерфейса IEnumerable<T>

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }

        #endregion
    }
}
