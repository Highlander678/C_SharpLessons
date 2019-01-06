namespace Task_3
{
    class Dictionary<TKey, TValue> //Пользовательская реализация словаря. TKey - тип ключей, TValue - тип значений
    {
        //Создание полей класса доступных только для чтения
        private readonly MyList<TKey> key; //Поле предназначеное для хранения ключей
        private readonly MyList<TValue> value; //Поле для хранения значений

        public Dictionary() //Конструктор по умолчанию
        {
            //Инициализация полей классов
            key = new MyList<TKey>();
            value = new MyList<TValue>();
        }

        public void AddToDictionary(TKey k, TValue v) //Метод добавления значений в словарь
        {
            key.Add(k);
            value.Add(v);
        }

        public string this[int index] //Индексатор
        {
            get
            {
                return key[index] + " " + value[index];
            }
        }

        public string this[TKey index] //Индексатор предназначенный для поиска по словарю
        {
            get
            {
                for (int i = 0; i < key.Count; i++)
                {
                    if ((string)(object)key[i] == (string)(object)index)
                    {
                        return "По ключу " + index.ToString().ToUpper() + " найдено значение: " + value[i].ToString().ToUpper();
                    }
                }
                return "По ключу " + index + " не найдено значения ";
            }
        }

        public int Lenght//Свойство предназначеное для возвражения количество записей словаря
        {
            get //Акссесор
            {
                return key.Count;
            }
        }

        public override string ToString() //Переопределенный метод ToString базового класса Object 
        {
            string stroka = string.Empty;
            for (int i = 0; i < key.Count; i++)
            {
                stroka += key[i] + " " + value[i] + "\n";
            }
            if (stroka != null)
                return stroka;
            return "В словаре нет значений.";
        }
    }
}
