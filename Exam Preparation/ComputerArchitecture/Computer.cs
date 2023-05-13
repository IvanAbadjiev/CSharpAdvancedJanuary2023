using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {

        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public int Capacity
        {
            get;
            set;
        }
        public string Model
        {

            get;
            set;
        }
        public List<CPU> Multiprocessor
        {

            get;
            set;
        }

        public int Count => this.Multiprocessor.Count;
        public void Add(CPU cpu)
        {
            if (Count < Capacity)
            {
                Multiprocessor.Add(cpu);

            }
        }
        public bool Remove(string brand)
        {
            if (Multiprocessor.Count == 0)
            {
                return false;
            }
            foreach (var cpu in Multiprocessor)
            {
                if (cpu.Brand == brand)
                {

                    Multiprocessor.Remove(cpu);

                    return true;
                }
            }
            return false;


        }
        public CPU MostPowerful()
        {
            if (Multiprocessor.Count == 0)
            {
                return null;
            }
            var moustPowerful = Multiprocessor.MaxBy(x => x.Frequency);

            return moustPowerful;
        }

        public CPU GetCPU(string brand)
        {
            if (Multiprocessor.Count == 0)
            {
                return null;
            }
            foreach (var cpu in Multiprocessor)
            {
                if (cpu.Brand == brand)
                {
                    return cpu;
                }

            }
            return null;


        }

        public string Report()
        {
            StringBuilder sb = new();
            sb.AppendLine($"CPUs in the Computer {Model}:");

            foreach (var cpu in Multiprocessor)
            {
                sb.AppendLine(cpu.ToString());
            }



            return sb.ToString().TrimEnd();
        }
    }
}
