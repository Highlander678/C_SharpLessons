namespace Task_4
{
    class MyArrayList
    {
        private object[] array; //Создание массива объектов типа object

        public MyArrayList() //Конструктор по умолчанию
        {
            array = new object[0]; //Инициализация массива пустым объектом
        }

        public void Add(object a) //Метод добавления значения
        {
            object[] tempArray = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = a;
            array = tempArray;
        }

        public object this[int index]//Индексатор
        {
            get
            {
                return array[index];
            }
        }

        public int Count //Свойство для возвращения количества элементов в массиве
        {
            get //Аксессор
            {
                return array.Length;
            }
        }

        public void Clear() //Метод очистки массива 
        {
            array = new object[0];
        }

        public bool Contains(object item) //Метод-предикат предназначеный для поиска элемента в массиве
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item) //Сравнение элементов массива с параметром item
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString() //Переопределенный метод ToString базового класса object
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
