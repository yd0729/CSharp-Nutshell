using System.Globalization;

int thousand = int.Parse ("3E8", NumberStyles.HexNumber);
Console.WriteLine(thousand);

int minusTwo = int.Parse ("(2)", NumberStyles.Integer | NumberStyles.AllowParentheses);
Console.WriteLine(minusTwo);

Console.WriteLine($"million: {double.Parse ("1,000,000", NumberStyles.Any)}");
Console.WriteLine($"3 million: {decimal.Parse ("3e6", NumberStyles.Any)}");
Console.WriteLine($"5.2: {decimal.Parse ("$5.20", NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"))}");

var ni = new NumberFormatInfo
{
    CurrencySymbol = "€",
    CurrencyGroupSeparator = " "
};
Console.WriteLine($"million: {double.Parse ("€1 000 000", NumberStyles.Currency, ni)}");
