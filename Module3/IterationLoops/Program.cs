string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
    if (names[i].Equals("David")) names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);