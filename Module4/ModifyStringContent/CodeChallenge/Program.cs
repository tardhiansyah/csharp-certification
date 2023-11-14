const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// TODO: Extract, Replace, dan Remove data
/* OUTPUT FORMAT:
 * Quantity: 5000
 * Output: <h2>Widgets &reg;</h2><span>5000</span>
 */

string startKeyword = "<span>";
int startPosition = input.IndexOf(startKeyword);

string stopKeyword = "</span>";
int endPosition = input.IndexOf(stopKeyword);

if (startPosition != -1 && endPosition != -1)
{
    // overloading
    startPosition += startKeyword.Length;
    int lengthOfData = endPosition - startPosition; 
    quantity = input.Substring(startPosition, lengthOfData);
    output = input.Replace("<div>", "");
    output = output.Replace("</div>", "");
    output = output.Replace("trade", "reg");

    Console.WriteLine(quantity);
    Console.WriteLine(output);
}