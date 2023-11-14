for (int i = 0; i <= 100; i++)
{
    string term = "";
    // term += i % 3 == 0 ? "Fizz" : "";
    // term += i % 5 == 0 ? "Buzz" : "";

    if (i % 3 == 0)
        term += "Fizz";

    if (i % 5 == 0)
        term += "Buzz";

    Console.WriteLine($"{i} - {term}");
}