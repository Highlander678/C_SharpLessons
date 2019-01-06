using System;
using System.Collections;

namespace InterIEnumerable
{
    class Program
    {
        static void Main()
        {
            UserCollection myCollection = new UserCollection();

            // ���������� foreach, ��� ��������� � ������� ������� Element ������ ������� myCollection. 
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            Console.Write(new string('-', 29) + "\n");

            // ���������� foreach, ��� ���������� ��������� � ������� ������� Element ������ ������� myCollection.
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            Console.Write(new string('-', 29) + "\n");


            // --------------------------------------------------------------------------------------------------------------------
            // ��� �������� foreach.

            UserCollection myElementsCollection = new UserCollection();

            // foreach - �������� ��������� � ������������� ���� IEnumerable.
            IEnumerable enumerable = myElementsCollection as IEnumerable;

            // foreach - �������� ��������� � ������������� ���� ������� ����� - GetEnumerator().            
            IEnumerator enumerator = enumerable.GetEnumerator();


            while (enumerator.MoveNext()) // ���������� ������ �� 1 ��� ������ (� -1 �� 0) � �.�.
            {
                Element element = enumerator.Current as Element;

                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            // ��������.
            Console.ReadKey();
        }
    }
}
