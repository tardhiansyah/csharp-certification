string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    // format email address: 2 huruf nama depan + namabelakang + contoso.com
    CreateEmailAddress(corporate[i,0], corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    CreateEmailAddress(corporate[i, 0], corporate[i, 1], domain: externalDomain);
}

void CreateEmailAddress(string firstName, string lastName, string domain = "contoso.com")
{
    string email = firstName.Substring(0, 2).ToLower();
    email += lastName.ToLower();
    Console.WriteLine($"Email: {email}@{domain}");
}