using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            //var - анонимный тип
            var listAuto = new List<Auto> //Создание списка типа Auto
                               {
                                   new Auto("Fiat", "Bravo", 2005, "red"), //Заполнение списка значениями
                                   new Auto("Mersedes", "E", 2010, "black"),
                                   new Auto("Skoda", "Fabia", 2009, "yellow"),
                                   new Auto("Mersedes","A", 2009, "grey")
                               };

            foreach (var auto in listAuto)
            {
                Console.WriteLine(auto.ToString()); //Отображение содержимого listAuto
            }

            Console.WriteLine(new string('-', 30));

            var listCustomer = new List<Customer> //Создание списка типа Customer
                                   {
                                       new Customer( "Petrov","Mersedes", "0509864578"),//Заполнение списка значениями
                                       new Customer( "Ivanov", "Fiat", "0509876545"),
                                       new Customer( "Vasiliev", "Skoda", "0504789863")
                                   };

            foreach (var customer in listCustomer)
            {
                Console.WriteLine(customer.ToString()); //Отображение содержимого listCustomer
            }

            Console.WriteLine(new string('-', 30));

            var query = from auto in listAuto
                        select new { Marka = auto.Marka, Color = auto.Color }; //Создание LINQ запроса на выборку определенных данных

            foreach (var item in query)
            {
                Console.WriteLine("Марка авто: {0}  - {1}", item.Marka, item.Color);
            }

            Console.WriteLine(new string('-', 30));

            var query1 = from customer in listCustomer //Создание LINQ запроса
                         join auto in listAuto on customer.Model equals auto.Marka //объединение данных по указаному ключу
                         select new //Выбрать в выборку только указанные данные
                         {
                             Name = customer.Name,
                             Tel = customer.Tel,
                             Model = customer.Model,
                             Color = auto.Color,
                             Marka = auto.Model,
                             Year = auto.Year
                         };

            Console.WriteLine(new string('-', 30));

            foreach (var item in query1)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Name, item.Tel, item.Model, item.Marka, item.Color, item.Year); //Отображение данных
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
