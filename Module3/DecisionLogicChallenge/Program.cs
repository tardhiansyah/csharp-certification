string[] user = new string[] { "Admin", "Manager", "User"};
Random number = new Random();
string permission = user[number.Next(3)];

Random level = new Random();
int accessLevel = level.Next(70);

if (permission.Contains("Admin"))
{
    if (accessLevel > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    else
        Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    if (accessLevel >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("Guest is prohibited to enter.");
}