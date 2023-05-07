namespace GenericCountMethodStrings;
public class StartUp
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Box<String> box = new();

        for (int i = 0; i < n; i++)
        {
            string item = Console.ReadLine();

            box.Add(item);

        }

        //int[] indexes = Console.ReadLine()
        //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        //    .Select(int.Parse)
        //    .ToArray();

        //int firstIndex = indexes[0];
        //int secondIndex = indexes[1];
        //box.Swap(firstIndex, secondIndex);
        string el = Console.ReadLine();

        Console.WriteLine(box.Count(el));

    }

}