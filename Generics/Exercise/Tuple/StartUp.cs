namespace Tuple;

public class StartUp
{
    public static void Main(string[] args)
    {
        string[] personToken = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string[] drinkToken = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string[] numberToken = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        CustumTuple<string, string> nameAndAdres = new($"{personToken[0]} {personToken[1]}", personToken[2]);

        CustumTuple<string, int> nameAndBear = new(drinkToken[0], int.Parse(drinkToken[1]));

        CustumTuple<int, double> numbers = new(int.Parse(numberToken[0]), double.Parse(numberToken[1]));

        Console.WriteLine(nameAndAdres);
        Console.WriteLine(nameAndBear);
        Console.WriteLine(numbers);

    }


}