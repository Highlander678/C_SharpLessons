
namespace Lessons_5
{
    class Dictionary
    {
        //Создание полей класса
        private string[] key = new string[5];
        private string[] ENG = new string[5];
        private string[] UA = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; UA[0] = "книга"; ENG[0] = "book"; //инициализация полей класса
            key[1] = "ручка"; UA[1] = "ручка"; ENG[1] = "pen";
            key[2] = "солнце"; UA[2] = "сонце"; ENG[2] = "sun";
            key[3] = "яблоко"; UA[3] = "яблуко"; ENG[3] = "apple";
            key[4] = "стол"; UA[4] = "стіл"; ENG[4] = "table";
        }

        public string this[int index] // Индексатор
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + UA[index] + " - " + ENG[index];
                return "Попытка обращения за пределы массива.";
            }
        }

        public string this[string index] //Перегрузка индексатор
        {
            get
            {
                for (int i = 0; i < key.Length; i++)//key.Length - вычисление длинны массива
                {
                    if (key[i] == index)
                        return key[i] + " - " + UA[i] + " - " + ENG[i]; //Возвращение значений в строковом представлении
                    if (UA[i] == index)
                        return UA[i] + " - " + key[i] + " - " + ENG[i];
                    if (ENG[i] == index)
                        return ENG[i] + " - " + key[i] + " - " + UA[i];
                }

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }
    }
}
