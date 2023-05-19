using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public int ChildrenCount => this.Registry.Count;

        public bool AddChild(Child child)
        {

            if (Capacity > Registry.Count)
            {
                Registry.Add(child);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveChild(string childFullName)
        {
            string firstName = childFullName
                .Split(" ")[0];
            string lastName = childFullName
                .Split(" ")[1];

            var target = Registry.FirstOrDefault(n => n.FirstName == firstName &&
            n.LastName == lastName);

            if (target != null)
            {
                Registry.Remove(target);
                return true;
            }
            else
            {
                return false;
            }



        }

        public Child GetChild(string childFullName)
        {
            string firstName = childFullName
                .Split(" ")[0];
            string lastName = childFullName
                .Split(" ")[1];

            var target = Registry.FirstOrDefault(n => n.FirstName == firstName &&
            n.LastName == lastName);

            return target;

        }

        public string RegistryReport()
        {
            var sorted = Registry.OrderByDescending(a => a.Age).ThenBy(n => n.LastName).ThenBy(n => n.FirstName);

            StringBuilder sb = new();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (var chlid in sorted)
            {
                sb.AppendLine(chlid.ToString());

            }

            return sb.ToString().TrimEnd();


        }


    }
}
