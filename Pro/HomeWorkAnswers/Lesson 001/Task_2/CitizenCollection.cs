using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    sealed class CitizenCollection : IEnumerable
    {
        //В System.Array уже есть реализация IEnumerator!
        Citizen[] elements;

        public Citizen this[int index]
        {
            get
            {
                if (Count > index && index >= 0)
                {
                    return elements[index];
                }
                return null;

            }
            //Метод set не реализовываем, чтобы исключить возможность замены одного человека в очереди на другого.
        }

        public int Count { get { return elements.Length; } }

        public CitizenCollection()
        {
            elements = new Citizen[0];
        }

        public void Clear()
        {
            elements = new Citizen[0];
        }

        public int Add(Citizen item)
        {
            int index;

            if (Contains(item, out index)) // Проверка на наличие добавляемого элемента в коллекции
            {
                return index;
            }

            var newArray = new Citizen[elements.Length + 1]; // Создание нового массива (на 1 больше старого).

            if (item as Pensioner == null) // ***Добавление не Пенсионера***
            {
                elements.CopyTo(newArray, 0); // Копирование старого массива в новый.
                newArray[newArray.Length - 1] = item; // Помещение нового значения в конец массива.
                index = newArray.Length - 1;
            }
            else // ***Добавление Пенсионера***
            {
                int indexOfPensioner = SearchIndexPensioner(); // Нахождение позиции вставляемого элемента
                Array.ConstrainedCopy(elements, 0, newArray, 0, indexOfPensioner); // Копирование элементов из старого массива до позиции вставляемого элемента
                newArray[indexOfPensioner] = item; // Вставка нового элемента на необходимую позицию
                // Копирование оставшихся элементов из старого массива
                Array.ConstrainedCopy(elements, indexOfPensioner, newArray, indexOfPensioner + 1, elements.Length - indexOfPensioner);
                index = indexOfPensioner;
            }

            elements = newArray; // Замена старого массива на новый.
            return index;
        }

        public void Remove()
        {
            var newArray = new Citizen[elements.Length - 1]; // Создание нового массива (на 1 меньше старого).
            Array.ConstrainedCopy(elements, 1, newArray, 0, newArray.Length);
            elements = newArray;
        }

        public void Remove(Citizen item)
        {
            int index;
            if (Contains(item, out index))
            {
                var newArray = new Citizen[elements.Length - 1];
                Array.ConstrainedCopy(elements, 0, newArray, 0, index);
                Array.ConstrainedCopy(elements, index + 1, newArray, index, newArray.Length - index);
                elements = newArray;
            }
        }

        public Citizen ReturnLast(out int index)
        {
            index = elements.Length - 1;
            return elements[index];
        }

        public bool Contains(Citizen item, out int index)
        {
            for (int i = 0; i < Count; i++)
            {
                if (elements[i] == item)
                {
                    index = i;
                    return true;
                }
            }
            index = -1;
            return false;
        }

        /// <summary>
        /// Находит индекс элемента следуещего за последним в очереди элементом типа Pensioner
        /// </summary>
        /// <returns></returns>
        private int SearchIndexPensioner()
        {
            int index = 0;
            while (elements.Length > index && elements[index] as Pensioner != null)
            {
                index++;
            }
            return index;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //В System.Array уже есть реализация IEnumerable! Делегируем вызов массиву.
            return elements.GetEnumerator();
        }
    }
}
