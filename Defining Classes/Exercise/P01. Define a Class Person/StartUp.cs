namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            // TODO: define the Main() method here ...
            Person peter = new("Petur", 20);


            Person george = new("Georgi", 18);



            Console.WriteLine($"{peter.Name} is {peter.Age} years old");
            Console.WriteLine($"{george.Name} is {george.Age} years old");



        }
    }
}









