﻿string[][] userEnteredValues = new string[][]
{
    new string[] { "1", "2", "3"},
    new string[] { "1", "two", "3"},
    new string[] { "0", "1", "2"}
};


try
{
    Workflow1(userEnteredValues);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine($"Invalid data. {ex.Message}");
    Console.WriteLine();
}


static void Workflow1(string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);

            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine($"Invalid Data. {ex.Message}");
            Console.WriteLine();
        }
    }
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            try
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("User input values must be valid integer.");
        }
    }
}