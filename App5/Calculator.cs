using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    public static class Calculator
    {
        public static decimal X { get; set; }
        public static decimal Y { get; set; }

       
        public static void Sum()
        {
            try
            {
                decimal result = X + Y;
                Console.WriteLine($"Сумма чисел {X} и {Y} составляет {result}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Во время выплонения операции сложения произошла ошибка: {ex.Message}");
            }
        }

        public static void Subtraction()
        {
            try 
            { 
            decimal result = X - Y;
            Console.WriteLine($"Разность чисел {X} и {Y} составляет {result}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Во время выплонения операции вычитания произошла ошибка: {ex.Message}");
            }

}

        public static void Multiplying()
        {
            try
            {
                decimal result = X * Y;
                Console.WriteLine($"Произведение чисел {X} и {Y} составляет {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Во время выплонения операции умножения произошла ошибка: {ex.Message}");
            }
        }

        public static void Division()
        {
            try
            {
                if (Y != 0)
                {
                    decimal result = X / Y;
                    Console.WriteLine($"Результат деления чисел {X} и {Y} составляет {result}");
                }   else
                {
                    Console.WriteLine("На 0 делить нельзя!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Во время выплонения операции деления произошла ошибка: {ex.Message}");
            }
        }
    }
}
