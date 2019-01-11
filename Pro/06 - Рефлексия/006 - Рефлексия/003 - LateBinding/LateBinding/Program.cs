using System;
using System.IO;
using System.Reflection;

//using CarLibrary;

namespace LateBinding
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            // �������� ���������� ������ MiniVan "�� ����"
            // ��� ������ ������ Activator ������������ ������� ����������.
            // ����� CreateInstance() - ������������ ��� �������� ���������� ���� �� ����� ����������.
            Type type = assembly.GetType("CarLibrary.MiniVan");

            object instance = Activator.CreateInstance(type); // new MiniVan();

            // �������� ��������� ������ MethodInfo ��� ������ Acceleration(). 
            MethodInfo method = type.GetMethod("Acceleration");

            // ����� ������ Acceleration().
            // ������ �������� - ������ �� ��������� ��� �������� ����� ������ ����� Acceleration
            // ������ �������� - ������ ���������� ������ Acceleration (� ������ ������ ��� ���������� - null)
            method.Invoke(instance, null);


            // �������� ��������� ������ MethodInfo ��� ������ Driver(). 
            method = type.GetMethod("Driver");

            // ������ ���������� ��� ������ Driver("Shumaher", 36). 
            object[] parameters = { "Shumaher", 36 };

            // ����� ������ Driver().
            // ������ �������� - ������ �� ��������� ��� �������� ����� ������ ����� Acceleration
            // ������ �������� - ������ ���������� ������ Acceleration (� ������ ������ - name:"Shumaher", age:36 )
            method.Invoke(instance, parameters);

            // Delay.
            Console.ReadKey();
        }
    }
}
