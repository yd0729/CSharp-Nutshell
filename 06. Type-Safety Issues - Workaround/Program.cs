for (int i = 0; i <= 16; i++)
{
    BorderSides side = (BorderSides)i;
    Console.WriteLine(IsFlagDefined(side) + " " + side);
}

bool IsFlagDefined(Enum e)
{
    // 如果 e 没有定义，那么 ToString 就会返回一个数字，就可以被 Parse 到 decimal ．
    // 使用 decimal 大概是因为 Enum 可以使用很多种 integral type ，而它们它们都可以转换到 decimal ？
    return !decimal.TryParse(e.ToString(), out _);
}

[Flags]
public enum BorderSides
{
    Left = 1,
    Right = 2,
    Top = 4,
    Bottom = 8
}