string guestNumber = string.Empty;


var vipGuest = new HashSet<string>();
var regularGuest = new HashSet<string>();
while ((guestNumber = Console.ReadLine()) != "PARTY")
{
    char firstCharGuestNumber = guestNumber[0];
    AddToPartyList(guestNumber, vipGuest, regularGuest, firstCharGuestNumber);

}

while ((guestNumber = Console.ReadLine()) != "END")
{
    char firstCharGuestNumber = guestNumber[0];
    RemoveToPartyList(guestNumber, vipGuest, regularGuest, firstCharGuestNumber);
}

Console.WriteLine(vipGuest.Count + regularGuest.Count);
if (vipGuest.Count > 0)
{
    Console.WriteLine(string.Join(Environment.NewLine, vipGuest));
}
if (regularGuest.Count > 0)
{
    Console.WriteLine(string.Join(Environment.NewLine, regularGuest));
}
static void AddToPartyList(string guestNumber, HashSet<string> vipGuest, HashSet<string> regularGuest, char firstCharGuestNumber)
{
    if (char.IsDigit(firstCharGuestNumber))
    {
        //Add to vip
        vipGuest.Add(guestNumber);

    }
    else
    {
        //Add to regular
        regularGuest.Add(guestNumber);

    }
}
static void RemoveToPartyList(string guestNumber, HashSet<string> vipGuest, HashSet<string> regularGuest, char firstCharGuestNumber)
{
    if (char.IsDigit(firstCharGuestNumber))
    {
        //Remove to vip
        vipGuest.Remove(guestNumber);
    }
    else
    {
        //Remove to regular
        regularGuest.Remove(guestNumber);
    }
}