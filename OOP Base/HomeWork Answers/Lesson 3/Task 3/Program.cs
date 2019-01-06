using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            //Создание екземпляра класса Ship с передачей пользовательскому конструктору значений
            Ship ship = new Ship(20000, 120, 2000)
            {
                //Присвоение полям класса значений (блок инициализации)
                Passengers = 28,
                Port = "Севастополь" 
            };

            Console.WriteLine("Цена корабля {0}, скорость {1}, год выпуска {2}, количество пасажиров {3}, порт приписки {4}",ship.Price,ship.Speed,ship.Year, ship.Passengers, ship.Port);

            // Delay.
            Console.ReadKey();
        }
    }
}
