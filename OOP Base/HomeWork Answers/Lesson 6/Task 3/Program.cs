using System;

namespace Task_3
{
    class Book
    {
        public class Note //Nested класс
        {
            string text = "";
            public string Text //Свойство для работы з полем text
            {
                get //Аксессор
                {
                    return text;
                }
                set //Мутатор
                {
                    if (text != "")
                        text += "\n";
                    text += value;
                }

            }
        }

        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }

    }

    static class FindAndReplaceManager //Статический метод
    {
        static public void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
        }
    }

    class Program
    {
        static void Main()
        {
            Book.Note note = new Book.Note(); //Создание екземпляра класса Note

            note.Text = "Good book"; //Обращение к мутатору свойства Text 
            note.Text = "I like it!";

            Console.WriteLine(note.Text); //Отображение значения поля text

            // Delay.
            Console.ReadKey();

        }
    }
}
