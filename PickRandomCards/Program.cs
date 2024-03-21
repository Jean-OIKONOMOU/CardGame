using PickRandomCards;

Console.WriteLine("Hello master, how many random cards would you like ?");

string? line = Console.ReadLine();

if (line == null)
{
    line = "1";
}

if (int.TryParse(line, out int id))
{
    string[] deck = CardPicker.PickSomeCards(id);
    foreach (var card in deck)
    {
        Console.WriteLine($"==> {card}");
    }
    Console.WriteLine($"Here is your {deck.Length} card deck, master.");
}
