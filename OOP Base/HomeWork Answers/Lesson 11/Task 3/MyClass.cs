namespace Task_3
{
    public interface IMyList<T> //параметризированный интерфейс
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }

    public class MyList<T> : IMyList<T> //параметризированный класс который наследуется от параметризированного интерфейс IMyList
    {
        private T[] array; //Массив объектов типа T

        public MyList() //Конструктор по умолчнию
        {
            array = new T[0];
        }

        public void Add(T a) //Метод добавления значений
        {
            T[] tempArray = new T[array.Length + 1];//создаем новый массив элементов типа указателя места заполнения типом длинной на единицу больше длинны массива array
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i]; //Копирование элементов массива array в новый массив
            }
            tempArray[array.Length] = a; //В конец массива tempArray записывается нужное значение
            array = tempArray;
        }

        public T this[int index] //Индексатор
        {
            get
            {
                return array[index];
            }
        }

        public int Count //Свойство возвращает длинну массива array
        {
            get { return array.Length; }
        }

        public void Clear() //Метод очистки массива
        {
            array = new T[0];
        }

        public bool Contains(T item) //Метод-предикат предназначенный для поиска элемента в массиве
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString() //Метод отображения значений массива
        {
            string stroka = null;
            for (int i = 0; i < array.Length; i++)
            {
                stroka += array[i] + " ";
            }
            return "Размерность массива " + array.Length + " Элементы массива:" + stroka;
        }
    }
}
