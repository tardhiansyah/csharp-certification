/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    validLength = ValidateLength(ip);
    validZeroes = ValidateZeroes(ip);
    validRange = ValidateRange(ip);

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"ip {ip} is a valid IP4 address");
        continue;
    }

    Console.WriteLine($"ip {ip} is an invalid IP4 address");
}



bool ValidateLength(string input)
{
    string[] address = input.Split(".", StringSplitOptions.RemoveEmptyEntries);
    return address.Length == 4;
}

bool ValidateZeroes(string input)
{
    string[] address = input.Split(".");

    // StringSplitOptions.RemoveEmptyEntries digunakan untuk menghilangkan empty entries dari address

    foreach (String number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
            return false;
    }

    return true;
}

bool ValidateRange(string input) 
{
    string[] address = input.Split(".", StringSplitOptions.RemoveEmptyEntries);



    foreach (String number in address)
    {
        if (int.Parse(number) > 255)
            return false;
    }

    return true;
}