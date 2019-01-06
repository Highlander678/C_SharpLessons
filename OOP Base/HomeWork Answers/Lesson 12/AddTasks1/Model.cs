using System;

// Model

namespace AddTask1
{    
    class Model
    {
        public string Logic(string s) //Открытый метод Logic который принимает параметр строкового типа и возвращает переменную строкового типа
        {
            return string.Format("Работа: Model.Logic({0})", s);
        }
    }
}
