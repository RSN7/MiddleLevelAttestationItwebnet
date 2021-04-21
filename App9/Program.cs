using System;
using System.Threading;

namespace App9
{
    /*
     Напишите программу, в которой метод будет вызываться рекурсивно. 
     Каждый новый вызов метода выполняется в отдельном потоке.

     */
    class Program
    {
        public static void RecursiveThread(int valueThread, int numberThread = 1) 
        {
            Console.WriteLine($"Отработал поток № {numberThread}");
            numberThread++;
            valueThread--;
            var myThread = new Thread(new ThreadStart(
                () =>
                {
                    if (valueThread > 0)
                    {
                        RecursiveThread(valueThread, numberThread);
                    }
                }));
            myThread.Start();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Рекурсивный вызов 10 потоков:");
            RecursiveThread(10);
        }
    }
}
