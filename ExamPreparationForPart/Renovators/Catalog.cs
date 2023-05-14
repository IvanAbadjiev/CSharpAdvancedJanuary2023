using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            this.renovators = new List<Renovator>();
        }

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public IReadOnlyCollection<Renovator> Renovators => this.renovators;

        public int Count => this.Renovators.Count;


        public string AddRenovator(Renovator renovator)
        {
            // var renovatorToAdd = this.renovators.FirstOrDefault(x => x.)

            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            else if (Renovators.Count >= NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            else if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            else
            {
                this.renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";

            }

        }

        public bool RemoveRenovator(string name)
        {
            var targetRemove = renovators.FirstOrDefault(n => n.Name == name);

            if (targetRemove == null)
            {
                return false;
            }
            else
            {
                renovators.Remove(targetRemove);
                return true;
            }


        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = 0;
            while (renovators.FirstOrDefault(n => n.Type == type) != null)
            {
                var curent = renovators.FirstOrDefault(n => n.Type == type);
                renovators.Remove(curent);
                count++;
            }
            return count;

        }

        public Renovator HireRenovator(string name)
        {
            var target = renovators.FirstOrDefault(n => n.Name == name);

            if (target != null)
            {
                target.Hired = true;
                return target;
            }
            else
            {
                return null;
            }
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> working = new List<Renovator>();
            for (int i = 0; i < Renovators.Count; i++)
            {
                if (renovators[i].Days >= days)
                {
                    working.Add(renovators[i]);
                }

            }
            //while (renovators.FirstOrDefault(n => n.Days >= days) != null)
            //{
            //    var target = renovators.FirstOrDefault(n => n.Days >= days);
            //    working.Add(target);
            //}
            return working;

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var renovator in renovators)
            {
                if (renovator.Hired == false)
                {
                    sb.AppendLine(renovator.ToString());

                }
            }

            return sb.ToString().TrimEnd();

        }

    }
}
