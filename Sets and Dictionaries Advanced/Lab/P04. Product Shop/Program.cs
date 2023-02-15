using System.Linq;

var shopInfo = new Dictionary<string, Dictionary<string, double>>();

while (true)
{
    string[] productInfo = Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string shop = productInfo[0];
    if (shop == "Revision")
        break;

    string produkt = productInfo[1];
    double price = double.Parse(productInfo[2]);

    if (!shopInfo.ContainsKey(shop))
        shopInfo.Add(shop, new Dictionary<string, double>());

    shopInfo[shop].Add(produkt, price);
}

var orderShopList = shopInfo.OrderBy(kp => kp.Key);
foreach (var pair in orderShopList)
{
    Console.WriteLine($"{pair.Key}->");
    foreach (var innerPair in pair.Value)
    {
        Console.WriteLine("Product: {0}, Price: {1}", innerPair.Key, innerPair.Value);
    }
}