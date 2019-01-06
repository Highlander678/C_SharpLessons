using System;

namespace Task_3
{
    class Program
    {
        //Точка входа программы
        static void Main()
        {
            //Создание екземпляра класса employee класса Employee
            Employee employee = new Employee("Smith", "Petr");
            employee.Post = "manager"; //Передача значения в поле Post
            employee.Experience = 1; // Передача значения в поле Experience

            //Вывод результата
            Console.WriteLine(employee.Surname + " " + employee.Name + " " + employee.Post.ToUpper());
            employee.ShowSalary();
            
            Console.ReadKey();
        }
    }
}
