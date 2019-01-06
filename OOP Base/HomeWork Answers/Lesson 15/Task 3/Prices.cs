using System;
using System.Linq;

namespace Task_3
{
    class PriceTable
    {
        struct Prices
        {
            //Створення полей структуры
            string shop;
            string number;
            uint? price;

            public string Shop
            {
                get { return shop; }
            }

            public string Number
            {
                get { return number; }
            }

            public uint? Price
            {
                get { return price; }
            }

            public Prices(string number, string shop, uint? price) //Пользовательский конструктор
            {
                this.shop = shop;
                this.price = price;
                this.number = number;
            }

            public string Show() //Метод возвразает строковое представление 
            {
                return string.Format("Товар № {0} из магазина {1} стоит {2}", number, shop, price);
            }
        }

        Prices[] product; //Создание массива екземпляров структруры Prices

        public PriceTable() //Конструктор по умолчанию
        {
            product = new Prices[2]; //Объявление массива из двух элементов
            string shop;
            string number;
            uint? price;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Введите номер товара");
                number = Console.ReadLine();

                Console.WriteLine("Введите магазин");
                shop = Console.ReadLine();

                Console.WriteLine("Введите цену");
                try //Попытка присвоить переменной price значения полученного от пользователя конвертированного в ToUInt32
                {
                    price = Convert.ToUInt32(Console.ReadLine());
                }
                catch (Exception e) //Обратока возможного исключения
                {
                    Console.WriteLine("Попытка записи неверного формата.");
                    Console.WriteLine(e.Message);
                    price = null;
                }
                product[i] = new Prices(number, shop, price); //В массив добавляется новый экземпляр Prices со значениями переданными в качестве аргументов конструктору
            }
            product = product.OrderBy(products => products.Number).ToArray<Prices>(); //Сортировка массива по полю Number
        }

        public string this[int index] //Индексатор
        {
            get
            {
                try
                {
                    return product[index].Show(); //Попытка отобразить содержимое массива
                }
                catch (Exception e)
                {
                    Console.WriteLine("Попытка обращения за пределы массива.");
                    Console.WriteLine(e.Message);
                    return "";
                }
            }
        }

        public string this[string index] //Индексатор для поиска значения по указаному номеру товара
        {
            get
            {

                try
                {
                    return product[Convert.ToInt32(index) - 1].Show(); //Попытка найти товар за указаным номером
                }
                catch (Exception e)
                {
                    Console.WriteLine("Попытка обращения за пределы массива.");
                    Console.WriteLine(e.Message);
                    return string.Format("\"{0}\" нет такого товара.", index);
                }
            }
        }

    }
}
