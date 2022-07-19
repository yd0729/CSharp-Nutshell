// The extension method with more specific arguments wins. Classes & structs are
// considered more specific than interfaces:

"Perth".IsCapitalized();

static class StringHelper
{
    public static bool IsCapitalized(this string s)
    {
        Console.WriteLine("StringHelper.IsCapitalized");
        return char.IsUpper(s[0]);
    }
}

static class EnumerableHelper
{
    public static bool IsCapitalized(this IEnumerable<char> s)
    {
        Console.WriteLine("Enumerable.IsCapitalized");
        return char.IsUpper(s.First());
    }
}