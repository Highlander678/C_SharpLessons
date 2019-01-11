﻿using System;

namespace AttributeWork
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    class MyAttribute : System.Attribute
    {
        private readonly string date;
        public string Date
        {
            get { return date; }
        }

        public MyAttribute(string date)
        {
            this.date = date;
        }

        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}