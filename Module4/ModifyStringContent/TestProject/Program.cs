//string message = "(What if) I am (only interested) in the last (set of parentheses)?";

//int openingPosition = message.LastIndexOf('(');
//openingPosition += 1;

//int closingPosition = message.LastIndexOf(')');

//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));



// RETRIEVE ALL INSTANCES
//string message = "(What if) there are (more than) one (set of parentheses)?";
//while (true)
//{
//    int openingPosition = message.IndexOf('(');
//    if (openingPosition < 0) break;

//    openingPosition += 1;

//    int closingPosition = message.IndexOf(')');
//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));

//    // Note the overload of the substring to return only the remaining
//    // unprocessed message: 
//    message = message.Substring(closingPosition + 1);
//}



// WORK WITH DIFFERENT TYPES OF SYMBOL SETS

//string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

//// The IndexOfAny() helper method requires a char array of characters. 
//// You want to look for:

//char[] openSymbols = { '[', '{', '(' };

//// You'll use a slightly different technique for iterating through 
//// the characters in the string. This time, use the closing 
//// position of the previous iteration as the starting index for the 
//// next open symbol. So, you need to initialize the closingPosition 
//// variable to zero:
    
//int closingPosition  = 0;

//while (true)
//{
//    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//    if (openingPosition < 0) break;

//    string currentSymbol = message.Substring(openingPosition, 1);

//    // Now fing the matching closing symbol

//    char matchingSymbol = ' ';
//    switch (currentSymbol)
//    {
//        case "[":
//            matchingSymbol = ']';
//            break;
//        case "{":
//            matchingSymbol = '}';
//            break;
//        case "(":
//            matchingSymbol = ')';
//            break;
//    }

//    // To find the closingPosition, use an overload of the IndexOf method to specify 
//    // that the search for the matchingSymbol should start at the openingPosition in the string.
//    openingPosition += 1;
//    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//    // Finally, use the techniques you've already learned to display the sub-string:
//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));
//}



// REMOVE CHAR IN SPECIFIC LOCATION
string data = "12345John Smith          5000    3   ";
string updateData = data.Remove(5, 20);
Console.WriteLine(updateData);


// REMOVE CHARACTERS
string message = "this--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);