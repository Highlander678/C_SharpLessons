using System;

namespace Task_3
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play melody");
        }

        public void Record()
        {
            Console.WriteLine("Start recording");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause melody");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop melody");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause recording");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop recording");
        }
    }
}
