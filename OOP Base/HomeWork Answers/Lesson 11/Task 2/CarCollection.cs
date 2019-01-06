using System;

namespace Task_2
{
    class CarCollection<T> : MyList<T> //параметризированная коллекция которая наследуется от базового класса MyList
    {
        //Создание полей класса доступных только для чтения
        private readonly MyList<string> carName; //Создание экземпляра класса MyList и закрвываем его типом string
        private readonly MyList<DateTime> carYear; //Создание экземпляра класса MyList и закрвываем его типом DateTime

        public CarCollection() //Конструктор по умолчанию
        {
            //Инициализация полей класса
            carName = new MyList<string>(); 
            carYear = new MyList<DateTime>();
        }

        public void AddCar(string name, DateTime year) //Метод добавления значений
        {
            carName.Add(name); //Вызов метода Add класса MyList для добавления значения
            carYear.Add(year);
        }

        public new string this[int index] //Индексатор
        {
            get
            {
                if (index < carName.Count)
                    return carName[index] + " " + carYear[index].Year + " г";
                return "В списке нет машины под таким номером!";
            }
        }

        public int Lenght //Свойство возвращающее количество значений
        {
            get
            {
                return carName.Count;
            }
        }

        public void Remove() //Метод очистки коллекции
        {
            carName.Clear();
            carYear.Clear();
        }

        public override string ToString() //Метод отображения содержимого
        {
            string stroka = null;
            for (int i = 0; i < carName.Count; i++)
            {
                stroka += "№" + (i + 1) + " " + carName[i] + " " + carYear[i].Year + " г \n";
            }
            if (stroka != null) return stroka;
            return "В парке нет ни одной машины!";
        }
    }
}
