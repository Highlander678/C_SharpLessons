namespace Task_2
{
    public class MyList<T> : IMyList<T> //Параметризованный класс который реализует все возможности интерфейса IMyList
    {                                   //<T> - это указатель места заполнения типом
        private T[] array; //Создание массива с типом указателя места заполнения типом

        public MyList() //Конструктор по умолчанию
        {
            array = new T[0]; //инициализация массива array (в массиве будет пустой объект)  
        }

        public void Add(T a) //Метод добавления значения в массив
        {
            T[] tempArray = new T[array.Length + 1]; //Создание временного массива типа указателя места заполнения типом с розмерностью увеличеной на единицу
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i]; //Корирование элементов массива в временный массив
            }
            tempArray[array.Length] = a; //Добавление нового элемента в конец массива
            array = tempArray; //Присвоение переменной array ссылки на массив tempArray
        }

        public T this[int index] //Индексатор для поля array
        {
            get { return array[index]; }
        }

        public int Count //Метод вычисляющий длинну массива
        {
            get { return array.Length; }
        }

        public void Clear() //Метод очистки массива
        {
            array = new T[0];
        }

        public bool Contains(T item) //Метод-предикат для поиска элемента в массиве 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item) //С помощью условного оператора проверяем значение полученое в качестве параметров с элементами массива
                {
                    return true; //Если подходящий элемент найден возвращаем true
                }
            }
            return false; //Если подходящий элемент не найден возвращаем false
        }
        public override string ToString() //Переопределение медода ToString базового класса object 
        {
            string stroka = null; //Создание локальной переменной строкового типа
            for (int i = 0; i < array.Length; i++)
            {
                stroka += array[i] + " "; //Запись каждого элемента массива в локальную переменную
            }
            return "Размерность массива " + array.Length + " Элементы массива:" + stroka;
        }
    }
}
