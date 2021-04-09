using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    public class MyList<T> : IMyList<T>
    {

        private List<T> listObject = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return listObject.GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                return listObject.ElementAt(index);
            }
            set
            {
                listObject[index] = value;
            }
        }
        
        public int CountElement
        {
            get
            {
                return listObject.Count;
            }
        }

        public void Add(T value)
        {
            listObject.Add(value);
        }

        public void Delete(int index) 
        {
            listObject.RemoveAt(index);
        }
    }
}
