namespace P8._Traffic_Jam
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new Queue<string>();
            int count = 0;
            string car;
            while ((car = Console.ReadLine()) != "end")
            {
                if (car == "green")
                {
                    if (cars.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            var currCar = cars.Dequeue();
                            Console.WriteLine($"{currCar} passed!");
                            count++;
                        }

                    }
                    else if (cars.Count > 0)
                    {
                        for (int i = 0; i <= cars.Count; i++)
                        {
                            var currCar = cars.Dequeue();
                            Console.WriteLine($"{currCar} passed!");
                            count++;
                        }

                    }


                }
                else
                {
                    cars.Enqueue(car);

                }

            }
            Console.WriteLine($"{count} cars passed the crossroads.");








        }
    }
}
