﻿string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

Console.WriteLine(comparisonMessage);

/* DESIRED OUTPUT
    Dear Ms. Barros,
    As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

    Currently, you own 2,975,000.00 shares at a return of 12.75 %.

    Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

    Here's a quick comparison:

    Magic Yield         12.75 %   $55,000,000.00      
    Glorious Future     13.13 %   $63,000,000.00 
*/

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");


Console.WriteLine($"{currentProduct.PadRight(24)}{currentReturn:P2}\t{currentProfit:C}");
Console.WriteLine($"{newProduct.PadRight(24)}{newReturn:P2}\t{newProfit:C}");

