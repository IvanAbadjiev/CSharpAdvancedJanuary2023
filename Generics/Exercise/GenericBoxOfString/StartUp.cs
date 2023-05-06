namespace GenericBoxOfString;
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
        Console.WriteLine(box.ToString());

    }

}