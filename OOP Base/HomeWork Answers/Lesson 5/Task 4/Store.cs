using System;

namespace Task_4
{
    class Store
    {
        private Article[] articls; //Создание экземпляра класса Article

        public Store(int size) //Пользовательский конструктор
        {
            articls = new Article[Math.Abs(size)]; //Инициализация переменной articls
        }

        public string this[int index] // Индексатор
        {
            get //Аксесор
            {
                if (index >= 0 && index < articls.Length)
                    return articls[index].Info();
                return "Попытка обращения за пределы массива.";
            }
        }

        public void AddArticle(Article value, int index) //Метод добавления значения в массив
        {
            if (index >= 0 && index < articls.Length)
                articls[index] = value;
            else
                Console.WriteLine("Попытка записи за пределами массива.");
        }

        public string this[string index] //Перегрузка индексатора
        {
            get
            {
                for (int i = 0; i < articls.Length; i++)
                    if (articls[i].Name == index)
                        return articls[i].Info(); //Возвращается результать выполмения метода Info класса Article

                return string.Format("\"{0}\" нет в наличии.", index);
            }
        }

        public void Show() //Метод отображения значений массива
        {
            for (int i = 0; i < articls.Length; i++)
                Console.WriteLine(articls[i].Info()); //Вызов метода отображения значений переменной articls 
        }

        public void Sort() //Метод сортировки (bubble sort)
        {
            for (int i = 0; i <= articls.Length - 1; i++)
            {
                for (int q = 0; q <= articls.Length - 1; q++)
                {
                    if (articls[i].Price <= articls[q].Price)
                    {
                        Article g = articls[i];
                        articls[i] = articls[q];
                        articls[q] = g;
                    }
                }
            }
        }

    }
}
