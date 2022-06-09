// A string literal is specified inside double quotes:
const string h = "Heat";

Print(nameof(h), h);

// string is a reference type, rather than a value type. Its equality operators, however,
// follow value-type semantics:
const string a = "test";
const string b = "test";

Print("a == b", a == b); // True

// The escape sequences that are valid for char literals also work inside strings:
const string t = "Here's a tab:\t";

Print(nameof(t), t);

// The cost of this is that whenever you need a literal backslash, you must write it twice:
const string a1 = "\\\\server\\fileshare\\helloworld.cs";

Print(nameof(a1), a1);

// To avoid this problem, C# allows "verbatim string literals" - prefixed with @ symbols:
const string a2 = @"\\server\fileshare\helloworld.cs";

Print(nameof(a2), a2);

// A verbatim string literal can also span multiple lines:
const string escaped = "First Line\r\nSecond Line";
const string verbatim = @"First Line
Second Line";

Print(nameof(escaped), escaped);
Print(nameof(verbatim), verbatim);
// Assuming your IDE uses CR-LF line separators:
Print("escaped == verbatim", escaped == verbatim);

// You can include the double-quote character in a verbatim literal by writing it twice:
const string xml = @"<customer id=""123""></customer>";
Print(nameof(xml), xml);

void Print(string name, object o)
{
    Console.WriteLine($"{name}: {o}");
}