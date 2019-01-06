using System;

// В статических методах нельзя обращаться к нестатическим полям.

namespace Static
{
    class NotStaticClass
    {
        private int id;
        public static int nn;

        // Конструктор.
        public NotStaticClass(int id)
        {
            this.id = id;
           
        }

        public NotStaticClass()
        {
            
        }

        public static void Method()
        {
            nn = 2;
            
            //Console.WriteLine("Instance.Id = {0}", Id);

            Console.WriteLine("В статических методах нельзя обращаться к нестатическим полям.");
        }
    }
}
