using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Player player = new Player();

            player.Play();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecodable).Stop();

            // Delay.
            Console.ReadKey();
        }
    }
}
