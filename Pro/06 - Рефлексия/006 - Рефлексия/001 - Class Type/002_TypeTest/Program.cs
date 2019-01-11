using System;
using System.Reflection;

// ��������� - ��� ������� ����������� ����� �� ����� ������ ���������.

namespace Type_test
{
    static class Program
    {
        // �������� ������ ���������� � Class1.
        static void ListVariosStats(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " ���������� � Class1" + "\n");
            Type t = cl.GetType();

            Console.WriteLine("������ ���:             {0}", t.FullName);
            Console.WriteLine("������� �����:          {0}", t.BaseType);
            Console.WriteLine("�����������:            {0}", t.IsAbstract);
            Console.WriteLine("��� COM ������:         {0}", t.IsCOMObject);
            Console.WriteLine("��������� ������������: {0}", t.IsSealed);
            Console.WriteLine("��� class:              {0}", t.IsClass);
        }

        // �������� ���������� �� ������ ���� ������� Class1.
        static void ListMethods(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " ������ ������ Class1" + "\n");

            Type t = cl.GetType();
            MethodInfo[] mi = t.GetMethods(BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

            foreach (MethodInfo m in mi)
                Console.WriteLine("Method: {0}", m.Name);
        }

        // �������� ���������� �� ������ ����� Class1.
        static void ListFields(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " ���� ������ Class1" + "\n");

            Type t = cl.GetType();
            FieldInfo[] fi =
                t.GetFields(BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic);

            foreach (FieldInfo f in fi)
                Console.WriteLine("Field: {0}", f.Name);
        }

        // �������� ������ ���� ������� Class1.
        static void ListProps(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " �������� ������ Class1" + "\n");

            Type t = cl.GetType();
            PropertyInfo[] pi = t.GetProperties();

            foreach (PropertyInfo p in pi)
                Console.WriteLine("��������: {0}", p.Name);
        }

        // �������� ������ ���� �����������, �������������� Class1.
        static void ListInterfaces(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " ���������� ������ Class1" + "\n");

            Type t = cl.GetType();

            Type[] it = t.GetInterfaces();

            foreach (Type i in it)
                Console.WriteLine("���������: {0}", i.Name);
        }

        // �������� ���������� ��� ���� ������������� Class1.
        static void ListConstructors(Class1 cl)
        {
            Console.WriteLine(new string('_', 30) + " ������������ ������ Class1" + "\n");

            Type t = cl.GetType();
            ConstructorInfo[] ci = t.GetConstructors();

            foreach (ConstructorInfo m in ci)
                Console.WriteLine("Constructor: {0}", m.Name);
        }

        static void Main()
        {
            Console.SetWindowSize(80, 45);

            Class1 instance = new Class1();

            #region ����� ���������� � ����

            ListVariosStats(instance);  // �������� ������ ���������� � Class1.
            ListMethods(instance);      // �������� ���������� �� ������ ���� ������� Class1.
            ListFields(instance);       // �������� ���������� �� ������ ���� ����� Class1.
            ListProps(instance);        // �������� ������ ���� ������� Class1.
            ListInterfaces(instance);   // �������� ������ ���� �����������, �������������� Class1.
            ListConstructors(instance); // �������� ���������� �� ������ ���� ������������� Class1.

            #endregion

            #region ��������� � �������� ������.

            Console.WriteLine(new string('-', 60));

            Type type = instance.GetType();

            // ����� private ������
            MethodInfo methodC = type.GetMethod("MethodC", BindingFlags.Instance | BindingFlags.NonPublic);
            methodC.Invoke(instance, new object[] { "Hello", " world!" });
            
            // ������ �������� � private ����
            FieldInfo mystring = type.GetField("mystring", BindingFlags.Instance | BindingFlags.NonPublic);
            mystring.SetValue(instance, "������ ���!");

            Console.WriteLine(instance.MyString);

            #endregion

            // Delay.
            Console.ReadKey();
        }
    }
}
