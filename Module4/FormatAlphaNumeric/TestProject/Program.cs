// // Composite Formating use numbered placeholders within a string.
// string first = "Hello";
// string second = "World";

// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);


// // String interpolation simplifies composite formatting
// Console.WriteLine();
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");


// // Formatting currency
// // it's affected by user OS localization settings such as culture code like: en-US, fr-FR, fr-CA
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");


// // Formatting number
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");   // N default numeric format specifies only two digit after decimal
// Console.WriteLine($"Measurement: {measurement:N4} units");


// // Formatting percentages
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");


// // Combining formatting approach
//decimal price = 67.55m;
//decimal salePrice = 59.99m;

//string yourDiscount = $"You saved {(price - salePrice):C2} off the regular {price:C2} price.";
//Console.WriteLine(yourDiscount);


// STRING INTERPOLATION
//int invoiceNumber = 1201;
//decimal productShares = 25.468m;
//decimal subTotal = 2750.00m;
//decimal taxPercentage = .15825m;
//decimal total = 3185.19m;

//Console.WriteLine($"Invoice Number: {invoiceNumber}");
//Console.WriteLine($"Share: {productShares:N3} Product");
//Console.WriteLine($"    Sub total: {subTotal:C}");
//Console.WriteLine($"        Tax: {taxPercentage:P2}");
//Console.WriteLine($"    Total Billed: {total:C}");


// DISCOVER PADDING AND ALIGNMENT
/*
    Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
    Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
    Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
    Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
    Methods that turn a string into an array of strings or characters (Split(), ToCharArray())
*/

string paymentID = "769";
string payeeName = "Mr. Bing Cilin";
string paymentAmount = "$5.000,00";

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadRight(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);