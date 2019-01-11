using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// ������������ � �������� �������.

namespace SerializableWork
{
    class Program
    {
        static void Main()
        {
            Mersedes auto = new Mersedes("CLK 500", 250, Mode.Lux);
            auto.TurnOnRadio(true);
            auto.ShowMode();

            FileStream stream = File.Create("CarData.dat");

            // �������� ��������� ���� (��� ������� �����) � ����� � �������� �������.
            BinaryFormatter formatter = new BinaryFormatter();

            // C�����������.
            formatter.Serialize(stream, auto);
            stream.Close();


            stream = File.OpenRead("CarData.dat");

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
