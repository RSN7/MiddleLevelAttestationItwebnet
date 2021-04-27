using System;

namespace App11
{
    /*
     Создайте класс House c двумя полями и свойствами. Создайте два 
            метода Clone() и DeepClone(), которые выполняют поверхностное и 
    глубокое копирование соответственно. Реализуйте простой способ проверки.

     */
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner
            {
                Name = "Иван",
                Surname = "Иванов",
                Age = 25
            };
            

            House house = new House() 
            {
                Owner = owner,
                Address = "ул. Пушкина дом 15"
            };
            

            var copyHouse = (House)house.Clone();
            var deepColyHouse = (House)house.DeepClone();

            Console.WriteLine("Проверка поверхностного копирования методом Clone:");
            if(copyHouse.Owner.GetHashCode() == owner.GetHashCode())
            {
                Console.WriteLine("Хеш-код совпал, метод вернул ссылку на объект owner. " +
                    "Выполнено поверхностное копирование");
            }

            Console.WriteLine("Проверка глубокого копирования методом DeepClone:");
            if (deepColyHouse.Owner.GetHashCode() != owner.GetHashCode())
            {
                Console.WriteLine("Хеш-код не совпал, в памяти был создан новый объект owner. " +
                    "Выполнено глубокое копирование");
            }
        }
    }
}
