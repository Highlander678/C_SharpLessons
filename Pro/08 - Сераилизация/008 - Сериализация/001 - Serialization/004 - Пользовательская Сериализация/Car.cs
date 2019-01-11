using System;
using System.Runtime.Serialization;

namespace UserSerialWork
{
	[Serializable]
	public class Car : ISerializable
	{
		public string name;
		public int speed;

		public Car(string name, int speed)
		{
			this.name = name;
			this.speed = speed;
		}

		// ����������� ������� ������������. 
		// SerializationInfo - ������ � ������� �������� ��� ���� ���-�������� �������������� ��������� �������.
		// SerializationInfo - ����� �� ���������� (property bag)
		private Car(SerializationInfo propertyBag, StreamingContext context)
		{
			// �������� All ������������ StreamingContextState ��� �������� context.State, ���������,
			// ��� ������ ����� ���� �������� � ����� ����� ��� �������� �� ������ �����.
			Console.WriteLine("[ctor] ContextState: {0}", context.State.ToString());

			// �� ����� �� ���������� ��������� �������� ������� ����������� ����� � ������ GetObjectData()
			name = propertyBag.GetString("name");
			speed = propertyBag.GetInt32("speed");
		}


		// ����� ISerializable.GetObjectData() ���������� Formatter-��
		void ISerializable.GetObjectData(SerializationInfo propertyBag, StreamingContext context)
		{
			// �������� All ������������ StreamingContextState �������� context.State, ���������,
			// ��� ������ ����� ���� �������� � ����� ����� ��� �������� �� ������ �����.
			Console.WriteLine("[GetObjectData] ContextState: {0}", context.State.ToString());

			// � ����� �� ���������� ��������� ��� �������� � �������������� �������� ��� ���.
			propertyBag.AddValue("name", name);
			propertyBag.AddValue("speed", speed);
		}
	}
}
