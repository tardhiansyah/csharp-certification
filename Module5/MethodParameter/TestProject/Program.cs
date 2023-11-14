//int[] schedule = { 800, 1200, 1600, 2000 };
//DisplayAdjustedTimes(schedule, 6, -6);


//void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
//{
//    int diff = 0;
//    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//    {
//        Console.WriteLine("Invalid GMT");
//    }
//    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//    {
//        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//    }
//    else 
//    {
//        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//    }

//    for (int i = 0; i < times.Length; i++)
//    {
//        int newTime = (times[i] + diff) % 2400;
//        Console.WriteLine($"{times[i]} -> {newTime}");
//    }
//}   


//string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

//DisplayStudents(students);
//DisplayStudents(new string[] { "Robert", "Vanya" });


//void DisplayStudents(string[] students)
//{
//    foreach (string student in students)
//    {
//        Console.Write($"{student}, ");
//    }
//    Console.WriteLine();
//}


// PARAMETER PASSED BY VALUE AND PASSED BY REFERNCE
// Test pass by value
//using System.Numerics;

//int a = 3;
//int b = 4;
//int c = 0;

//Multiply(a, b, c);
//Console.WriteLine($"global statementL {a} x {b} = {c}");

//void Multiply(int a, int b, int c)
//{
//    c = a * b;
//    Console.WriteLine($"Inside Multiply method: {a} x {b} = {c}");
//}

//// Test pass by reference
//int[] array = { 1, 2, 3, 4, 5 };
//PrintArray(array);
//Clear(array);
//PrintArray(array);

//void PrintArray(int[] array)
//{
//    foreach (int a in array)
//    {
//        Console.WriteLine($"{a} ");
//    }
//}

//void Clear(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = 0;
//    }
//}

//// Test with strings, although string is a reference value type, but it's immutable so it can't be altered once it's assigned.
//string status = "Healthy";

//Console.WriteLine($"Start: {status}");
//SetHealth(status, false);
//Console.WriteLine($"End: {status}");

//void SetHealth(string status, bool isHealthy)       // Change the status var to Global Var to solve the issue. // void SetHealth(bool isHealthy)  
//{
//    status = (isHealthy ? "Healthy" : "Unhealthy");
//    Console.WriteLine($"Middle: {status}");
//}


// METHOD WITH OPTIONAL PARAMETERS
string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();



void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        // Search guestList before adding RSVP
        bool found = false;
        foreach (string guest in guestList)
        {
            found = true;
            break;
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}


void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}