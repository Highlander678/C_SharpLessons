namespace Task_4
{
    class MyList<T> //Пользовательская реализация класса List<T>
    {
        ////Приватные поля доступные только для чтения
        private readonly int lenght; //Длинна списка
        private readonly T[] arr; //Массив значений

        public int Lenght //Свойство для роботы с полем lenght
        {
            get //Аксессор
            {
                return lenght;
            }
        }

        public MyList(int n) //Пользовательский конструктор
        {
            //Инициализация полей класса
            arr = new T[n]; 
            lenght = arr.Length;
        }

        public T this[int i] //Индексатор
        {
            get //Акссесор
            {
                return arr[i];
            }
        }

        public void Add(int i, T k) //Метод добавления записи в список
        {
            arr[i] = k;
        }
    }
}
