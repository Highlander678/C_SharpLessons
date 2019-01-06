using System.Collections.Generic;

namespace Task_2
{
    class MyList<T>//Пользовательская реализация параметризированной коллекции List<T>
    {
        T[] array = null;//Создание массива

        public MyList()//Контруктор по умолчанию
        {
            array = new T[0];
        }

        public int Count //Свойство возвращающее длинну коллекции
        {
            get
            {
                return array.Length;
            }
        }

        public void Add(T elem) //Метод добавления нового элементта в коллекцию
        {
            T[] arr = new T[array.Length + 1]; //Содание нового массива
            array.CopyTo(arr, 0); //Копирование элементов в новый массив
            arr[array.Length] = elem; //В конец нового массива записываем новый элемент
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

        public void Reset()//Метод возвращает в начало массива
        {
            position = -1;
        }

        public IEnumerator<T> GetEnumerator() //Перечислитель который возвращает элементы
        {
            while (true) //Бесконечный цикл
            {
                if (position < array.Length - 1)//Проверяем позицию в массиве 
                {
                    position++; //Инкрементируем 
                    yield return array[position];
                }
                else
                {
                    Reset(); //Вызов метода Reset
                    yield break;
                }
            }
        }
    }
}
