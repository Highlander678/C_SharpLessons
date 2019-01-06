using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store st = new Store(3); //Створення екземпляра класса st

            st.AddArticle(new Article("Book", "MackMilan", 20.50), 0); //Вызов метода AddArticle
            st.AddArticle(new Article("Apple", "Delight", 5.90), 1);
            st.AddArticle(new Article("Coca-Cola", "Fozzy", 7.25), 2);


            Console.WriteLine(st["Apple"]); //Отображения значений 
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(st["Dog"]);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(st[2]);
            Console.WriteLine(new string('-', 30));

            st.Show(); //Вызов метода отображения
            Console.WriteLine(new string('-', 30));

            st.Sort(); //Вызов метода сортировки
            st.Show(); //Вызов метода отображения

            // Delay.
            Console.ReadKey();
        }
    }
}
