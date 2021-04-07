using System;

namespace App7
{
    /*
       7.	Создайте класс MyList<T>. Для хранения элементов использовать класс List<T>. 
       Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать: 
       ●	метод добавления элемента,
       ●	индексатор для получения значения элемента по указанному индексу, 
       ●	свойство только для чтения для получения общего количества элементов.
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


            Console.WriteLine("Сейчас добавлены следующие элементы:");

            for(int i = 0; i < myListString.CountElement; i++) 
            {
                Console.WriteLine($"[{i}] - {myListString[i]}");
            }

            Console.WriteLine($"Всего элементов: {myListString.CountElement}");


            
            Console.WriteLine("Удалим элемент 3. Результат:");
            myListString.Delete(3);


            for (int i = 0; i < myListString.CountElement; i++)
            {
                Console.WriteLine($"[{i}] - {myListString[i]}");
            }
            Console.WriteLine($"Всего элементов после удаления: {myListString.CountElement}");


        }
    }
}
