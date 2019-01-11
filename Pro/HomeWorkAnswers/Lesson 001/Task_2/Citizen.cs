using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class Citizen
    {
        public string Passport { get; protected set; }
        public string FName { get; protected set; }
        public string LName { get; protected set; }
        public string FullName
        {
            get { return string.Format("{0} {1}", FName, LName); }
        }

        public Citizen(string fName, string lName, string passport)
        {                      // Удаление пробелов и приведение строки в нижний регистр
            Passport = passport.Replace(" ", string.Empty).ToLower();
            FName = fName;
            LName = lName;
        }

        #region Переопределение операторов равенства
        public static bool operator ==(Citizen a, Citizen b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Passport == b.Passport;
        }

        public static bool operator !=(Citizen a, Citizen b)
        {
            return !(a == b);
        }
        #endregion
    }

    class Student : Citizen
    {
        public Student(string fName, string lName, string passport)
            : base(fName, lName, passport) { }
    }
    class Worker : Citizen
    {
        public Worker(string fName, string lName, string passport)
            : base(fName, lName, passport) { }
    }
    class Pensioner : Citizen
    {
        public Pensioner(string fName, string lName, string passport)
            : base(fName, lName, passport) { }
    }
}
