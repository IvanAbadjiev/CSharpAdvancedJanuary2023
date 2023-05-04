namespace BoxOfT;
using BoxOfT;
public class StartUp
{
    public static void Main(string[] args)
    {

        Box<int> box = new Box<int>();
        box.Add(1);
        box.Add(3);
        box.Add(4);

        Console.WriteLine(box.Remove());

        box.Add(5);
        box.Add(6);

        Console.WriteLine(box.Count);
    }

}