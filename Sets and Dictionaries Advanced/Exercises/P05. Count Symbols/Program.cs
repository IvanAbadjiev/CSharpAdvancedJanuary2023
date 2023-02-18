string text = Console.ReadLine();

var textInfo = new SortedDictionary<char, int>();
for (int i = 0; i < text.Length; i++)
{
    char curSimbol = text[i];
    if (!textInfo.ContainsKey(curSimbol))
        textInfo.Add(curSimbol, 0);

    textInfo[curSimbol]++;
}

foreach (var symbol in textInfo)
{
    Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
}