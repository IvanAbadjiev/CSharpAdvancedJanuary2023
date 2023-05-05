namespace GenericScale;

public class StartUp
{
    public static void Main(string[] args)
    {
        EqualityScale<int> ex = new EqualityScale<int>(5, 6);

        Console.WriteLine(ex.AreEqual());
    }

}