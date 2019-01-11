using System.Drawing;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XML
{
    // XmlRoot - ��������������� �������� ����.
    [XmlRoot("MyButton")]      
    public class MyClass
    {
        private string id = "button";
        private int size = 10;
        private Point position = new Point(20, 30);
        private string password = "1234567890_password";
        private List<string> items = new List<string>();


        // XML ������� ��������������� � ������ ���������.
        [XmlAttribute("SerialID")]   
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        
        //XML �������.
        [XmlAttribute("Length")]  
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        //XML �������.
        [XmlElement("Pos")]    
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }

        // ��������� �������� �� �������� ������������/��������������.
       [XmlIgnore] 
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // �������������� �������.
        [XmlArray("List")]
        // �������������� ������� �������� �������.
        [XmlArrayItem("Element")] 
        public List<string> Items
        {
            get { return items; }
            set { items = value; }
        }
    }
}
