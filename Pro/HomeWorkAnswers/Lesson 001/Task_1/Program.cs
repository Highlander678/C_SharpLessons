using System;
using System.Collections;

namespace Task_1
{
    class Calendar : IEnumerable, IEnumerator
    {
        int[] month = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] day = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        int position = -1;

        public object Current
        {
            get { return month[position] + " - " + day[position]; }
        }

        public bool MoveNext()
        {
            if (position < month.Length - 1)
            {
                position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public string GetMonthByDays(int days)
        {
            string months = string.Empty;

            for (int i = 0; i < day.Length; i++)
            {
                if (day[i] == days)
                {
                    months += month[i] + " - " + day[i] + "\n";
                }
            }

            return months;
        }

        public string GetDaysByMonth(int months)
        {
            string mounths = string.Empty;

            for (int i = 0; i < month.Length; i++)
            {
                if (month[i] == months)
                {
                    mounths += month[i] + " - " + day[i] + "\n";
                }
            }

            return mounths;
        }
    }

    class Program
    {
        static void Main()
        {
            Calendar calendar = new Calendar();

            foreach (var item in calendar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 10));
            Console.WriteLine(calendar.GetDaysByMonth(5));

            Console.WriteLine(new string('-', 10));
            Console.WriteLine(calendar.GetMonthByDays(30));

            Console.ReadKey();
        }
    }
}
