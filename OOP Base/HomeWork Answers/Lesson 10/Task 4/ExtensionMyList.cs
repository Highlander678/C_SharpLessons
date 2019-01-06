namespace Task_4
{
    static class ExtensionMyList 
    {
        public static T[] GetArray<T>(this MyList<T> list) //Розширяющий метод копирующий элементы списка в массив
        {
            var temp = new T[list.Lenght]; //Создание локального массива
            for (int i = 0; i < list.Lenght; i++)
            {
                temp[i] = list[i]; //Копирование элементов в массив
            }
            return temp;
        }
    }
}
