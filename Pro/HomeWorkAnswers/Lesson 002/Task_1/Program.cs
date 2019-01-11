using System;
using System.Collections.Generic;

namespace Task_1
{
    class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            this.Name = name;
        }
    }

    enum Category
    {
        IT, Other
    }

    class Program
    {
        static void Main()
        {
            Dictionary<Employee, List<Category>> dic = new Dictionary<Employee, List<Category>>();

            dic.Add(new Employee("Ivanov"), new List<Category> { Category.IT, Category.Other });
            dic.Add(new Employee("Petrov"), new List<Category> { Category.Other });

            foreach (KeyValuePair<Employee, List<Category>> item in dic)
            {
                Console.Write(item.Key.Name + ": ");
                foreach (var category in item.Value)
                {
                    Console.Write(category + ", ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 10));
            }

            var res = GetEmployyByCategory(dic, Category.Other);
            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }

        static List<Employee> GetEmployyByCategory(Dictionary<Employee, List<Category>> dic, Category cat)
        {
            List<Employee> emp = new List<Employee>();
            foreach (var item in dic)
            {
                if (item.Value.Contains(cat))
                {
                    emp.Add(item.Key);
                }
            }
            return emp;
        }
    }
}
