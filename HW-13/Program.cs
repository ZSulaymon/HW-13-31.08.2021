using System;

namespace HW_13
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new ();
            Play(player);
        }
        public static void Play(IRecPlayable player)
        {
            player.playMusic();
            player.pauseMusic();
            player.stopMusic();
            player.startRecord();
            player.pauseMusic();
            player.stopMusic();
        }
    }
    interface IPlayable
    {
        void playMusic();
        void pauseMusic();
        void stopMusic();
    }
    interface IRecordable
    {
        void startRecord();
        void pauseRecord();
        void stopRecord();
    }
    interface IRecPlayable : IRecordable, IPlayable
    {
    }
    class Player : IRecPlayable
    {
        public void playMusic()
        {
            Console.WriteLine("playMusic");
        }
        public void pauseMusic()
        {
            Console.WriteLine("pauseMusic");
        }
        public void stopMusic()
        {
            Console.WriteLine("stopMusic");
        }

        public void startRecord()
        {
            Console.WriteLine("startRecord");
        }
        public void pauseRecord()
        {
            Console.WriteLine("pauseRecord");
        }
        public void stopRecord()
        {
            Console.WriteLine("stopRecord");
        }
    }
}
