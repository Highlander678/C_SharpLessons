using System;

class MyClass //Класс
{
    public string change;
}

struct MyStruct //Струкрура
{
    public string change;
}

class Program
{
    static void ClassTaker(MyClass c) //Статический метод для внесения изменений в поле класса change
    {
        c.change = "изменено";
    }

    static void StructTaker(MyStruct s) //Статический метод для внесения изменений в поле структуры change
    {
        s.change = "изменено";
    }

    static void Main()
    {
        MyClass testClass = new MyClass(); //Создание екземпляра класса
        MyStruct testStruct = new MyStruct(); //Создание структуры на куче

        testClass.change = "не изменено"; //Запись в поле change
        testStruct.change = "не изменено"; //Запись в поле change

        ClassTaker(testClass); //Вызов метода ClassTaker и передача в качестве аргумента ссылки на класс
        StructTaker(testStruct); //Вызов метода StructTaker и передача в качестве аргумента ссылки на структуру

        Console.WriteLine("Поле классса = {0}", testClass.change); //Отобраджение значения поля change класса
        Console.WriteLine("Поле структуры = {0}", testStruct.change); //Отобраджение значения поля change структуры

        Console.ReadKey();
    }
}