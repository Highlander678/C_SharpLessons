using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class AccountComparer : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            Account a1 = x as Account;
            Account b1 = y as Account;
            return a1.Number == b1.Number;
        }

        public int GetHashCode(object obj)
        {
            return (obj as Account).Number;
        }
    }

    class Account
    {
        public int Number { get; set; }
        public double Balance { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary coll = new OrderedDictionary(new AccountComparer());

            Account a1 = new Account() { Number = 1, Balance = 10000 };
            Account a2 = new Account() { Number = 2, Balance = 20000 };
            Account a3 = new Account() { Number = 3, Balance = 30000 };
            Account a4 = new Account() { Number = 3, Balance = 40000 }; //Ключ а4 будет равным ключу а3, т.к. объекты будут сравниваться по полю Number

            coll.Add(a1, "Company 1");
            coll.Add(a2, "Company 2");
            coll.Add(a3, "Company 3");

            try
            {
                coll.Add(a4, "Company 4"); //  Приводит к исключению, т.к. уже есть такой ключ.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Такой ключ уже существует");
                Console.WriteLine(ex.Message);
            }

            foreach (DictionaryEntry item in coll)
            {
                Console.WriteLine(item.Value);
            }

            Console.ReadKey();
        }
    }
}
