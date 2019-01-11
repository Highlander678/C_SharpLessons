using System;
using System.IO;
using System.Reflection;

// ��� ������������ ������� �������, ����������,
// ����������� ���������� CarLibrary.dll �� ������� 001_CarLibrary, � ����� � *.��� ������

namespace LoadAssembly
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 50);

            // ��� ������ ������ Assembly - ����� ����������� ��������� ������, 
            // ���������� � ������ ������ � �������� ���������� (������� ����������),
            // � ��� �� �������� ���������� � ����� ������.
            Assembly assembly = null;

            try
            {
                // Assembly.Load() - ����� ��� �������� ������.
                assembly = Assembly.Load("CarLibrary"); // LoadFrom(...)
                Console.WriteLine("������ CarLibrary - ������� ���������.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ������� ���������� � ���� ����� � ������.
            ListAllTypes(assembly);
            // ������� ���������� � ���� ������ � ������.
            ListAllMembers(assembly);
            // ������� ���������� � ���� ���������� ������.
            GetParams(assembly);

            // Delay.
            Console.ReadKey();
        }

        // ����� ��� ��������� ���������� � ���� ����� � ������.
        private static void ListAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));
            Console.WriteLine("\n���� �: {0} \n", assembly.FullName);

            Type[] types = assembly.GetTypes();

            foreach (Type t in types)
                Console.WriteLine("���: {0}", t);
        }

        // ����� ��� ��������� ���������� � ������ ������.
        private static void ListAllMembers(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));

            Type type = assembly.GetType("CarLibrary.MiniVan");

            Console.WriteLine("\n����� ������: {0} \n", type);

            MemberInfo[] members = type.GetMembers();

            foreach (MemberInfo element in members)
                Console.WriteLine("{0,-15}:  {1}", element.MemberType, element);
        }

        // �������� ���������� � ���������� ��� ������ TurboBoost() 
        private static void GetParams(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));

            Type type = assembly.GetType("CarLibrary.MiniVan");
            MethodInfo method = type.GetMethod("Driver"); // Equals , Acceleration, Driver

            // ����� ���������� � ���������� ����������.
            Console.WriteLine("\n���������� � ���������� ��� ������ {0}", method.Name);
            ParameterInfo[] parameters = method.GetParameters();
            Console.WriteLine("����� ����� " + parameters.Length + " ����������");

            // ������� ��������� �������������� ������� �� ����������. 
            foreach (ParameterInfo parameter in parameters)
            {
                Console.WriteLine("��� ���������: {0}", parameter.Name);
                Console.WriteLine("������� � ������: {0}", parameter.Position);
                Console.WriteLine("��� ���������: {0}", parameter.ParameterType);
            }
        }
    }
}
