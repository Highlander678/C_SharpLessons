using System;

namespace SerializableWork
{
    // ����� Radio ����� �������� ��� ������������.
    [Serializable]
    public class Radio
    {
        [NonSerialized]
        private int id = 9;
        
        // ����� ���������/���������� �����.
        public void OnOff(bool state)
        {
            Console.WriteLine(state ? "����� ��������." : "����� ���������.");
        }
    }
}
