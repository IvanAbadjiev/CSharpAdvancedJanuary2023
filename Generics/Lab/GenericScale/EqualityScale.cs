using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T rigth;

        public EqualityScale(T left, T rigth)
        {
            this.left = left;
            this.rigth = rigth;
        }


        public bool AreEqual()
        {

            return left.Equals(rigth);

        }

    }
}
