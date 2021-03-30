using System;

namespace App2
{
    /*
     2.	Создайте класс AbstractHandler. Создать производные классы
        XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. 
        Написать программу, которая будет выполнять определение документа и для 
        каждого формата должны быть методы открытия, создания, редактирования, 
        сохранения определенного формата документа. Разрабатывать полноценные 
        методы для работы с файлами - по усмотрению разработчика. 
        Можно обойтись методами-заглушками. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите имя файла:");
            string nameFile = Console.ReadLine();

            Console.WriteLine("Укажите тип файла в формате DOC/TXT/XML:");

            string typeFile = Console.ReadLine();

            switch (typeFile)
            {
                case "DOC":
                    DOCHandler doc = new DOCHandler(nameFile);
                    doc.Create();
                    doc.Open();
                    doc.Change();
                    doc.Save();
                    break;

                case "TXT":
                    TXTHandler txt = new TXTHandler(nameFile);
                    txt.Create();
                    txt.Open();
                    txt.Change();
                    txt.Save();
                    break;

                case "XML":
                    XMLHandler xml = new XMLHandler(nameFile);
                    xml.Create();
                    xml.Open();
                    xml.Change();
                    xml.Save();
                    break;

                default:
                    Console.WriteLine("Не удалось определить тип файла, попробуйте еще раз!");
                    break;
            }
        }
    }
}
