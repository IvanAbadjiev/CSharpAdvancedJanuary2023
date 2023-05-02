using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Cargo
    {
        //fild
        private string type;
        private int weight;
        //ctor
        public Cargo(string type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }
        //prop
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }


    }
}
