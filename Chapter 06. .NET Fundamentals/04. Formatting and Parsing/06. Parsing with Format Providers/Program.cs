using System.Globalization;

// There’s no standard interface for parsing through a format provider; instead use Parse/TryParse methods
// on the target types:

try
{
    int error = int.Parse("(2)"); // Exception thrown
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}

int minusTwo = int.Parse("(2)", NumberStyles.Integer | NumberStyles.AllowParentheses); // () 代表是负数
Console.WriteLine(minusTwo);

decimal fivePointTwo = decimal.Parse("£5.20", NumberStyles.Currency, CultureInfo.GetCultureInfo("en-GB"));
Console.WriteLine(fivePointTwo);