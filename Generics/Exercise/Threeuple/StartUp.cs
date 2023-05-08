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


        bool drunkOrNot = false;
        if (drinkToken[2] == "drunk")
        {
            drunkOrNot = true;
        }
        CustumTuple<string, string, string> nameAndAdres;
        if (personToken.Length == 5)
        {
            nameAndAdres = new($"{personToken[0]} {personToken[1]}", personToken[2], $"{personToken[3]} {personToken[4]}");
        }
        else
        {
            nameAndAdres = new($"{personToken[0]} {personToken[1]}", personToken[2], personToken[3]);
        }

        CustumTuple<string, int, bool> nameAndBear = new(drinkToken[0], int.Parse(drinkToken[1]), drunkOrNot);

        CustumTuple<string, double, string> numbers = new(numberToken[0], double.Parse(numberToken[1]), numberToken[2]);

        Console.WriteLine(nameAndAdres);
        Console.WriteLine(nameAndBear);
        Console.WriteLine(numbers);

    }


}