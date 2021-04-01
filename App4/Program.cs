using App4.Class;
using System;

namespace App4
{
    /*
     4.	Создать класс Article, содержащий следующие закрытые поля: название
        товара; название магазина, в котором продается товар; стоимость товара. Создать класс Store, 
        содержащий закрытый массив элементов типа Article.
        Обеспечить следующие возможности:
        ●	вывод информации о товаре по номеру с помощью индекса;
        ●	вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, 
    выдать соответствующее сообщение;
    Написать программу, вывода на экран информацию о товаре.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Article[] articles =
            {
                new Article("Смартфон", "Связной", 10000.00),
                new Article("Телефон", "Евросеть", 1500.50),
                new Article("Кофеварка", "Эльдорадо", 6999.90),
                new Article("Дрель", "Инструмет", 1680.10),
                new Article("Колонки", "DNS", 500.50),
                new Article("Клавиатура", "DNS", 2000.00),
                new Article("Хлеб", "Магнит", 35.15),
                new Article("Молоко", "Магнит", 49.10),
                new Article("Щетка", "FixPrice", 59),
                new Article("Зубная паста", "Магнит", 100.40)
            };

            Store store = new Store(articles);

            //TODO
            /*
             * Добавить ввод значения, проверить - если преобразуется в число - искать по индексу, если не 
             * приобразуется - искать по наименованию
             * сделать в цикле, проверять на выход командой quit.
             */

            Console.WriteLine("Введите индекс элемента для поиска, либо наименование товара. Для выхода из программы введите quit");

            string userCommand = "";

            while (userCommand != "quit")
            {
                Console.WriteLine("Введите значение:");
                userCommand = Console.ReadLine();

                if (userCommand == "quit")
                {
                    break;
                }
                int parseResult = 0;
                if (int.TryParse(userCommand, out parseResult))
                {
                    store.ArticleInfoForIndex(parseResult);
                }
                else
                {
                    store.ArticleInfoForName(userCommand);
                }
            }

            Console.WriteLine("Работа программы завершена!");
        }
    }
}
