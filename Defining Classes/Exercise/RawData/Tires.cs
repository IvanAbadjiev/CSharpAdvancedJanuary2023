using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tires
    {
        private int age;
        private double pressure;

        public Tires(int age, double pressure)
        {
            this.age = age;
            this.pressure = pressure;
        }

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


    }
}
