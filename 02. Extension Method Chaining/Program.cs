// Extension methods, like instance methods, provide a tidy way to chain functions:

string x = "sausage".Pluralize().Capitalize();

// Equivalent to:
string y = StringHelper.Capitalize(StringHelper.Pluralize("sausage"));

public static class StringHelper
{
    public static string Pluralize(this string s) => s + "s"; // Very naive implementation!

    public static string Capitalize(this string s) => s.ToUpper();
}