// char literals:

using System.Globalization;

char c = 'A';
char newLine = '\n';

// System.Char defines a range of static methods for working with characters:
Console.WriteLine(char.ToUpper('c')); // C
Console.WriteLine(char.ToUpper('i', CultureInfo.InvariantCulture));  // 和地区无关
Console.WriteLine(char.ToUpperInvariant('i'));

Console.WriteLine(char.IsWhiteSpace('\t')); // True
Console.WriteLine(char.IsLetter('x')); // True

Console.WriteLine(char.GetUnicodeCategory('x')); // LowercaseLetter