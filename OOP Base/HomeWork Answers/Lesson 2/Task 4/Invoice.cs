using System;

namespace Task_4
{
    class Invoice
    {
        //Создание и инициализация полей класса
        public readonly int account = 0;
        public readonly string customer = null;
        public readonly string provider = null;

        public string Article { get; set; } //Автоматическое свойство

        public int Quantity { get; set; } //Автоматическое свойство

        //Пользовательский конструктор
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void CostCalculation(bool needNds)
        {
            double cost;
            switch (Article)   //Оператор многозначного выбора
            {
                case "laptop": cost = 5400;
                    break;
                case "SD-cadr": cost = 30;
                    break;
                case "USB-hab": cost = 12;
                    break;
                default: Console.WriteLine("Нет ифформации о таком товаре");
                    return;
            }
            if (needNds)  //Условный оператор
            {
                cost = cost * 7 / 6;
            }
            Console.WriteLine("Cуммa оплаты: {0}$", cost * Quantity); //Вывод результата умножения переменных
        }
    }
}
