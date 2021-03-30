using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class DOCHandler : AbstractHandler 
    {
        public DOCHandler(string NameFile) : base(NameFile) 
        { 
        }
        public override void Open()
        {
            Console.WriteLine($"Открыт файл {File} тип файла: DOC");
        }

        public override void Create()
        {
            Console.WriteLine($"Создан файл {File} тип файла: DOC");
        }

        public override void Change()
        {
            Console.WriteLine($"Изменен файл {File} тип файла: DOC");
        }

        public override void Save()
        {
            Console.WriteLine($"Сохранен файл {File} тип файла: DOC");
        }
    }
}
