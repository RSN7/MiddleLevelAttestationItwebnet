using System;

namespace App5
{

    /*
     * 1.	Создать статический класс Calculator, с методами для выполнения 
            основных арифметических операций. Написать программу, которая выводит 
            на экран основные арифметические операции. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения чисел. Для выхода из программы введите quit");

            string userCommand = "";

            while (userCommand != "quit")
            {
                Console.WriteLine("Введите первое значение:");
                userCommand = Console.ReadLine();

                if (userCommand == "quit")
                {
                    break;
                }

                int parseX = 0;
                int parseY = 0;

                if (!int.TryParse(userCommand, out parseX))
                {
                    Console.WriteLine("Вводить нужно число!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Введите второе значение:");
                    userCommand = Console.ReadLine();
                    if (userCommand == "quit")
                    {
                        break;
                    }
                    if (!int.TryParse(userCommand, out parseY))
                    {
                        Console.WriteLine("Вводить нужно число!");
                        continue;
                    }
                }

                Calculator.X = parseX;
                Calculator.Y = parseY;
                Calculator.Sum();
                Calculator.Subtraction();
                Calculator.Multiplying();
                Calculator.Division();
            }

            Console.WriteLine("Работа программы завершена!");
        }
    }
}
