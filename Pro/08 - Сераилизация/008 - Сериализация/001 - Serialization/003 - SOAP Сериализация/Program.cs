using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

// ������������ � �������� �������.

namespace SerializableWork
{
    class Program
    {
        static void Main()
        {
            Mersedes auto = new Mersedes("G500", 250, Mode.Lux);
            auto.TurnOnRadio(true);
            auto.ShowMode();

            FileStream stream = File.Create("CarData.xml");

            // �������� ��������� ���� (��� ������� �����) � ����� � �������� �������.
            SoapFormatter formatter = new SoapFormatter();

            // C�����������.
            formatter.Serialize(stream, auto);
            stream.Close();


            stream = File.OpenRead("CarData.xml");

            // ��������������.
            auto = formatter.Deserialize(stream) as Mersedes;

            Console.WriteLine("���     : " + auto.Name);
            Console.WriteLine("��������: " + auto.Speed);
            auto.TurnOnRadio(false);
            stream.Close();

            // ��������.
            Console.ReadKey();
        }
    }
}
