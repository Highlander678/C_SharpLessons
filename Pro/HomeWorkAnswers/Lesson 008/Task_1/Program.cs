using System.IO;
using System.Xml.Serialization;

namespace Task_1
{
    public class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public Car()
        {

        }
    }

    public class CarXML
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public int Speed { get; set; }

        public CarXML(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public CarXML()
        {

        }
    }

    class Program
    {
        static void Main()
        {
            Car auto = new Car("Mercedes", 250);

            XmlSerializer serializer = new XmlSerializer(typeof(Car));

            FileStream original = new FileStream("SerializationOriginal.xml", FileMode.Create, FileAccess.Write);

            serializer.Serialize(original, auto);

            original.Close();

            CarXML autoXML = new CarXML("Mercedes", 250);

            XmlSerializer serializerXML = new XmlSerializer(typeof(CarXML));

            FileStream streamXML = new FileStream("SerializationXML.xml", FileMode.Create, FileAccess.Write);

            serializerXML.Serialize(streamXML, autoXML);

            streamXML.Close();
        }
    }
}
