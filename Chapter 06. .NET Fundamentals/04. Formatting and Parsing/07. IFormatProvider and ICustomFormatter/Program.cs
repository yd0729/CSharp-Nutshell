using System.Globalization;
using System.Text;

double n = -123.45;
IFormatProvider fp = new WordyFormatProvider();
Console.WriteLine (string.Format (fp, "{0:C} in words is {0:W}", n));

public class WordyFormatProvider : IFormatProvider, ICustomFormatter
{
    private static readonly string[] NumberWords =
        "zero one two three four five six seven eight nine minus point".Split();
    private readonly IFormatProvider _parent;   // Allows consumers to chain format providers
	
    public WordyFormatProvider () : this (CultureInfo.CurrentCulture) { }
    public WordyFormatProvider (IFormatProvider parent)
    {
        _parent = parent;
    }
	
    // 实现 IFormatProvider
    public object? GetFormat (Type? formatType)
    {
        return formatType == typeof (ICustomFormatter) ? this : null;
    }
	
    // 实现 ICustomFormatter
    public string Format (string? format, object? arg, IFormatProvider? formatProvider)
    {
        // If it's not our format string, defer to the parent provider: 如果这个 format 不是我们定义的，交由父类处理
        if (arg == null || format != "W")
        {
            return string.Format (_parent, $"{{0:{format}}}", arg);
        }
	
        var result = new StringBuilder();
        var digitList = string.Format (CultureInfo.InvariantCulture, "{0}", arg);  // 这里用 Invariant Culture
        foreach (var digit in digitList)
        {
            int i = "0123456789-.".IndexOf (digit);  // 是因为这里的 digit 是 Culture Invariant 的。
            if (i == -1) continue;
            if (result.Length > 0) result.Append (' ');
            result.Append (NumberWords[i]);
        }
        return result.ToString();
    }
}