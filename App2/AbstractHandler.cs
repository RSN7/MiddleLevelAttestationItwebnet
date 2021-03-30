using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public abstract class AbstractHandler
    {
        public string File { get; set; }
        public AbstractHandler(string NameFile)
        {
            File = NameFile;
        }
        abstract public void Open();
        abstract public void Create();
        abstract public void Change(); 
        abstract public void Save();
    }
}
