using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<dynamic, dynamic> //dynamic - тип является статическим типом, но объект типа dynamic обходит проверку статического типа.
                               {
                                  {new {Key = "table"},    new {Value="стол"}}, //Добавление записей в словарь
                                  {new {Key = "apple"},    new {Value="яблоко"}},
                                  {new {Key = "pen"},      new {Value="ручка"}},
                                  {new {Key = "pencil"},   new {Value="карандаш"}},
                                  {new {Key = "task"},     new {Value="задание"}},
                                  {new {Key = "key"},      new {Value="ключ"}},
                                  {new {Key = "customer"}, new {Value="покупатель"}},
                                  {new {Key = "ship"},     new {Value="корабль"}},
                                  {new {Key = "car"},      new {Value="машина"}},
                                  {new {Key = "cap"},      new {Value="чашка"}}

                                  //{"table",   "стол"},
                                  //{"apple",    "яблоко"},
                                  //{"pen",      "ручка"},
                                  //{"pencil",   "карандаш"},
                                  //{"task",     "задание"},
                                  //{"key",      "ключ"},
                                  //{"customer", "покупатель"},
                                  //{"ship",     "корабль"},
                                  //{"car",      "машина"},
                                  //{"cap",      "чашка"}
                               };
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Value); //Отображение значений словаря
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
