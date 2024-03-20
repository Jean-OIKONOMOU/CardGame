using PickRandomCards;

var _array = CardPicker.PickSomeCards(5);

foreach (var item in _array)
{
    Console.WriteLine($" ==> {item}");
}

//Console.Write($" ==> {string.Join(" ==> ", _array)}");