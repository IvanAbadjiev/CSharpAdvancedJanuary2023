using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Car> carsData = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carArgs[0];
                int engineSpeed = int.Parse(carArgs[1]);
                int enginePower = int.Parse(carArgs[2]);
                int cargoWeight = int.Parse(carArgs[3]);
                string cargoType = carArgs[4];
                double[] pressureTire = new double[]
                {
                    double.Parse(carArgs[5]),
                    double.Parse(carArgs[7]),
                    double.Parse(carArgs[9]),
                    double.Parse(carArgs[11])
                };
                int[] ageTire = new int[]
                {
                   int.Parse(carArgs[6]),
                    int.Parse(carArgs[8]),
                   int.Parse(carArgs[10]),
                    int.Parse(carArgs[12])
                };

                Engine engin = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tires[] tires = new Tires[4]
           {
               new Tires(ageTire[0], pressureTire[0]),
               new Tires(ageTire[1], pressureTire[1]),
               new Tires(ageTire[2], pressureTire[2]),
               new Tires(ageTire[3], pressureTire[3]),
           };


                Car car = new Car(model, engin, cargo, tires);
                carsData.Add(model, car);

            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<Car> cars = new();
                foreach (var car in carsData.Values)
                {
                    if (car.Cargo.Type == "fragile")
                    {
                        var tirespros = car.Tires.Where(x => x.Pressure > 1).ToList();
                        if (tirespros.Count == 1)
                        {
                            cars.Add(car);
                        }

                    }
                }
                foreach (var c in cars)
                {
                    Console.WriteLine(c.Model);
                }

            }
            else if (command == "flammable")
            {
                List<Car> cars = new();
                foreach (var car in carsData.Values)
                {
                    if (car.Cargo.Type == "flammable")
                    {
                        if (car.Engine.Power > 250)
                        {
                            cars.Add(car);
                        }


                    }
                }

                foreach (var c in cars)
                {
                    Console.WriteLine(c.Model);
                }


            }


        }


    }



}

