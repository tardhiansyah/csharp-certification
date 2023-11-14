Random random = new Random();
int daysUntileExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntileExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else
{
    if (daysUntileExpiration == 1)
    {
        Console.WriteLine("Your subscription expires within a day!");
        discountPercentage = 20;
    }
    else if (daysUntileExpiration <= 5)
    {
        Console.WriteLine($"Your subscription expires in {daysUntileExpiration} days.");
        discountPercentage = 10;
    }
    else if (daysUntileExpiration <= 10)
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}