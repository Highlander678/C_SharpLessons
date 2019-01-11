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
            if (state == true)
                Console.WriteLine("����� ��������.");
            else
                Console.WriteLine("����� ���������.");
        }
    }
}
