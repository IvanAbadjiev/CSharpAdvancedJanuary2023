using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);

        }

        public int Count(T el)
        {
            int count = 0;
            foreach (T item in items)
            {
                if (item.CompareTo(el) > 0)
                {
                    count++;
                }
            }
            return count;

        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T firstEl = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = firstEl;

        }

        public override string ToString()
        {
            StringBuilder sb = new();

            foreach (T item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

