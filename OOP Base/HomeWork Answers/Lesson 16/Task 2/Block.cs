namespace Task_2
{
    class Block
    {
        int side1, side2, side3, side4; //Создание полей класса

        public Block(int side1, int side2, int side3, int side4) //Пользовательский конструктор
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = side4;
        }

        public override bool Equals(object obj) //Переопределение метода Equals базового класса Object
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Block p = (Block)obj;
            return (side1 == p.side1) && (side2 == p.side2) && (side3 == p.side3) && (side4 == p.side4);
        }

        public override string ToString()//Переопределение метода ToString базового класса Object
        {
            return "Информация о полях блока: " + side1 + " " + side2 + " " + side3 + " " + side4;
        }

        public override int GetHashCode()//Переопределение метода GetHashCode базового класса Object
        {
            return side1 ^ side2 ^ side3 ^ side4;
        }
    }
}
