using App3.Class;
using App3.Interfaces;
using System;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player = new Player();
            IRecodable recodable = new Player();

            Console.WriteLine("Тест воспроизведения:");
            player.Play();
            player.Pause();
            player.Stop();

            Console.WriteLine("Тест записи:");
            recodable.Record();
            recodable.Pause();
            recodable.Stop();
        }
    }
}
