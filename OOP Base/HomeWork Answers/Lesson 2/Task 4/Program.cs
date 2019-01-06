using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            //Создание екземпляра класса inv класса Invoice
            Invoice inv = new Invoice(678904, "Alex", "Foxtrot") {Article = "USB-hab", Quantity = 6};

            inv.CostCalculation(true); //Вызов метода CostCalculation
            inv.CostCalculation(false);

            //Delay
            Console.ReadKey();
        }
    }
}
