// EXERCISE 1

string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split();

for (int i = 0; i < words.Length; i++)
{
    char[] characters = words[i].ToCharArray();
    Array.Reverse(characters);
    words[i] = new string(characters);
}

string reversedPangram = string.Join(" ", words);
Console.WriteLine(reversedPangram);


// EXERCISE 2

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIDs = orderStream.Split(',');
Array.Sort(orderIDs);

foreach (string orderID in orderIDs)
{
    if (orderID.Length == 4)
        Console.WriteLine(orderID);
    else
        Console.WriteLine($"{orderID}\t\t- Error");
}
