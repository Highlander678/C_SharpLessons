using System.Collections;
using System.Collections.Generic;

namespace Dictionary
{
    //Пользовательская реализация словаря
    class MyDictionary<TKey, TValue> : IEnumerable<string> //Создание параметризированного класса который реализирует интерфейс IEnumerable закрытый типом string
    {
        //Создание закрытых полей класса
        private List<TKey> key;
        private List<TValue> value;

        public int Length //Свойство возвращающее длинну списка key
        {
            get { return key.Count; }
        }

        public MyDictionary()//Конструктор по умолчанию
        {
            key = new List<TKey>();
            value = new List<TValue>();
        }

        public void Add(TKey k, TValue v)//Метод добавления значения в словарь
        {
            key.Add(k);
            value.Add(v);
        }

        public TValue this[TKey index] //Индексатор предназначеный для поиска значения
        {
            get
            {
                for (int i = 0; i < key.Count; i++)
                {
                    if (key[i].Equals(index))
                        return value[i];
                }
                return default(TValue);
            }
        }

        public IEnumerator<string> GetEnumerator() //Реализация метода GetEnumerator интерфейса IEnumerator
        {
            while (true) //Бесконечный цикл
            {
                if (position < key.Count - 1) //Пока не достигнут конец списка
                {
                    position++;
                    yield return string.Format("{0} -> {1}", key[position], value[position]); //С помощью yield return возвращаем значения в виде строки
                }
                else
                {
                    position = -1;
                    yield break;
                }

            }
        }

        int position = -1;

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield break;
        }
    }
}