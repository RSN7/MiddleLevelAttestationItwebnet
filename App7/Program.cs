using System;

namespace App7
{
    /*
       7.	Создайте класс MyList<T>. Для хранения элементов использовать класс List<T>. 
       Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать: 
       ●	метод добавления элемента,
       ●	индексатор для получения значения элемента по указанному индексу, 
       ●	свойство только для чтения для получения общего количества элементов.

       Создайте расширяющий метод public static T[] GetArray<T>(this MyList<T> list). 
       Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 
       Реализуйте возможность перебора элементов коллекции в цикле foreach.
     */

    

    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myListString = new MyList<string>();

            myListString.Add("Первый элемент");
            myListString.Add("Второй элемент");
            myListString.Add("Третий элемент");
            myListString.Add("Четвертый элемент");
            myListString.Add("Пятый элемент");

            var result = myListString.GetArray();

            
            Console.WriteLine("Сейчас добавлены следующие элементы:");
            Console.WriteLine("Для вывода элементов воспользуемся методом GetArray:");
            foreach (var element in result)
            {
                Console.WriteLine($"{element}");
            }

            Console.WriteLine($"Всего элементов: {myListString.CountElement}");


            
            Console.WriteLine("Удалим элемент 3. Результат:");
            Console.WriteLine("Для вывода элементов воспользуемся реализацией " +
                "перебора элементов коллекции в цикле foreach:");
            myListString.Delete(3);

            foreach (var element in myListString)
            {
                Console.WriteLine($"{element}");
            }

            Console.WriteLine($"Всего элементов после удаления: {myListString.CountElement}");


        }
    }
}
