namespace GenericCountMethodDoubles;
public class StartUp
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Box<double> box = new();

        for (int i = 0; i < n; i++)
        {
            double item = double.Parse(Console.ReadLine());

            box.Add(item);

        }

        //int[] indexes = Console.ReadLine()
        //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        //    .Select(int.Parse)
        //    .ToArray();

        //int firstIndex = indexes[0];
        //int secondIndex = indexes[1];
        //box.Swap(firstIndex, secondIndex);
        double el = double.Parse(Console.ReadLine());

        Console.WriteLine(box.Count(el));

    }

}