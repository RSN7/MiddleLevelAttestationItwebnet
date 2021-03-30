using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class TXTHandler : AbstractHandler
    {
        public TXTHandler(string NameFile) : base(NameFile)
        {
        }
        public override void Open()
        {
            Console.WriteLine($"Открыт файл {File} тип файла: TXT");
        }

        public override void Create()
        {
            Console.WriteLine($"Создан файл {File} тип файла: TXT");
        }

        public override void Change()
        {
            Console.WriteLine($"Изменен файл {File} тип файла: TXT");
        }

        public override void Save()
        {
            Console.WriteLine($"Сохранен файл {File} тип файла: TXT");
        }
    }
}
