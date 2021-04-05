using System;

namespace App6
{
    /*
     6.	Создайте анонимный метод, который принимает в качестве аргумента 
        массив делегатов и возвращает среднее арифметическое возвращаемых значений методов сообщенных с делегатами 
        в массиве. Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.

     */

    delegate int intDelegate();
    delegate decimal arithmeticMean(intDelegate[] intDelegates);
    class Program
    {
        private static int intValueReturn()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            return value;
        }
        static void Main(string[] args)
        {
            intDelegate[] intDelegates = new intDelegate[]
            {
                intValueReturn,
                intValueReturn,
                intValueReturn,
                intValueReturn,
                intValueReturn
            };

            arithmeticMean am = delegate (intDelegate[] delegates)
            {
                if (delegates.Length > 0)
                {
                    int sum = 0;
                    for (int i = 0; i < delegates.Length; i++)
                    {
                        sum = sum + delegates[0]();
                    }
                    decimal result = sum / delegates.Length;
                    return Math.Round(result, 2);
                } else
                {
                    return 0;
                }
            };

            decimal result = am(intDelegates);

            Console.WriteLine($"Результат выполнения программы: {result}");
        }
    }
}
