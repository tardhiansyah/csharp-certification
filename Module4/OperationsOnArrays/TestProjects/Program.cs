// // SORTED
// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (string pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed..");
// Array.Reverse(pallets);

// foreach(var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// // CLEARED
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2); // dengan di clear artinya ini null bukan empty string
// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 .. count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// // RESIZE BIGGER
// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// // RESIZE SMALLER
// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// // USE ToCharArray() to reverse a string
// string value = "abc123";
// char[] valueArray = value.ToCharArray();

// Array.Reverse(valueArray);
// string result = new string(valueArray);

// Console.WriteLine(result);


// COMBINE ALL OF THE CHARS into new csv string
// string value = "abc123";
// char[] valueArray = value.ToCharArray();

// Array.Reverse(valueArray);
// string result = string.Join(",", valueArray);

// Console.WriteLine(result);


// // SPLIT the csv string into array of string
// string value = "abc123";
// char[] valueArray = value.ToCharArray();

// Array.Reverse(valueArray);
// string result = string.Join(",", valueArray);

// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }