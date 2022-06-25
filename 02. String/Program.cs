// String literals
{
    // A string literal is specified inside double quotes:
    string h = "Heat";

    // string is a reference type, rather than a value type. Its equality operators, however,
    // follow value-type semantics:
    string a = "test";
    string b = "test";
    Console.WriteLine(a == b);  // True

    // The escape sequences that are valid for char literals also work inside strings:
    string t = "Here's a tab:\t";

    // The cost of this is that whenever you need a literal backslash, you must write it twice:
    string a1 = "\\\\server\\fileshare\\helloworld.cs";

    // To avoid this problem, C# allows "verbatim string literals" - prefixed with @ symbols:
    string a2 = @"\\server\fileshare\helloworld.cs";

    // A verbatim string literal can also span multiple lines:
    string escaped = "First Line\r\nSecond Line";
    string verbatim = @"First Line
Second Line";

    // Assuming your IDE uses CR-LF line separators:
    Console.WriteLine(escaped == verbatim);  // True

    // You can include the double-quote character in a verbatim literal by writing it twice:
    string xml = @"<customer id=""123""></customer>";
}

// String concatenation
{
    // The + operator concatenates two strings:
    string s1 = "a" + "b";

    // The righthand operand may be a nonstring value, in which case ToString is called on that value:
    string s2 = "a" + 5;   // a5
}

// String ingerpolation
{
    // A string preceded with the $ character is an interpolated string:

    int x = 4;
    Console.WriteLine($"A square has {x} sides");    // Prints: A square has 4 sides

    string s = $"255 in hex is {byte.MaxValue:X2}";   // X2 = 2-digit Hexadecimal

    x = 2;
    s = $@"this spans {x} lines";

    // Legal from C# 10:

    const string greeting = "Hello";
    const string message = $"{greeting}, world";
}