string[] inputText = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> repeatValue = new Dictionary<string, int>();

for (int index = 0; index < inputText.Length; index++)
{
    if (!repeatValue.ContainsKey(inputText[index]))
        repeatValue.Add(inputText[index], 0);

    repeatValue[inputText[index]] += 1;

}
foreach (KeyValuePair<string, int> entry in repeatValue)
{
    Console.WriteLine($"{entry.Key} - {entry.Value} times");
}