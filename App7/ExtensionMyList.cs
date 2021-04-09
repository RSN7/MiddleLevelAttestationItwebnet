using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    public static class ExtensionMyList
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            int countT = list.CountElement;
            
            T[] result = new T[countT];

            for (int i = 0; i< list.CountElement; i++)
            {
                result[i] = list[i];
            }
            return result;
        }
    }
}
