using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class CustumTuple<T1, T2, T3>
    {
        public CustumTuple(T1 item1, T2 item2, T3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public T1 item1 { get; private set; }
        public T2 item2 { get; private set; }
        public T3 item3 { get; private set; }
        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}
