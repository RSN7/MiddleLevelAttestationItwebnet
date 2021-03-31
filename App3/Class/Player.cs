using App3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Class
{
    public class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Файл воспроизводится");
        }

        public void Record()
        {
            Console.WriteLine("Файл записывается");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Воспроизведение файла поставлено на паузу");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Запись файла поставлена на паузу");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Воспроизведение файла остановлено");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запись файла остановлена");
        }

    }
}
