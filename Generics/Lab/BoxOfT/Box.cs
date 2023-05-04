using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> element;
        private int count;

        public int Count
        {
            get { return count; }

        }

        public Box()
        {
            element = new List<T>();
            count = 0;
        }

        //public List<T> Element
        //{
        //    get { return element; }
        //    set { element = value; }
        //}



        public void Add(T item)
        {
            element.Add(item);
            count++;
        }

        public T Remove()
        {
            T el = element[element.Count - 1];
            element.RemoveAt(element.Count - 1);
            count--;
            return el;
        }



    }
}
