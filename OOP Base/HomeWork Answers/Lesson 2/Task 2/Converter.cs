using System;

namespace Task_2
{
    class Converter
    {
        //Создание полей класса
        double usd, eur, rub;

        //Пользовательский конструктор
        public Converter(double usd, double eur, double rub)
        {
            //Инициализация полей класса
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        //Метод конвертирования денег из Гривны в Доллар
        public void ToUsd(double uahSum)
        {
            Console.WriteLine(uahSum / usd);
        }

        //Метод конвертирования денег из Доллара в Гривну
        public void FromUsd(double usdSum)
        {
            Console.WriteLine(usdSum * usd);
        }

        //Метод конвертирования денег из Гривны в Евро
        public void ToEur(double uahSum)
        {
            Console.WriteLine(uahSum / eur);
        }

        //Метод конвертирования денег из Евро в гривну
        public void FromEur(double eurSum)
        {
            Console.WriteLine(eurSum * usd);
        }

        //Метод конвертирования денег из Гривны в Рубли
        public void ToRub(double uahSum)
        {
            Console.WriteLine(uahSum / rub);
        }

        //Метод конвертирования денег из Рублей в Гривну
        public void FromRub(double rubSum)
        {
            Console.WriteLine(rubSum * usd);
        }
    }
}
