using System.Globalization;

int[] milligramsOfCaffeinе = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray(); //stack
int[] energyDrinks = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray(); // queue

Stack<int> caffeinе = new Stack<int>(milligramsOfCaffeinе);
Queue<int> drinks = new Queue<int>(energyDrinks);

const int maximumCaffeine = 300;
int startCaffein = 0;

while (true)
{
    if (caffeinе.Count == 0 || drinks.Count == 0)
    {
        break;
    }

    int currentMilligramsCaffein = caffeinе.Peek() * drinks.Peek();
    if ((startCaffein + currentMilligramsCaffein) <= maximumCaffeine)
    {
        startCaffein += currentMilligramsCaffein;
        caffeinе.Pop();
        drinks.Dequeue();

    }
    else
    {
        caffeinе.Pop();
        int drinksToMove = drinks.Dequeue();
        drinks.Enqueue(drinksToMove);
        if (startCaffein >= 30)
        {
            startCaffein -= 30;
        }

    }


}

if (drinks.Count > 0)
{
    Console.Write("Drinks left: ");
    Console.WriteLine(String.Join(", ", drinks));
}
else
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}

Console.WriteLine($"Stamat is going to sleep with {startCaffein} mg caffeine.");