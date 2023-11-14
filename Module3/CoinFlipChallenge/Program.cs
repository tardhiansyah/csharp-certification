Random coin = new Random();
string flipResult = (coin.Next(2) == 0)? "Heads" : "Tails";
Console.WriteLine($"Flip Result: {flipResult}");