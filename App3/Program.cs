using App3.Class;
using App3.Interfaces;
using System;

namespace App3
{
    class Program
    {
        /*
         3.	Создайте 2 интерфейса IPlayable и IRecodable. В каждом из 
            интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и 
        void Record() / void Pause() / void Stop() соответственно. 
        Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
        Написать программу, которая выполняет проигрывание и запись. 
        Разрабатывать полноценные методы нет необходимости. Можно обойтись методами-заглушками. 
         */
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
