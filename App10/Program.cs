using System;
using System.Collections.Generic;
using System.Linq;

namespace App10
{
    /*
     Требуется: Описать структуру с именем Price, содержащую следующие
    поля: название товара; название магазина, в котором продается товар; стоимость товара. 
    Написать программу, выполняющую следующие действия: 
    ●	ввод с клавиатуры данных в массив (записи должны быть упорядочены в алфавитном порядке по 
    названиям магазинов);
    ●	вывод на экран информации о товарах, продающихся в магазине, название которого введено с 
    клавиатуры (если такого магазина нет, вывести исключение). 
     */
    class Program
    {
        static List<Price> prices = new List<Price>();
        static void Main(string[] args)
        {
            Console.WriteLine("Для ввода данных укажте команду insert и " +
                "перечислите название товара, название магазина и стоимость товара через ; \r\n" +
                "Для вывода данных укажите команду select и укажите название магазина \r\n" +
                "Для выхода из программы используйте команду quit");

            string userCommand = "";
        
            while (userCommand != "quit")
            {
                Console.WriteLine("Введите значение:");
                userCommand = Console.ReadLine();

                if (userCommand == "quit")
                {
                    break;
                }
                
                if (userCommand.Contains("insert"))
                {
                    string command = userCommand.Substring(6, userCommand.Length - 6).Trim();
                    InsertPrice(command);
                }
                else
                {
                    if (userCommand.Contains("select"))
                    {
                        string command = userCommand.Substring(6, userCommand.Length - 6).Trim();
                        SelectPrice(command);
                    } else
                    {
                        Console.WriteLine("Команда не распознана, повторите попытку!");
                    }
                }
            }

            Console.WriteLine("Работа программы завершена!");
        }
        
        public static void InsertPrice(string command)
        {
            try
            {
                string[] values = command.Split(";");
                Price prie = new Price()
                {
                    NameProduct = values[0].Trim(),
                    NameStore = values[1].Trim(),
                    Cost = decimal.Parse(values[2].Trim())
                };

                prices.Add(prie);
            }
            catch
            {
                Console.WriteLine("Не удалось распознать и записать значения, " +
                    "проверьте вводимую команду и повторите попытку!");
            }
        }

        public static void SelectPrice(string command)
        {
            try 
            {
                var selectPrices = prices.Where(p => p.NameStore == command).OrderBy(p=>p.NameProduct);

                if (selectPrices.Any())
                {
                    Console.WriteLine("В данном магазине найдены следующие товары:");
                    foreach (var price in selectPrices)
                    {
                        Console.WriteLine($"{price.NameProduct} цена {price.Cost}");
                    }
                }
                else
                {
                    Console.WriteLine("Для данного магазина товары не найдены!");
                }
            }
            catch 
            {
                Console.WriteLine("Не удалось распознать параметры команды! " +
                    "Проверьте вводимую команду и повторите попытку!");
            }

        }
    }
}
