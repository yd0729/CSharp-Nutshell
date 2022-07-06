// For convenience, you can include combination members within an enum declaration itself:
Console.WriteLine(BorderSides.All);

// The bitwise, arithmetic, and comparison operators return the result of processing
// the underlying integral values:	
Console.WriteLine(BorderSides.All ^ BorderSides.LeftRight);

[Flags]
public enum BorderSides
{
    None = 0,
    Left = 1, Right = 2, Top = 4, Bottom = 8,
    LeftRight = Left | Right,
    TopBottom = Top | Bottom,
    All = LeftRight | TopBottom
}