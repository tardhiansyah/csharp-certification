// nullable type string for the input variable and then evaluate it later
// string? readResult;

// int numericValue = 0;
// bool validNumber = false;
// Console.WriteLine("Enter a string");
// do
// {
//     readResult = Console.ReadLine();

//     // convert string to int
//     validNumber = int.TryParse(readResult, out numericValue);
//     Console.WriteLine(validNumber);
// } while (readResult != null);


// =========================CODE PROJECT 1=========================
// string? readResult;
// int numericValue = 0;
// bool validNumber = false;

// Console.WriteLine("Please input whole number between 5 and 10!\nInput Number:");

// do
// {
//     readResult = Console.ReadLine();
//     validNumber = int.TryParse(readResult, out numericValue);

//     if (!validNumber)
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//         continue;
//     }

//     if (numericValue > 5 && numericValue < 10) continue;

//     Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");

// } while (numericValue <= 5 || numericValue >= 10);

// Console.WriteLine($"Your input value ({numericValue}) has been accepted.");


// =========================CODE PROJECT 2=========================
// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

// string? readResult;
// string roleName = "";
// bool validRoleName = false;
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult == null) continue

//     roleName = readResult.Trim();

//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
//         validRoleName = true;
//     else
//         Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");

// } while (!validRoleName);

// Console.WriteLine($"Your input value ({readResult}) has been accepted.");


// =========================CODE PROJECT 3=========================
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];
    int periodLocation = myString.IndexOf(".");
    
    while (periodLocation > 0)
    {
        Console.WriteLine($"{myString.Substring(0, periodLocation).TrimStart()}");

        myString = myString.Remove(0, periodLocation + 1);
        periodLocation = myString.IndexOf(".");
    }

    Console.WriteLine($"{(myString.TrimStart())}");
}
