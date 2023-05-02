namespace RawData;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Car> cars = new();

        for (int i = 0; i < n; i++)
        {
            string[] curentCar = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = curentCar[0];
            double fuelAmount = double.Parse(curentCar[1]);
            double fuelConsumptionFor1km = double.Parse(curentCar[2]);

            Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);

            cars.Add(car.Model, car);
        }

        string command = string.Empty;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string carModel = cmdArgs[1];
            double amount = double.Parse(cmdArgs[2]);

            double consumation = cars[carModel].Drive(cars[carModel], amount);

            if (consumation > 0)
            {

                cars[carModel].FuelAmount -= consumation;
                cars[carModel].TravelledDistance += amount;



            }
        }
        foreach (var car in cars.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");




        }

    }

}