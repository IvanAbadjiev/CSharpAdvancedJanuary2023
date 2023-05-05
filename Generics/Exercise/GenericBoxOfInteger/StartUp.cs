namespace GenericBoxOfInteger;
public class StartUp
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Box<int> box = new();

        for (int i = 0; i < n; i++)
        {
            int item = int.Parse(Console.ReadLine());

            box.Add(item);

        }
        Console.WriteLine(box.ToString());

    }

}