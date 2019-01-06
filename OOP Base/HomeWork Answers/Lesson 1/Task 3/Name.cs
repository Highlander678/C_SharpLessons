using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    class Name
    {
        public string Text { set; get; }
        public Name()
        {
            Text = "Nameless";
        }
        public Name(string t)
        {
            Text = t;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Title: " + Text);
        }
    }
}
