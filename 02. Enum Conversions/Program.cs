// You can convert an enum instance to and from its underlying integral value with an explicit cast:

int i = (int)BorderSide.Left;

BorderSide side = (BorderSide)i;

bool leftOrRight = (int)side <= 2;

HorizontalAlignment h = (HorizontalAlignment)BorderSide.Right;

BorderSide b = 0; // No cast required with the 0 literal.

public enum BorderSide
{
    Left,
    Right,
    Top,
    Bottom
}

public enum HorizontalAlignment
{
    Left = BorderSide.Left,
    Right = BorderSide.Right,
    Center
}