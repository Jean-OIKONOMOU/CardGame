using PickRandomCards;

static void AskForADeck()
{ 
    string? line = Console.ReadLine();

    if (line == null)
    {
        line = "1";
    }

    if (int.TryParse(line, out int id)) {
        string[] deck = CardPicker.PickSomeCards(id);
        foreach (var card in deck)
        {
            Console.WriteLine($"==> {card}");
        }
        Console.WriteLine($"Here is your {deck.Length} card deck, master.");
        Console.WriteLine("Would you like to ask again, master ? Type Y or y to try again, anything else will end the program.");
        string? tryAgain = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(tryAgain) && !string.IsNullOrWhiteSpace(tryAgain))
        {
            if (tryAgain == "Y" || tryAgain == "y") {
                Console.WriteLine("Master, please, provide me with a digit.");
                AskForADeck();
            }
            else
            {
                Console.WriteLine("Goodbye, master.");
                return;
            }
        }

    } else {
        Console.WriteLine($"Master, I could not interpret your digit. Please, try again.");
        AskForADeck();
    }
};

Console.WriteLine("Hello master, how many random cards would you like ? Please, provide me with a digit.");
AskForADeck();

