using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Person> person = new List<Person>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] personInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = personInfo[0];
            int age = int.Parse(personInfo[1]);
            Person curentPerson = new Person(name, age);
            person.Add(curentPerson);

        }

        foreach (var people in person.OrderBy(p => p.Name))
        {
            if (people.Age > 30)
            {
                Console.WriteLine($"{people.Name} - {people.Age}");
            }
        }


        //Family family = new();

        //int count = int.Parse(Console.ReadLine());

        //for (int i = 0; i < count; i++)
        //{
        //    string[] personProperties = Console.ReadLine()
        //        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        //    Person person = new(personProperties[0], int.Parse(personProperties[1]));

        //    family.AddMember(person);
        //}

        //Person oldest = family.GetOldestMember();

        //Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}