using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    interface IMyList<T>
    {
        void Add(T value);
        void Delete(int index);
    }
}
