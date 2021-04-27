using System;
using System.Collections.Generic;
using System.Linq;

namespace App12
{
    /*
    Используя динамические и анонимные типы данных, создайте
    Англо-Русский словарь на 10 слов и выведите на экран его содержание.

     */
    class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> dictionary = new List<dynamic>();
            dictionary.Add(new { eng = "bike", rus = "мотоцикл" });
            dictionary.Add(new { eng = "car", rus = "автомобиль" });
            dictionary.Add(new { eng = "bicycle", rus = "велосипед" });
            dictionary.Add(new { eng = "house", rus = "дом" });
            dictionary.Add(new { eng = "bird", rus = "птица" });
            dictionary.Add(new { eng = "shop", rus = "магазин" });
            dictionary.Add(new { eng = "money", rus = "деньги" });
            dictionary.Add(new { eng = "sofa", rus = "диван" });
            dictionary.Add(new { eng = "armchair", rus = "кресло" }); 
            dictionary.Add(new { eng = "lamp", rus = "лампа" });

            var orderDictionary = dictionary.OrderBy(d => d.eng);

            Console.WriteLine("Англо-русский словарь:");

            foreach (var element in orderDictionary) 
            {
                Console.WriteLine($"{element.eng} - {element.rus}"); 
            }

            
        }
    }
}
