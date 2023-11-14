/*
    WIDENING CONVERSION (LESS -> MORE INFO)
*/
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");


/*
    NARROWING CONVERSION (MORE -> LESS INFO)
*/
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float: {myFloat}");

/*
    CASTING (EXPLICIT CONVERSION)
*/
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");;

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");


/*
    DATA CONVERSION TECHNIQUES:
    1. helper method on the variable
    2. helper method on the data type
    3. use the "Convert class" method 
*/

// ToString()
// int first = 5;
// int second = 6;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// Parse() or better use TryParse()
// string first = "5";
// string second = "6";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// Convert class (better to use when convert fractional number into whole number)
// string value1 = "5";
// string value2 = "6";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// int value3 = (int)1.5m;
// Console.WriteLine(value3);

// int value4 = Convert.ToInt32(1.5m);
// Console.WriteLine(value4);


/*
    TRY PARSE
*/

string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
    Console.WriteLine($"Measurement: {result}");
else
    Console.WriteLine($"Unable to report the measurement.");

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");